using UnityEngine;

public class Attack : MonoBehaviour
{
    public float attackRadius = 2f; // Rayon d'attaque du cercle

    void Update()
    {
        // Fait quelque chose avec les ennemis à l'intérieur du cercle (par exemple, les détruire)
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, attackRadius);
        foreach (Collider2D enemy in hitEnemies)
        {
            if (enemy.CompareTag("Enemy"))
            {
                // Ici, tu peux appeler une fonction dans le script de l'ennemi pour le détruire ou lui infliger des dégâts
                enemy.GetComponent<Enemy>().Die();
            }
        }
    }
}
