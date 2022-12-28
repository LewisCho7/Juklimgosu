using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private Transform[] SpawnPointArray;

    [SerializeField]
    private Transform[] CircleSpawnPointArray;

    [SerializeField]
    private GameObject arrow;

    [SerializeField]
    private Transform playerPos;

    
    
    private float spawnTime = 0.0f;
    private float circleSpawnTime = 0.0f;

    private void Awake()
    {

    }
   
    private void Update()
    {
        if(GameManager.instance.isStart == true)
        {
            spawnTime += Time.deltaTime;
            if (GameManager.time > 5)
            {
                circleSpawnTime += Time.deltaTime;
                circleSpawn();
            }

            normalSpawn();
        }
        
    }

    private void normalSpawn()
    {
        if (spawnTime >= 0.5f)
        {
            int spawnIndex = Random.Range(0, SpawnPointArray.Length);

            Vector3 pos = SpawnPointArray[spawnIndex].position;

            GameObject clone = Instantiate(arrow, pos, Quaternion.identity);

            Vector3 moveDirection = playerPos.position - pos;
            //Debug.Log(moveDirection.x.ToString() + " " + moveDirection.y.ToString());
            clone.GetComponent<Arrow>().Setup(moveDirection);
            Destroy(clone, 10f);

            spawnTime = 0.0f;
        }
    }

    private void circleSpawn()
    {
        if(circleSpawnTime >= 5f)
        {
            for(int i = 0; i < CircleSpawnPointArray.Length; i++)
            {
                Vector3 pos = CircleSpawnPointArray[i].position;
                GameObject clone = Instantiate(arrow, pos, Quaternion.identity);

                Vector3 moveDirection = playerPos.position - pos;
                //Debug.Log(moveDirection.x.ToString() + " " + moveDirection.y.ToString());
                clone.GetComponent<Arrow>().Setup(moveDirection);
                Destroy(clone, 10f);
            }
            circleSpawnTime = 0.0f;
        }
    }
}
