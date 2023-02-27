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

    public bool IsGameEnded { get; private set; } = false;

    public int Score { get; private set; }
    public Text scoreText;
    public AudioSource scoreSFX;

    public GameObject gameOver;

    public void IncreaseScore(int toAdd = 1)
    {
        Score += toAdd;
        scoreText.text = Score.ToString();
        scoreSFX.Play();
    }

    public void EndGame()
    {
        IsGameEnded = true;
        gameOver.SetActive(true);
    }
}
