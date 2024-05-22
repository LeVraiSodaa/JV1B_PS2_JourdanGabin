using UnityEngine;
using UnityEngine.UI;

public class PowerBarController : MonoBehaviour
{
    private int enemiesKilled = 0; // Nombre d'ennemis tu�s
    public int enemiesRequiredForFullPower = 10; // Nombre d'ennemis requis pour charger compl�tement la barre
    public Slider powerBarSlider; // R�f�rence � la barre de chargement (Slider UI)
    public Text powerBarText; // R�f�rence au texte UI pour afficher le pourcentage

    void Start()
    {
        // Initialiser la barre de chargement
        UpdatePowerBar();
    }

    // Fonction pour augmenter le compteur d'ennemis tu�s
    public void EnemyKilled()
    {
        if (enemiesKilled < enemiesRequiredForFullPower)
        {
            enemiesKilled++;
            Debug.Log("Enemy killed. Current count: " + enemiesKilled);
            UpdatePowerBar();
        }
    }

    // Fonction pour mettre � jour la barre de chargement
    private void UpdatePowerBar()
    {
        // Calculer le pourcentage de la barre de chargement
        float powerPercentage = (float)enemiesKilled / enemiesRequiredForFullPower;
        powerBarSlider.value = powerPercentage;

        // Mettre � jour le texte de la barre de chargement
        if (powerBarText != null)
        {
            powerBarText.text = "Power: " + Mathf.RoundToInt(powerPercentage * 100) + "%";
        }
    }

    // Fonction pour r�initialiser le compteur d'ennemis tu�s et la barre de chargement
    public void ResetPowerBar()
    {
        enemiesKilled = 0;
        UpdatePowerBar();
    }
}
