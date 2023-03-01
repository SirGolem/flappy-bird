using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    private GameManager gameManager;

    public float speed = 5f;
    public Vector3 deletePoint;

    private void Start()
    {
        gameManager = GameManager.instance;
    }

    private void Update()
    {
        if (!gameManager.HasGameStarted || gameManager.HasGameEnded) return;

        transform.position += speed * Time.deltaTime * Vector3.left;

        if (transform.position.x < deletePoint.x)
        {
            Destroy(gameObject);
        }
    }
}
