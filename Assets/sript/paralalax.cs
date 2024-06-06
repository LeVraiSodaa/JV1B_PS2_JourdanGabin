using UnityEngine;

public class Parallaxnoninver : MonoBehaviour
{
    public Transform[] backgrounds;     // Tableau contenant tous les arri�re-plans � parcourir
    public float[] parallaxScales;      // Proportion du mouvement de la cam�ra � appliquer aux arri�re-plans
    public float smoothing = 1f;        // Lissage du mouvement parallaxe

    private Transform cam;              // R�f�rence � la transform de la cam�ra
    private Vector3 previousCamPosition;    // Position de la cam�ra dans le frame pr�c�dent

    void Awake()
    {
        cam = Camera.main.transform;
    }

    void Start()
    {
        previousCamPosition = cam.position;

        if (backgrounds.Length != parallaxScales.Length)
        {
            Debug.LogError("Le nombre d'arri�re-plans et de parallaxScales doit �tre le m�me.");
        }
    }

    void Update()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            // Calculer le mouvement parallaxe en fonction du changement de position de la cam�ra
            float parallax = (previousCamPosition.x - cam.position.x) * parallaxScales[i];

            // Calculer la position cible pour l'arri�re-plan actuel
            float backgroundTargetPosX = backgrounds[i].position.x + parallax;

            // Cr�er une position cible � laquelle se d�placer avec le lissage
            Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

            // D�placer l'arri�re-plan vers la nouvelle position cible
            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
        }

        // Mettre � jour la position pr�c�dente de la cam�ra
        previousCamPosition = cam.position;
    }
}