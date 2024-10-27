using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed, jumpSpeed;
    public Transform groundCheck;
    public LayerMask groundLayer;

    Rigidbody2D rb;
    float horizontal;
    bool grounded, isFacingRight = true;

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
        grounded = Physics2D.OverlapCircle(groundCheck.position, .2f, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode2D.Impulse);
        }
        if (horizontal != 0)
        {
            transform.position += movementSpeed * Time.deltaTime * new Vector3(horizontal, 0f, 0f);
        }
        Flip();
    }
    void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
