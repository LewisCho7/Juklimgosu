using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
     TextMeshProUGUI resourceText;

    private void Awake()
    {
        resourceText = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        resourceText.text = "Best: " + GameManager.bestTime.ToString("F2") +  "\nTime: " + GameManager.time.ToString("F2");
    }
}
