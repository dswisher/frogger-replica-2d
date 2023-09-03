using UnityEngine;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            rb.MovePosition(rb.position + Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }
    }
}
