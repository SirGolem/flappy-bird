using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private GameManager gameManager;
    private Rigidbody2D rb;

    public float flapStrength = 10f;

    private void Awake()
    {
        gameManager = GameManager.instance;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Flap") && !gameManager.IsGameEnded)
        {
            rb.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.EndGame();
    }

    private void OnBecameInvisible()
    {
        if (gameManager == null) return;

        gameManager.EndGame();
    }
}
