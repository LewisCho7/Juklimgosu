using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    [SerializeField]
    private GameObject startButton;
    [SerializeField]
    private GameObject restartButton;


    private void Awake()
    {

    }
    public void gameStart()
    {
        SoundManager.Instance.playMainBGM();
        GameManager.instance.isStart = true;
        startButton.SetActive(false);
        Debug.Log("Start");
    }

    public void restartGame()
    {
        SoundManager.Instance.stopSFX();
        SoundManager.Instance.playMainBGM();
        GameManager.instance.isStart = true;
        restartButton.gameObject.SetActive(false);
        GameManager.instance.isHit = false;
        GameManager.instance.clearArrow();
        GameManager.instance.resetTime();
        Arrow.arrowSpeed = 5.5f;
        GameObject player = GameObject.Find("Player");
        player.transform.position = Vector3.zero;
        player.GetComponent<PlayerController>().moveSpeed = 6f;
    }

    private void Update()
    {
        if (GameManager.instance.isHit == true)
        {
            restartButton.SetActive(true);
        }
    }

}
