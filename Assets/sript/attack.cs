using UnityEngine;

public class Attack : MonoBehaviour
{
    public float attackRadius = 2f; // Rayon d'attaque du cercle

    void Update()
    {
        // Fait quelque chose avec les ennemis � l'int�rieur du cercle (par exemple, les d�truire)
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, attackRadius);
        foreach (Collider2D enemy in hitEnemies)
        {
            if (enemy.CompareTag("Enemy"))
            {
                // Ici, tu peux appeler une fonction dans le script de l'ennemi pour le d�truire ou lui infliger des d�g�ts
                enemy.GetComponent<Enemy>().Die();
            }
        }
    }
}
