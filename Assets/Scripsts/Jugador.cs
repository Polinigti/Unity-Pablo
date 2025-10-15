using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        moveInput = movementValue.Get<Vector2>();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveInput.x, 0, moveInput.y);
        rb.AddForce(movement * speed);
    }

    void Update()
    {
        
        if (transform.position.y < -5f)
        {
            SceneManager.LoadScene("Nivel1");
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



