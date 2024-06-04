using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Vitesse de déplacement du joueur
    public float jumpForce = 10f; // Force du saut du joueur
    private Animator animator; // Référence à l'Animator

    Rigidbody2D rb; // Référence au Rigidbody2D du joueur
    SpriteRenderer spriteRenderer; // Référence au SpriteRenderer du joueur
    bool isGrounded; // Indique si le joueur est au sol

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Récupère le Rigidbody2D attaché au joueur
        spriteRenderer = GetComponent<SpriteRenderer>(); // Récupère le SpriteRenderer attaché au joueur
        animator = GetComponent<Animator>(); // Récupère l'Animator attaché au joueur
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal"); // Récupère l'entrée horizontale (gauche/droite)

        // Déplacement horizontal
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        // Si le personnage se déplace
        if (moveInput != 0)
        {
            // Si le personnage se déplace vers la droite
            if (moveInput > 0)
            {
                spriteRenderer.flipX = true; // Tourne le joueur vers la droite
            }
            // Si le personnage se déplace vers la gauche
            else if (moveInput < 0)
            {
                spriteRenderer.flipX = false; // Tourne le joueur vers la gauche
            }

            // Jouer l'animation de marche
            animator.Play("marche");
        }
        else
        {
            // Jouer l'animation d'idle
            animator.Play("idle");
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
        // Vérifie si le joueur est au sol
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
