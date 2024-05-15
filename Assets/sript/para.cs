using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform[] backgrounds; // Tableau des plans de fond à déplacer
    public float[] parallaxScales; // Échelle de parallaxe pour chaque plan
    public float smoothing = 1f; // Douceur du déplacement parallaxe

    private Transform cam; // Référence à la transform de la caméra
    private Vector3 previousCamPos; // Position précédente de la caméra

    void Awake()
    {
        // Récupère la référence de la caméra
        cam = Camera.main.transform;
    }

    void Start()
    {
        // Initialise la position précédente de la caméra
        previousCamPos = cam.position;

        // Initialise les échelles de parallaxe en fonction de la profondeur des plans de fond
        parallaxScales = new float[backgrounds.Length];
        for (int i = 0; i < backgrounds.Length; i++)
        {
            parallaxScales[i] = backgrounds[i].position.z * -1;
        }
    }

    void Update()
    {
        // Pour chaque plan de fond
        for (int i = 0; i < backgrounds.Length; i++)
        {
            // Calcule le parallaxe (déplacement)
            float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];

            // Calcule la nouvelle position cible du plan de fond
            float backgroundTargetPosX = backgrounds[i].position.x + parallax;

            // Calcule la nouvelle position interpolée du plan de fond
            Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

            // Applique l'effet de parallaxe avec une interpolation
            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
        }

        // Met à jour la position précédente de la caméra
        previousCamPos = cam.position;
    }
}
