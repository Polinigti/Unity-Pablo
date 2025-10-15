using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().RestartGame();
        }
    }
}

