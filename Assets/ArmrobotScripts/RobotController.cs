using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RobotController : MonoBehaviour
{
    [System.Serializable]
    public struct Joint
    {
        public string inputAxis;
        public GameObject robotPart;
    }
    public Joint[] joints;


    // CONTROL

    public void StopAllJointRotations()
    {
        for (int i = 0; i < joints.Length; i++)
        {
            //Debug.Log(joints.Length.ToString());
            GameObject robotPart = joints[i].robotPart;
            if(robotPart==null) Debug.Log("Robot part is null!");
            UpdateRotationState(RotationDirection.None, robotPart);
        }
    }

    public void RotateJoint(int jointIndex, RotationDirection direction)
    {        
        //StopAllJointRotations();
        Joint joint = joints[jointIndex];
        //Debug.Log(jointIndex.ToString()+" should move"+ direction);
        UpdateRotationState(direction, joint.robotPart);
    }

    // HELPERS

    static void UpdateRotationState(RotationDirection direction, GameObject robotPart)
    {
        
        ArticulationJointController jointController = robotPart.GetComponent<ArticulationJointController>();
        jointController.rotationState = direction;
        if (jointController.rotationState != 0)
        Debug.Log(robotPart.name + " Rotation state is: " + jointController.rotationState);
    }



}
