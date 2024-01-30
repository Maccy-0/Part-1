using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float speed;
    int direction;
    public int type; //1 = left right 2 = top down
    // Start is called before the first frame update
    void Start()
    {
        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (type == 1)
        {
            Vector2 movement = new Vector2(speed * Time.deltaTime * direction, 0);
            rigidbody.MovePosition(rigidbody.position + movement);
        }
        if (type == 2)
        {
            Vector2 movement = new Vector2(0, speed * Time.deltaTime * direction);
            rigidbody.MovePosition(rigidbody.position + movement);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (direction < 0)
        {
            direction = 1;
            Debug.Log("1");
        }
        else
        {
            if (direction > 0)
            {
                direction = -1;
                Debug.Log("-1");
            }
        }
    }
}
