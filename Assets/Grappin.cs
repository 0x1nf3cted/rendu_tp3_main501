using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappin : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(this.gameObject.GetComponent<FixedJoint>());
        }
    }
    void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.GetComponent<ArticulationBody>() != null){
        FixedJoint joint = this.gameObject.AddComponent<FixedJoint>();joint.connectedArticulationBody = Collision.articulationBody;}
    }
}
