using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MoveSquare : MonoBehaviour
{
    public float speed = 2f;
    public Vector2 direction = Vector2.right;
    public Rigidbody2D rig;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        rig.velocity = direction * speed;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Collider>() != null) 
        { 
            rig.velocity = Vector2.zero;
        }
    }  
}
