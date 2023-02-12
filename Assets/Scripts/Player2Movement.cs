using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;
    public float speed = 10f;
    public float boundY = 4f;
    private Rigidbody2D rg2d;
    public bool isPause = false;

    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        var vel = rg2d.velocity;

        if (Input.GetKey(moveUp))
            vel.y = speed;
        else if (Input.GetKey(moveDown))
            vel.y = -speed;
        else
            vel.y = 0;

        rg2d.velocity = vel;

        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;
    }
    public void MovementPause()
    {
        if (isPause == true)
            rg2d.velocity = Vector2.zero;
        else
            FixedUpdate();
    }
}
