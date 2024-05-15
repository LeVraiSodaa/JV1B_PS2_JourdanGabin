using UnityEngine;

public class AttackRange : MonoBehaviour
{
    public float attackRadius = 2f; // Rayon d'attaque du cercle
    private bool isCircleVisible = false; // État d'affichage du cercle
    private SpriteRenderer circleRenderer; // Référence au composant SpriteRenderer du cercle

    void Start()
    {
        // Récupère le composant SpriteRenderer du cercle
        circleRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Affiche ou masque le cercle d'attaque lorsque la touche spécifiée est enfoncée
        if (Input.GetKeyDown(KeyCode.C))
        {
            isCircleVisible = !isCircleVisible; // Inverse l'état d'affichage du cercle
            UpdateCircleVisibility(); // Met à jour l'affichage du cercle
        }

        // Détecte les ennemis à l'intérieur du cercle et détruit-les si la touche "X" est enfoncée
        if (Input.GetKeyDown(KeyCode.X))
        {
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, attackRadius);
            foreach (Collider2D enemyCollider in hitEnemies)
            {
                if (enemyCollider.CompareTag("Enemy"))
                {
                    // Vérifie que l'ennemi n'est pas le joueur lui-même
                    if (enemyCollider.gameObject != gameObject)
                    {
                        // Récupère le composant Enemy attaché à l'ennemi
                        Enemy enemy = enemyCollider.GetComponent<Enemy>();
                        if (enemy != null)
                        {
                            // Appelle la fonction Die de l'ennemi pour le détruire
                            enemy.Die();
                        }
                    }
                }
            }
        }
    }

    // Fonction pour mettre à jour l'affichage du cercle
    private void UpdateCircleVisibility()
    {
        // Ajuste l'alpha du sprite renderer en fonction de l'état d'affichage du cercle
        Color circleColor = circleRenderer.color;
        circleColor.a = isCircleVisible ? 0.2f : 0f;
        circleRenderer.color = circleColor;
    }
}
