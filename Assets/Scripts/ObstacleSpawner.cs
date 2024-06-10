using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 0;
    [SerializeField] private GameObject obstacle;

    private float timer;

    private void Start() {
        SpawnObstacle();
    }

    private void Update() {
        if (timer > maxTime) {
            SpawnObstacle();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    private void SpawnObstacle() {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject new_obstacle = Instantiate(obstacle, spawnPos, Quaternion.identity);

        Destroy(new_obstacle, 10f);
    }
}
