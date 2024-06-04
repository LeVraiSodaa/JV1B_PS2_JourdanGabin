using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Vitesse de d�placement du joueur
    public float jumpForce = 10f; // Force du saut du joueur
    private Animator animator;

    Rigidbody2D rb; // R�f�rence au Rigidbody2D du joueur
    SpriteRenderer spriteRenderer; // R�f�rence au SpriteRenderer du joueur
    bool isGrounded; // Indique si le joueur est au sol

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // R�cup�re le Rigidbody2D attach� au joueur
        spriteRenderer = GetComponent<SpriteRenderer>(); // R�cup�re le SpriteRenderer attach� au joueur
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal"); // R�cup�re l'entr�e horizontale (gauche/droite)

        // D�placement horizontal
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        // Si tu veux que le personnage regarde dans la direction o� il se d�place
        if (moveInput > 0)
        {
            spriteRenderer.flipX = true; // Tourne le joueur vers la droite
            animator.Play("marche");
        }
        else if (moveInput < 0)
        {
            spriteRenderer.flipX = false; // Tourne le joueur vers la gauche
            animator.Play("marche");
        }

        // Saut
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // V�rifie si le joueur est au sol
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}