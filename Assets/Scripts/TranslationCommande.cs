using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Les commandes pour le Chariot:
Négative: q
Positive: d


Les commandes pour la Flèche:
Négative: z
Positive: s

Les commandes pour la Moufle:
Négative: u
Positive: i

Les commandes pour le Support:
Négative: r
Positive: t

Les commandes pour la Base:
Négative: k
Positive: l
*/


public class TranslationCommande : MonoBehaviour
{
    public GameObject Translation;
    public string axe = "Fleche";
    private TranslationControleur controller;

    void Update()  
    {
        float input = Input.GetAxis(axe);
        EtatTranslation moveState = MoveStateForInput(input);
        TranslationControleur controller = Translation.GetComponent<TranslationControleur>();
        controller.moveState = moveState;
    }

    EtatTranslation MoveStateForInput(float input)
    {
        if (input > 0)
        {
            return EtatTranslation.Positif;
        }
        else if (input < 0)
        {
            return EtatTranslation.Negatif;
        }
        else
        {
            return EtatTranslation.Fixe;
        }
    }
}
