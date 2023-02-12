using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb2d;
    public Vector3 startPos;

    void GoBall()
    {
        float rand = Random.Range(0, 2);
        float x = rand == 0 ? -1 : 1;
        float y = rand == 0 ? -1 : 1;
        rb2d.velocity = new Vector2(speed * x, speed * y);
    }
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        GoBall();
    }
    void Reset()
    {
        float rand = Random.Range(0, 2);
        rb2d.velocity = Vector3.zero;
        transform.position = startPos;
        Invoke("Start", rand);
    }
    public void Pause()
    {
        rb2d.velocity = Vector2.zero;
    }
    public void Resume()
    {
        GoBall();
    }
}
