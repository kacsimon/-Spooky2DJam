using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed, jumpSpeed;
    public Transform groundCheck;
    public LayerMask groundLayer;

    Rigidbody2D rb;
    float horizontal, vertical;
    bool grounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Move();
    }
    void Move()
    {
        horizontal = Input.GetAxis("Horizontal");
        //vertical = Input.GetAxis("Vertical");

        grounded = Physics2D.OverlapCircle(groundCheck.position, .2f, groundLayer);
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode2D.Impulse);
        }
        if (horizontal != 0 || vertical != 0)
        {
            transform.position += movementSpeed * Time.deltaTime * new Vector3(horizontal, 0f, vertical);
        }
    }
}
