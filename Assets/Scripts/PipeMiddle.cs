using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public int layer = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer != layer) return;

        GameManager.instance.IncreaseScore();
    }
}
