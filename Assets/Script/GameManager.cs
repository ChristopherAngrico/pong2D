using UnityEngine;
using System.Collections;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public bool player1Goal = false, player2Goal = false;
    private Rigidbody2D ballRb;
    [SerializeField] private float timeLaunch;

    [SerializeField] Transform player1, player2;
    [SerializeField] GameObject ball;
    [SerializeField] GameObject showWinner, Instruction;
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
    }

    // Player will getting plus one after other player getting goal
    public int ScoringPlayer(int score)
    {
        //Adding Score
        score += 1;
        return score;
    }

    /*
        Reset the game
    */
    public void Reset()
    {
        //Set player1 and player2 transform.position to zero
        player1.position = new Vector2(player1.GetComponent<Rigidbody2D>().position.x, 0);
        player2.position = new Vector2(player2.GetComponent<Rigidbody2D>().position.x, 0);

        ball.transform.position = Vector3.zero; //Reset ball position
        ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero; //Set velocity to zero
        // StartCoroutine(nameof(WaitToLaunch));
        ball.GetComponent<BallMovement>().EnableScript();
    }

    public void ResetAll(){
         //Set player1 and player2 transform.position to zero
        player1.position = new Vector2(player1.GetComponent<Rigidbody2D>().position.x, 0);
        player2.position = new Vector2(player2.GetComponent<Rigidbody2D>().position.x, 0);

        ball.transform.position = Vector3.zero; //Reset ball position
        ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero; //Set velocity to zero
        ball.GetComponent<BallMovement>().DisableScript();
    }
    public void FadeIn()
    {
        if (AddScore.winner1)
        {
            showWinner.SetActive(true);
            showWinner.GetComponentInChildren<TextMeshProUGUI>().text = "The winner is player 1";
        }
        if (AddScore.winner2)
        {
            showWinner.SetActive(true);
            showWinner.GetComponentInChildren<TextMeshProUGUI>().text = "The winner is player 2";
        }
    }

    public void PressAnyWhere(){
        ball.GetComponent<BallMovement>().EnableScript();
        Instruction.SetActive(false);
    }

    // public void DiableShowWinner(){
    //     showWinner.SetActive(false);
    //     ball.GetComponent<BallMovement>().EnableScript();
        
    // }
}
