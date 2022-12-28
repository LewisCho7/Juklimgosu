using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    //private float damage = 7.0f;

    
    public static float arrowSpeed = 5.5f;

    private Vector3 playerDir;


    public void resetSpeed()
    {
        arrowSpeed = 5.5f;
    }
    public void Setup(Vector3 position)
    {
        playerDir = position;
    }

    private void Awake()
    {
        //arrowSpeed = 9f;
        /* Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, playerDir);
         transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 1*Time.deltaTime);

        color = GetComponent<SpriteRenderer>().color;*/
        
        
    }
    private void Update()
    {
        transform.position += playerDir.normalized * arrowSpeed * Time.deltaTime;
        //Debug.Log(playerDir.normalized.x.ToString() + " " + playerDir.normalized.y.ToString());
        float angle = Mathf.Atan2(playerDir.y, playerDir.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = q;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*player.GetComponent<PlayerController>().takeDamage(damage);
        color = Color.black;*/
        arrowSpeed = 0f;
        //collision.gameObject.SetActive(false);
        collision.gameObject.GetComponent<PlayerController>().moveSpeed = 0f;
        GameManager.instance.isHit = true;
        SoundManager.Instance.playSFX();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawLine(transform.position, playerDir);
    }
}
