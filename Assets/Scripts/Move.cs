using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
    private float speed;

    private Vector3 direction;

    private Rigidbody rb;

    public Move(Rigidbody rb, float speed)
    {
        this.rb = rb;
        this.speed = speed;
    }
    public void MovePlayer(string x, string y)
    {
        direction.x = Input.GetAxisRaw(x);
        direction.y = Input.GetAxisRaw(y);
        rb.MovePosition(rb.position + direction * speed * Time.deltaTime);
    }
}
