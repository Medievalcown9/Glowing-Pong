using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int _playerScore;
    private int _computerScore;
    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI computerScoreText;
    public int scoreToReach;

    public void PlayerScores()
    {
        _playerScore++;
        player1ScoreText.text = _playerScore.ToString();
        CheckScore();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    public void ComputerScores()
    {
        _computerScore++;
        computerScoreText.text = _computerScore.ToString();
        CheckScore();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    private void CheckScore()
    {
        if (_playerScore == scoreToReach || _computerScore == scoreToReach)
        {
            SceneManager.LoadScene(2);
        }
    }
}
