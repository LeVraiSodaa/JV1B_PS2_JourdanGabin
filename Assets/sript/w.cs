using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool specialAbilityEnabled = false; // Indique si la capacit� sp�ciale est activ�e
    private int eliminationCount = 0; // Compteur d'�liminations

    // R�f�rence � l'objet de t�l�portation
    public GameObject teleportObject;

    // Fonction pour activer la capacit� sp�ciale (par exemple, t�l�portation)
    public void EnableSpecialAbility()
    {
        // Activer la capacit� sp�ciale (par exemple, t�l�portation)
        Debug.Log("Special Ability enabled!");
        specialAbilityEnabled = true;
    }

    // Fonction pour augmenter le compteur d'�liminations
    public void IncreaseEliminationCount()
    {
        eliminationCount++;
        Debug.Log("Elimination count increased: " + eliminationCount);
    }

    void Update()
    {
        // V�rifier si la touche "V" est enfonc�e et si la capacit� sp�ciale est activ�e
        if (specialAbilityEnabled && Input.GetKeyDown(KeyCode.V))
        {
            // V�rifier si l'objet de t�l�portation est assign�
            if (teleportObject != null)
            {
                // T�l�porter le joueur � la position de l'objet de t�l�portation
                transform.position = teleportObject.transform.position;

                // Soustraire 3 du compteur d'�liminations apr�s la t�l�portation
                eliminationCount -= 3;
                Debug.Log("Elimination count decremented by 3: " + eliminationCount);

                // Si le compteur devient n�gatif, le remettre � z�ro
                if (eliminationCount < 0)
                {
                    eliminationCount = 0;
                }
            }
            else
            {
                Debug.LogWarning("Teleport object is not assigned!");
            }
        }
    }
}