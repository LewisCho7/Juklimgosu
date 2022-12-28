using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    //private Color color;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.white;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer.color = Color.blue;
    }
   /* private void OnTriggerStay2D(Collider2D collision)
    {
        
    }*/

    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = Color.black;
    }
}
