using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public float MovementSpeed = 1f;
    public float JumpForce = 1f;
    public Animator animator;

    private Rigidbody2D body;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
    var movement = Input.GetAxisRaw("Horizontal");
    float moveSpeed = movement * MovementSpeed;
    animator.SetFloat("Speed", Mathf.Abs(moveSpeed));
    transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;
        
    if (Input.GetKeyDown(KeyCode.UpArrow) && Mathf.Abs(body.velocity.y) < 0.001f)
        {
        body.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
    
}
