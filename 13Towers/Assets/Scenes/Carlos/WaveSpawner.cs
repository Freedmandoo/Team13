using UnityEngine;

public class WaveSpawner : MonoBehaviour {

    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;
    public static int life = 2;

    private int waveNumber = 1;

    void Update()
    {
        if (countdown <= 0f)
        {
            Spawnwave();
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    }

    void Spawnwave ()
    {

        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
        }

       // waveNumber++;
    }

    void SpawnEnemy ()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        life += 1;
    }

}
