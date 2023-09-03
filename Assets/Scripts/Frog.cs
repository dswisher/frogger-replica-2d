using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;

    void Update()
    {
        var dx = 0;
        var dy = 0;

        if (Input.GetKeyDown(KeyCode.D))
        {
            dx = 1;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            dx = -1;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            dy = 1;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            dy = -1;
        }

        rb.position = new Vector2(Mathf.Clamp(rb.position.x + dx, -6, 6), Mathf.Clamp(rb.position.y + dy, -4, 4));
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Car"))
        {
            Debug.Log("WE LOST!");
            Score.CurrentScore = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
