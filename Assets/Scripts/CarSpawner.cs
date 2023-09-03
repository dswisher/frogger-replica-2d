using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawnDelay = 0.3f;
    public GameObject carPrefab;

    public Transform[] spawnPoints;

    private float nextTimeToSpawn;

    void Update()
    {
        if (Time.time > nextTimeToSpawn)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }


    void SpawnCar()
    {
        var idx = Random.Range(0, spawnPoints.Length);
        var spawnPoint = spawnPoints[idx];

        Instantiate(carPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
