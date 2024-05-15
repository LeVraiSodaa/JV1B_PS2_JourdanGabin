using UnityEngine;

public class AttackRange : MonoBehaviour
{
    public float attackRadius = 2f; // Rayon d'attaque du cercle
    private bool isCircleVisible = false; // �tat d'affichage du cercle

    void Update()
    {
        // Affiche ou masque le cercle d'attaque lorsque la touche sp�cifi�e est enfonc�e
        if (Input.GetKeyDown(KeyCode.C))
        {
            isCircleVisible = !isCircleVisible; // Inverse l'�tat d'affichage du cercle
            UpdateCircleVisibility(); // Met � jour l'affichage du cercle
        }

        // Si le cercle est affich�, d�tecte les ennemis � l'int�rieur du cercle et d�truit-les
        if (isCircleVisible)
        {
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, attackRadius);
            foreach (Collider2D enemyCollider in hitEnemies)
            {
                if (enemyCollider.CompareTag("Enemy"))
                {
                    // Calcule la distance entre le centre du cercle et la position de l'ennemi
                    float distanceToEnemy = Vector2.Distance(transform.position, enemyCollider.transform.position);
                    // V�rifie si l'ennemi est � l'int�rieur du cercle
                    if (distanceToEnemy <= attackRadius)
                    {
                        // R�cup�re le composant Enemy attach� � l'ennemi
                        Enemy enemy = enemyCollider.GetComponent<Enemy>();
                        if (enemy != null)
                        {
                            // Appelle la fonction Die de l'ennemi pour le d�truire
                            enemy.Die();
                        }
                    }
                }
            }
        }
    }

    // Fonction pour mettre � jour l'affichage du cercle
    private void UpdateCircleVisibility()
    {
        // Active ou d�sactive le rendu du cercle en fonction de l'�tat d'affichage
        GetComponent<SpriteRenderer>().enabled = isCircleVisible;

        // Ajuste l'opacit� du cercle en fonction de l'�tat d'affichage
        Color circleColor = GetComponent<SpriteRenderer>().color;
        circleColor.a = isCircleVisible ? 1f : 0f;
        GetComponent<SpriteRenderer>().color = circleColor;
    }
}
