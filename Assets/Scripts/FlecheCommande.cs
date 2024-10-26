using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Les commandes pour la fleche:
Négative: x
Positive: w
*/

public class FlecheCommande : MonoBehaviour
{
    public GameObject Fleche; 

    void Update()
    {
        float input = Input.GetAxis("Fleche");
        EtatFleche rotationEtat = MoveStateForInput(input); 
        FlecheControleur controller = Fleche.GetComponent<FlecheControleur>(); 
        controller.rotationEtat = rotationEtat; 
    }

    // Détermine l'état de rotation de la flèche basé sur l'entrée utilisateur
    EtatFleche MoveStateForInput(float input)
    {
        if (input > 0) // Vérifie si l'entrée est positive
        {
            return EtatFleche.Positif;  
        }
        else if (input < 0) // Vérifie si l'entrée est négative
        {
            return EtatFleche.Negatif; 
        }
        else
        {
            return EtatFleche.Fixe;  
        }
    }
}
