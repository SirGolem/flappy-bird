using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    private GameManager gameManager;

    public int layer = 3;

    private void Start()
    {
        gameManager = GameManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!gameManager.HasGameStarted || gameManager.HasGameEnded) return;
        if (collision.gameObject.layer != layer) return;

        gameManager.IncreaseScore();
    }
}
