using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 3f; // Vitesse de d�placement de l'ennemi
    public float moveDuration = 2f; // Dur�e de d�placement dans une direction
    public float idleDuration = 1f; // Dur�e d'inactivit� entre les d�placements
    private float moveTimer; // Timer pour suivre la dur�e de d�placement
    private float idleTimer; // Timer pour suivre la dur�e d'inactivit�
    private bool moveRight = false; // Indique si l'ennemi se d�place vers la droite
    private SpriteRenderer spriteRenderer; // R�f�rence au SpriteRenderer de l'ennemi

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // R�cup�re le SpriteRenderer attach� � l'ennemi
    }

    void Update()
    {
        // D�placer l'ennemi
        if (moveRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }

        // Met � jour le timer de d�placement
        moveTimer += Time.deltaTime;

        // Si le temps de d�placement est �coul�
        if (moveTimer >= moveDuration)
        {
            // Change de direction
            moveRight = !moveRight;
            // R�initialise le timer de d�placement
            moveTimer = 0f;
            // Retourner l'ennemi
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        // Si l'ennemi est inactif
        if (moveTimer < idleDuration)
        {
            // Met � jour le timer d'inactivit�
            idleTimer += Time.deltaTime;
        }

        // Si le temps d'inactivit� est �coul�
        if (idleTimer >= idleDuration)
        {
            // R�initialise le timer d'inactivit�
            idleTimer = 0f;
        }
    }
}
