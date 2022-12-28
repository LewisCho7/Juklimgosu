using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static float time = 0.00f;
    public static float bestTime = 0.00f;

    private bool _isHit = false;
    public bool isHit
    {
        get { return _isHit; }
        set { _isHit = value; }
    }

    private bool _isStart = false;

    public bool isStart
    {
        get { return _isStart; }
        set { _isStart = value; }
    }

    private void Awake()
    {
        instance = this;
        time = 0f;
        bestTime = 0f;
       
    }

    public void setBest()
    {
        if(bestTime < time)
        {
            bestTime = time;
        }
    }

    public void resetTime()
    {
        time = 0.0f;
    }

    private void Update()
    {
        if(_isStart == true && _isHit == false)
        {
            time += Time.deltaTime;
        }
        if(isHit == true)
        {
            SoundManager.Instance.stopMainBGM();
            isStart = false;
            setBest();
            //resetTime();
        }
    }

    public void clearArrow()
    {
        GameObject[] arrowArr = GameObject.FindGameObjectsWithTag("Arrow");
        foreach(GameObject arrow in arrowArr)
        {
            Destroy(arrow);
        }
    }

}
