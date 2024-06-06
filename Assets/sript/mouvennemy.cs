using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 3f; // Vitesse de déplacement de l'ennemi
    public float moveDuration = 2f; // Durée de déplacement dans une direction
    public float idleDuration = 1f; // Durée d'inactivité entre les déplacements
    private float moveTimer; // Timer pour suivre la durée de déplacement
    private float idleTimer; // Timer pour suivre la durée d'inactivité
    private bool moveRight = false; // Indique si l'ennemi se déplace vers la droite
    private SpriteRenderer spriteRenderer; // Référence au SpriteRenderer de l'ennemi

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Récupère le SpriteRenderer attaché à l'ennemi
    }

    void Update()
    {
        // Déplacer l'ennemi
        if (moveRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }

        // Met à jour le timer de déplacement
        moveTimer += Time.deltaTime;

        // Si le temps de déplacement est écoulé
        if (moveTimer >= moveDuration)
        {
            // Change de direction
            moveRight = !moveRight;
            // Réinitialise le timer de déplacement
            moveTimer = 0f;
            // Retourner l'ennemi
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        // Si l'ennemi est inactif
        if (moveTimer < idleDuration)
        {
            // Met à jour le timer d'inactivité
            idleTimer += Time.deltaTime;
        }

        // Si le temps d'inactivité est écoulé
        if (idleTimer >= idleDuration)
        {
            // Réinitialise le timer d'inactivité
            idleTimer = 0f;
        }
    }
}
