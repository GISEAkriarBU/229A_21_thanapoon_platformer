using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{
    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Init(10);
        Debug.Log($"{Health}");
       

    }
    private void FixedUpdate()
    {
         Behaviour();
    }


    public override void Behaviour()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        if (rb.position.x <= movePoints[0].position.x && velocity.x < 0)
        {
            flip();
        }
        else if (rb.position.x <= movePoints[1].position.x && velocity.x < 0)
        {
            flip();
        }
    }

    private void flip()
    {
        velocity *= -1; Vector2 charScale = transform.localScale; charScale.x *= -1; transform.localScale = charScale;
    }
}