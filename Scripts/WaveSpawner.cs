using UnityEngine;
using System.Collections;
public class WaveSpawner : MonoBehaviour

{
    public GameObject enemyPrefab;
    public Transform spawnPoint;

    public int waveNumber = 1;
    public int enemiesPerWave = 5;

    public float spawnDelay = 1f;
    public float timeBetweenWaves = 5f;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }
    IEnumerator SpawnWaves()
    {
        while (true)
        {
            Debug.Log("Starting Wave " + waveNumber);

            for(int i = 0; i < enemiesPerWave; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(spawnDelay);
            }
            waveNumber++;
            GameManager.Instance.wave = waveNumber;
            enemiesPerWave += 2;

            yield return new WaitForSeconds(timeBetweenWaves);
        }
    }
    void SpawnEnemy()
    {
        Instantiate(
            enemyPrefab,
            spawnPoint.position,
            Quaternion.identity
        );
    }

}
