using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float speed = 10f;
    private void test(){ print("Fuck"); }
    void OnEnable()
    {
        Launch();
    }

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed * x, speed * y);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Goal1"))
        {
            GameManager.gameManager.player1Goal = true;
            
            // print(1);
        }
        else if (other.gameObject.CompareTag("Goal2"))
        {
            GameManager.gameManager.player2Goal = true;
            // print(2);
        }
        if(other.gameObject.CompareTag("Goal1") || other.gameObject.CompareTag("Goal2")){
            // print("Reset");
            GameManager.gameManager.ResetBall();
            GameManager.gameManager.ResetPlayer();
        }
    }
}
