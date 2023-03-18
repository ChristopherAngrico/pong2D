using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddScore : MonoBehaviour
{
    public TextMeshProUGUI text1, text2; // Assigned text score
    private int score1, score2; //Scoring player

    private void Update()
    {
       AddingScore();
    }
    void AddingScore()
    {
        if (GameManager.gameManager.player1Goal)
        {
            // print(1);
            score1 = GameManager.gameManager.ScoringPlayer(score1);
            GameManager.gameManager.player1Goal = false;
            text1.text = score1.ToString();
        }
        else if (GameManager.gameManager.player2Goal)
        {
            // print(2);
            score2 = GameManager.gameManager.ScoringPlayer(score2);
            GameManager.gameManager.player2Goal = false;
            text2.text = score2.ToString();
        }
    }
}
