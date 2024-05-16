using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private bool specialAbilityEnabled = false; // Indique si la capacité spéciale est activée

    // Fonction pour activer la capacité spéciale (par exemple, le changement de scène)
    public void EnableSpecialAbility()
    {
        // Activer la capacité spéciale (par exemple, le changement de scène)
        Debug.Log("Special Ability enabled!");
        specialAbilityEnabled = true;
    }

    void Update()
    {
        // Vérifier si la touche "W" est enfoncée et si la capacité spéciale est activée
        if (specialAbilityEnabled && Input.GetKeyDown(KeyCode.V))
        {
            // Charger la nouvelle scène
            SceneManager.LoadScene(1);
        }
    }
}
