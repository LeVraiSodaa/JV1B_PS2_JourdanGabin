using UnityEngine;

public class AttackRange : MonoBehaviour
{
    public float attackRadius = 2f; // Rayon d'attaque du cercle
    private bool isCircleVisible = false; // État d'affichage du cercle

    void Update()
    {
        // Affiche ou masque le cercle d'attaque lorsque la touche spécifiée est enfoncée
        if (Input.GetKeyDown(KeyCode.C))
        {
            isCircleVisible = !isCircleVisible; // Inverse l'état d'affichage du cercle
            UpdateCircleVisibility(); // Met à jour l'affichage du cercle
        }

        // Si le cercle est affiché, détecte les ennemis à l'intérieur du cercle et détruit-les
        if (isCircleVisible)
        {
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, attackRadius);
            foreach (Collider2D enemyCollider in hitEnemies)
            {
                if (enemyCollider.CompareTag("Enemy"))
                {
                    // Calcule la distance entre le centre du cercle et la position de l'ennemi
                    float distanceToEnemy = Vector2.Distance(transform.position, enemyCollider.transform.position);
                    // Vérifie si l'ennemi est à l'intérieur du cercle
                    if (distanceToEnemy <= attackRadius)
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
        // Active ou désactive le rendu du cercle en fonction de l'état d'affichage
        GetComponent<SpriteRenderer>().enabled = isCircleVisible;

        // Ajuste l'opacité du cercle en fonction de l'état d'affichage
        Color circleColor = GetComponent<SpriteRenderer>().color;
        circleColor.a = isCircleVisible ? 1f : 0f;
        GetComponent<SpriteRenderer>().color = circleColor;
    }
}
