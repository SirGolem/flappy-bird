using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of GameManager in scene.");
            return;
        }

        instance = this;
    }
    #endregion

    public bool HasGameStarted { get; private set; } = false;
    public bool HasGameEnded { get; private set; } = false;

    public int Score { get; private set; }
    public int HighScore { get; private set; }
    public Text scoreText;
    public Text highScoreText;
    public AudioSource scoreSFX;
    public AudioSource highScoreSFX;

    public Text instructionsText;
    public GameObject gameOver;

    private void Start()
    {
        HighScore = PlayerPrefs.GetInt("highScore");
        highScoreText.text = "High Score: " + HighScore;
    }

    public void IncreaseScore(int toAdd = 1)
    {
        Score += toAdd;
        scoreText.text = Score.ToString();

        if (HighScore > 0 && Score == HighScore + 1)
        {
            highScoreSFX.Play();
        } else
        {
            scoreSFX.Play();
        }
    }

    public void StartGame()
    {
        HasGameStarted = true;
        instructionsText.enabled = false;
    }

    public void EndGame()
    {
        HasGameEnded = true;
        gameOver.SetActive(true);

        if (Score > HighScore)
        {
            HighScore = Score;
            PlayerPrefs.SetInt("highScore", Score);
            highScoreText.text = "High Score: " + HighScore;
        }
    }
}
