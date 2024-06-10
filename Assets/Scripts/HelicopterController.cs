using UnityEngine;

public class HelicopterController : MonoBehaviour {
    private Rigidbody2D helicopter;
    [SerializeField] private float heliPower;

    private void Awake() {
        helicopter = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)) {
            helicopter.velocity = new Vector2(helicopter.velocity.x, heliPower);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        GameManager.instance.GameOver();
        FindObjectOfType<AudioManager>().Play("Crash");
    }
}
