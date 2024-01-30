using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneUseEnemy : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(0, -speed * Time.deltaTime);
        rigidbody.MovePosition(rigidbody.position + movement);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
