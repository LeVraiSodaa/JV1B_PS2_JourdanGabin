using UnityEngine;
using UnityEngine.UI;

public class ToggleFullscreen : MonoBehaviour
{
    public Button toggleButton; // Le bouton UI pour basculer entre les modes

    void Start()
    {
        // Ajouter un écouteur pour le clic sur le bouton
        toggleButton.onClick.AddListener(ToggleFullScreenMode);
    }

    void ToggleFullScreenMode()
    {
        // Basculer entre les modes plein écran et fenêtré
        Screen.fullScreen = !Screen.fullScreen;
    }
}
