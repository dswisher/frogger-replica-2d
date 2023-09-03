using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public AudioSource pickupCoin;
    public float restartDelay = 2f;

    private bool restarting;
    private float reloadTime;

    void Update()
    {
        if (restarting && Time.time > reloadTime)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        Score.CurrentScore += 100;

        if (!restarting)
        {
            reloadTime = Time.time + restartDelay;
            pickupCoin.Play();
        }

        restarting = true;
    }
}
