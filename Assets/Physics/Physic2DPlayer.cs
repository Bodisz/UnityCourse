using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]

public class Physic2DPlayer : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] float jumpVelocity = 10;
    [SerializeField] float mouvementAcceleration = 3;
    [SerializeField, Min(0)] float maxHorizontalSpeed = 2;
    [SerializeField] int airJumpCount = 1;

    int jumpBudget = 0;

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

        if (jumpBudget >0 && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 0);
            rigidbody.AddForce(Vector2.up * jumpVelocity * rigidbody.mass, ForceMode2D.Impulse);
            jumpBudget--;
        }

        float x = Input.GetAxis("Horizontal");
        x *= mouvementAcceleration;
        x *= rigidbody.mass;
        rigidbody.AddForce(new Vector2(x, 0));

        float xVel = rigidbody.velocity.x;
        xVel = Mathf.Clamp(xVel, -maxHorizontalSpeed, maxHorizontalSpeed);
        rigidbody.velocity = new Vector2(xVel, rigidbody.velocity.y);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
    }
}