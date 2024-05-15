using UnityEngine;

public class AttackRange : MonoBehaviour
{
    public float attackRadius = 2f; // Rayon d'attaque du cercle
    private bool isCircleVisible = false; // �tat d'affichage du cercle
    private SpriteRenderer circleRenderer; // R�f�rence au composant SpriteRenderer du cercle

    void Start()
    {
        // R�cup�re le composant SpriteRenderer du cercle
        circleRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Affiche ou masque le cercle d'attaque lorsque la touche sp�cifi�e est enfonc�e
        if (Input.GetKeyDown(KeyCode.C))
        {
            isCircleVisible = !isCircleVisible; // Inverse l'�tat d'affichage du cercle
            UpdateCircleVisibility(); // Met � jour l'affichage du cercle
        }

        // D�tecte les ennemis � l'int�rieur du cercle et d�truit-les si la touche "X" est enfonc�e
        if (Input.GetKeyDown(KeyCode.X))
        {
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, attackRadius);
            foreach (Collider2D enemyCollider in hitEnemies)
            {
                if (enemyCollider.CompareTag("Enemy"))
                {
                    // V�rifie que l'ennemi n'est pas le joueur lui-m�me
                    if (enemyCollider.gameObject != gameObject)
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
        // Ajuste l'alpha du sprite renderer en fonction de l'�tat d'affichage du cercle
        Color circleColor = circleRenderer.color;
        circleColor.a = isCircleVisible ? 0.2f : 0f;
        circleRenderer.color = circleColor;
    }
}
