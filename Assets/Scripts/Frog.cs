using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;

    public AudioSource jump;
    public AudioSource crash;

    public float restartDelay = 2f;

    private bool gameOver;
    private float reloadTime;


    void Update()
    {
        var dx = 0;
        var dy = 0;

        if (!gameOver)
        {
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

        // TODO - only play the source if frog actually moved (was not clamped)
        if (dx != 0 || dy != 0)
        {
            jump.Play();
        }

        if (gameOver && Time.time > reloadTime)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Car"))
        {
            if (!gameOver)
            {
                reloadTime = Time.time + restartDelay;
                crash.Play();

                Score.CurrentScore = 0;
            }

            gameOver = true;
        }
    }
}
