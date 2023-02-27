using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    private GameManager gameManager;

    public int layer = 3;

    private void Awake()
    {
        gameManager = GameManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameManager.IsGameEnded) return;
        if (collision.gameObject.layer != layer) return;

        gameManager.IncreaseScore();
    }
}
