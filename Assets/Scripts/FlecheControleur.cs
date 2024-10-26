using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EtatFleche { Fixe = 0, Positif = 1, Negatif = -1 };

public class FlecheControleur : MonoBehaviour
{
    public EtatFleche rotationEtat = EtatFleche.Fixe; 
    public float vitesse = 30.0f; 

    private ArticulationBody articulation; 

    void Start()
    {
        articulation = GetComponent<ArticulationBody>();  
    }

    // Méthode FixedUpdate appelée à une fréquence fixe pour gérer la physique
    void FixedUpdate()
    {
        if (rotationEtat != EtatFleche.Fixe)
        {
            float rotationChange = (float)rotationEtat * vitesse * Time.fixedDeltaTime; 
            float rotationGoal = AxeRotation() + rotationChange;  
            RotationVers(rotationGoal);  
        }
    }

    // Calcule la rotation actuelle de l'axe en degrés
    float AxeRotation()
    {
        float RotationRads = articulation.jointPosition[0];  
        float Rotation = Mathf.Rad2Deg * RotationRads; 
        return Rotation; 
    }

    // Applique la rotation vers la position cible spécifiée
    void RotationVers(float primaryAxisRotation)
    {
        var drive = articulation.xDrive;  
        drive.target = primaryAxisRotation; 
        articulation.xDrive = drive; 
    }
}
