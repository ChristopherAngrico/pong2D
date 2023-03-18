using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public bool player1Goal = false, player2Goal = false;
    public bool enableScript;
    // private int playerScore1 = 0, playerScore2 = 0;
    private Rigidbody2D ballRb;
    [SerializeField] private float timeLaunch;

    [SerializeField] Transform player1, player2;
    [SerializeField] GameObject ball;
    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        // ball.GetComponent<BallMovement>().enabled = false;

    }

    // Player will getting plus one after other player getting goal
    public int ScoringPlayer(int score)
    {
        //Adding Score
        score += 1;
        return score;
    }
    public int ScoringPayer2(int score)
    {
        score += 1;
        print(score);
        return score;
    }
    public void ResetPlayer()
    {
        //Set player1 and player2 transform.position to zero
        player1.position = new Vector2(player1.GetComponent<Rigidbody2D>().position.x, 0);
        player2.position = new Vector2(player2.GetComponent<Rigidbody2D>().position.x, 0);
    }

    public void ResetBall()
    {
     
        ball.transform.position = Vector3.zero;

        //Set ball rigidbody velocity to zero
        ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        StartCoroutine(nameof(WaitToLaunch));
    }

    private IEnumerator WaitToLaunch(){
        yield return new WaitForSeconds(timeLaunch);
        ball.GetComponent<BallMovement>().Launch();
    }
}
