using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]

public class Physic2DPlayer : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] float jumpVelocity = 10;
    [SerializeField] float mouvementAcceleration = 5;
    [SerializeField, Min(0)] float maxHorizontalSpeed = 2;
    [SerializeField] int airJumpCount = 1;
    [SerializeField] float groundAccelerationMultiplier = 2;

    int jumpBudget = 0;
    bool onGround;
    PlatformerServiceModifier modifier;

    void Start()
    {
        jumpBudget = airJumpCount;
    }

    private void OnValidate()
    {
        if (rigidbody == null)
            {
            rigidbody = GetComponent<Rigidbody2D>();
            }
    }

    void Update()
    {
        bool canJump = (onGround || jumpBudget > 0) && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow));

        if (canJump)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 0);
            rigidbody.AddForce(Vector2.up * jumpVelocity * rigidbody.mass, ForceMode2D.Impulse);
            jumpBudget--;
        }

        float vel = jumpVelocity;

        if (modifier != null) { vel *= modifier.jumpVelocityMultiplier; }
        float x = Input.GetAxis("Horizontal");
        x *= mouvementAcceleration;
        if(onGround) { x *= groundAccelerationMultiplier; }
  
        x *= rigidbody.mass;
        rigidbody.AddForce(new Vector2(x, 0));

        float xVel = rigidbody.velocity.x;
        xVel = Mathf.Clamp(xVel, -maxHorizontalSpeed, maxHorizontalSpeed);
        rigidbody.velocity = new Vector2(xVel, rigidbody.velocity.y);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        modifier = collision.gameObject.GetComponent<PlatformerServiceModifier>();
        jumpBudget = airJumpCount + 1;
        onGround = true;

        if (modifier != null) { rigidbody.velocity = new Vector2(rigidbody.velocity.x, modifier.bounciness); }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;
    }
}