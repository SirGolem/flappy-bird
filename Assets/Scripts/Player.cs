using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private GameManager gameManager;
    private Rigidbody2D rb;

    public bool autoFlap = true;
    public bool inputStopsAutoFlap = true;
    public float flapStrength = 10f;
    public float rotationStrength = 7f;
    public float rotationSmoothing = 0.01f;

    private void Start()
    {
        gameManager = GameManager.instance;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, 0f, rb.velocity.y * rotationStrength), rotationSmoothing);

        if (autoFlap && transform.position.y <= 0f)
        {
            Flap();
        }

        if (gameManager != null && gameManager.HasGameEnded) return;

        if (Input.GetButtonDown("Flap") && inputStopsAutoFlap)
        {
            autoFlap = false;
            Flap();

            if (gameManager != null && !gameManager.HasGameStarted) gameManager.StartGame();
        }
    }

    private void Flap()
    {
        rb.velocity = Vector2.up * flapStrength;
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
