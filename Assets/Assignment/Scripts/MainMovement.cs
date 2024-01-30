using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMovement : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rigidbody;
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        //Geting movement from the keyboard
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }
    
    void FixedUpdate()
    {
        //Adding movement to the player
        rigidbody.AddForce(direction * speed * Time.deltaTime);
    }
}
