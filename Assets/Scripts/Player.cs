using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    public float flapStrength = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Flap"))
        {
            rb.velocity = Vector2.up * flapStrength;
        }
    }
}
