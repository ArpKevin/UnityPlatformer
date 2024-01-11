using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 7;
    private Animator animator;
    private Rigidbody2D rigidbody2d;
    private bool isFacingRight;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        isFacingRight = true;
    }
    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(move));
        rigidbody2d.velocity = new(move * maxSpeed, rigidbody2d.velocity.y);
        if ((move < 0 && isFacingRight) || (move > 0 && !isFacingRight)) Flip();
    }
    private void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new(transform.localScale.x * -1, transform.localScale.y);
    }
}