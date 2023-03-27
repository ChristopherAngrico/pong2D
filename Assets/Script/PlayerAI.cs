using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAI : MonoBehaviour
{
    public float speed = 5f;

    private GameObject ball;

    private void Start()
    {
        ball = GameObject.Find("Ball");
    }

    private void FixedUpdate()
    {
        float ballY = ball.transform.position.y;
        float paddleY = transform.position.y;

        if (ballY > paddleY)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else if (ballY < paddleY)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        float topY = Camera.main.ViewportToWorldPoint(new Vector2(0, 1)).y;
        float bottomY = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).y;
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, bottomY, topY));
    }
}

