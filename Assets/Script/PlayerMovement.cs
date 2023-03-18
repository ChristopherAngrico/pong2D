using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5; // speed of the paddle
    [SerializeField] private float boundaryY = 4.6f;
    private float inputY;
  

    private void Update()
    {
        if (gameObject.CompareTag("Player1"))
        {
             inputY = Input.GetAxisRaw("Vertical1");
        }
        else if(gameObject.CompareTag("Player2")){
            inputY = Input.GetAxisRaw("Vertical2");
        }
        // move the paddle based on the input
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, inputY) * speed;

        // keep the paddle within the boundary
        float posY = Mathf.Clamp(transform.position.y, -boundaryY, boundaryY);
        transform.position = new Vector2(transform.position.x, posY);
        
    }
}
