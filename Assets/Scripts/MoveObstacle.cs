using UnityEngine;

public class MoveObstacle : MonoBehaviour {
    [SerializeField] private float speed = 0.001f;

    private void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
