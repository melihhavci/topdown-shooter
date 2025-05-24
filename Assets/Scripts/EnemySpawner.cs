using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;

    // Plane bilgileri
    public Transform groundPlane;

    private float spawnHeight = 2f; // Enemy pivotuna g�re biraz yukar�dan do�sun

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        Vector3 center = groundPlane.position;
        float halfSize = 5f * groundPlane.localScale.x;

        float randomX = Random.Range(center.x - halfSize, center.x + halfSize);
        float randomZ = Random.Range(center.z - halfSize, center.z + halfSize);

        // Spawn'� instantiate etmeden �nce ge�ici enemy �l��s�n� ��ren
        GameObject enemy = Instantiate(enemyPrefab);
        float enemyHeight = enemy.GetComponent<Collider>().bounds.size.y;

        Vector3 spawnPos = new Vector3(randomX, center.y + enemyHeight / 2f, randomZ);
        enemy.transform.position = spawnPos;
    }

}
