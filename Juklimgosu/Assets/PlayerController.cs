using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*private float hp = 10f;



    public void takeDamage(float damage)
    {
        hp -= damage;
    }*/

    public float moveSpeed = 6f;

    private Rigidbody2D rb;
    private SpriteRenderer rend;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(x, y, 0) *moveSpeed;
        if (x > 0)
        {
            rend.flipX = true;
        }
        else if(x < 0)
        {
            rend.flipX = false;
        }
    }



}
