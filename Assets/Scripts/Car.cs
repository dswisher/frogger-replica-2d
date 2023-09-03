using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;

    public float minSpeed = 3;
    public float maxSpeed = 6;

    float speed = 1f;

    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }


    void FixedUpdate()
    {
        var right = transform.right;
        var forward = new Vector2(right.x, right.y);

        rb.MovePosition(rb.position + forward * (Time.fixedDeltaTime * speed));
    }
}
