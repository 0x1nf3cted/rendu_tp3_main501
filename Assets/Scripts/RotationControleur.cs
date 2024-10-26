using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EtatRotation { Fixe = 0, Positif = 1, Negatif = -1 };

public class RotationControleur : MonoBehaviour
{
    public EtatRotation rotationState = EtatRotation.Fixe;
    public float speed = 30.0f;

    private ArticulationBody articulation;

    void Start()
    {
        articulation = GetComponent<ArticulationBody>();
    }

    void FixedUpdate()
    {
        if (rotationState != EtatRotation.Fixe)
        {
            float rotationChange = (float)rotationState * speed * Time.fixedDeltaTime;
            float rotationGoal = CurrentPrimaryAxisRotation() + rotationChange;
            RotateTo(rotationGoal);
        }
    }

    float CurrentPrimaryAxisRotation()
    {
        float currentRotationRads = articulation.jointPosition[0];
        float currentRotation = Mathf.Rad2Deg * currentRotationRads;
        return currentRotation;
    }

    void RotateTo(float primaryAxisRotation)
    {
        var drive = articulation.xDrive;
        drive.target = primaryAxisRotation;
        articulation.xDrive = drive;
    }
}
