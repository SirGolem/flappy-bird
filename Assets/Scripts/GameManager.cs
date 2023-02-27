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

    public int score { get; private set; }
    public Text scoreText;

    public void IncreaseScore(int toAdd = 1)
    {
        score += toAdd;
        scoreText.text = score.ToString();
    }
}
