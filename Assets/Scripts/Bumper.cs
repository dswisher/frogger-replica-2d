using UnityEngine;

public class Bumper : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Car"))
        {
            Destroy(other.gameObject);
        }
    }
}
