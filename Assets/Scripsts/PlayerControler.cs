using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Este método lo llama automáticamente el Player Input
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveInput.x, 0, moveInput.y);
        rb.AddForce(movement * speed);
    }

    void Update()
    {
        // Si el jugador se cae del plano, volver al nivel 1
        if (transform.position.y < -5f)
        {
            SceneManager.LoadScene("Level1");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            FindObjectOfType<GameManager>().AddPoint();
        }
    }
}

