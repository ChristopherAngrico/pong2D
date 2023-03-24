using UnityEngine;
using TMPro;

public class AddScore : MonoBehaviour
{
    public TextMeshProUGUI text; // Assigned text score
    public static int score1, score2;
    public int maxScore; //Scoring player
    public static bool winner1, winner2;
    private void Update()
    {
        AddingScore();
    }
    void AddingScore()
    {
        if (GameManager.gameManager.player1Goal && gameObject.CompareTag("Goal1"))
        {
            score1 = GameManager.gameManager.ScoringPlayer(score1);
            if (score1 == maxScore)
            {
                text.text = score1.ToString();
                winner1 = true;
                Reset();
            }
            else
            {
                text.text = score1.ToString();
            }
            GameManager.gameManager.player1Goal = false;
        }
        else if (GameManager.gameManager.player2Goal && gameObject.CompareTag("Goal2"))
        {
            score2 = GameManager.gameManager.ScoringPlayer(score2);
            if (score2 == maxScore)
            {
                text.text = score2.ToString();
                winner2 = true;
                Reset();
            }
            else
            {
                text.text = score2.ToString();
            }
            GameManager.gameManager.player2Goal = false;
        }
    }
    private void Reset()
    {
        GameManager.gameManager.ResetAll();
        GameManager.gameManager.FadeIn();
    }
}
