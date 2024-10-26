using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class TranslationControleurCrochet : MonoBehaviour
{
 
    public EtatTranslation moveState = EtatTranslation.Fixe;
    public float speed = 1.0f;

    private void FixedUpdate() 
    {
        if (moveState != EtatTranslation.Fixe)
        {
            ArticulationBody articulation = GetComponent<ArticulationBody>();

            float xDrivePostion = articulation.jointPosition[0];

            float targetPosition = xDrivePostion + -(float)moveState * Time.fixedDeltaTime * speed;

            var drive = articulation.xDrive;
            drive.target = targetPosition;
            articulation.xDrive = drive;
        }
    }
}
