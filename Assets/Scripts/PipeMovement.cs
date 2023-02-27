using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 deletePoint;

    private void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;

        if (transform.position.x < deletePoint.x)
        {
            Destroy(gameObject);
        }
    }
}
