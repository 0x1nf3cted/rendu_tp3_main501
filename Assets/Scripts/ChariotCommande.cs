using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Les commandes pour la fleche:
Négative: s
Positive: z
*/




public class ChariotCommande : MonoBehaviour
{
    public GameObject Chariot; 
    public string axe; 

    void Update()
    {
        float input = Input.GetAxis(axe);
        EtatChariot moveState = EtatTranslationPrInput(input);  
        ChariotControleur controller = Chariot.GetComponent<ChariotControleur>();  
        controller.translationEtat = moveState; 
    }

    // Détermine l'état du chariot basé sur l'entrée utilisateur
    EtatChariot EtatTranslationPrInput(float input)
    {
        if (input > 0) // Vérifie si l'entrée est positive
        {
            return EtatChariot.Positif;  
        }
        else if (input < 0) // Vérifie si l'entrée est négative
        {
            return EtatChariot.Negatif;  
        }
        else
        {
            return EtatChariot.Fixe;  
        }
    }
}
