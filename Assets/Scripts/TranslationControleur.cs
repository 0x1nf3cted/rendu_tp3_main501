using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//on d�finit ici les �tats de mouvement utilis� dans Translation Commande
//Fixe ne fait rien, Positif fait "avancer", Negatif fait "reculer"
public enum EtatTranslation { Fixe = 0, Positif = 1, Negatif = -1 };
public enum ArticulationAxis { XDrive, YDrive, ZDrive };

public class TranslationControleur : MonoBehaviour
{
    public EtatTranslation moveState = EtatTranslation.Fixe;
    public float speed = 1.0f;
    public ArticulationAxis selectedAxis = ArticulationAxis.XDrive;

    private void FixedUpdate()
    {
        if (moveState != EtatTranslation.Fixe)
        {
            ArticulationBody articulation = GetComponent<ArticulationBody>();

            float xDrivePostion = articulation.jointPosition[0];

            float targetPosition = xDrivePostion + -(float)moveState * Time.fixedDeltaTime * speed;

            var drive = new ArticulationDrive();
            switch (selectedAxis)
            {
                case ArticulationAxis.XDrive:
                    drive = articulation.xDrive;
                    break;
                case ArticulationAxis.YDrive:
                    drive = articulation.yDrive;
                    break;
                case ArticulationAxis.ZDrive:
                    drive = articulation.zDrive;
                    break;
            }
            drive.target = targetPosition;

            switch (selectedAxis)
            {
                case ArticulationAxis.XDrive:
                    articulation.xDrive = drive;
                    break;
                case ArticulationAxis.YDrive:
                    articulation.yDrive = drive;
                    break;
                case ArticulationAxis.ZDrive:
                    articulation.zDrive = drive;
                    break;
            }
        }
    }
}
