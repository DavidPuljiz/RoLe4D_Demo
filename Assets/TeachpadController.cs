using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Robotics;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class TeachpadController : MonoBehaviour
{

    public GameObject robot;
    [System.Serializable]
    private struct Joint_Buttons
    {
        public bool is_active;
        public bool is_positive;
    }
    private Joint_Buttons[] joints;

    void Start()
    {
        RobotController robotController = robot.GetComponent<RobotController>();
        joints = new Joint_Buttons[robotController.joints.Length];
        for (int i = 0; i < joints.Length; i++)
        {
            joints[i].is_active = false;
            joints[i].is_positive = false;
        }
    }



    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {
        RobotController robotController = robot.GetComponent<RobotController>();
        for (int i = 0; i < robotController.joints.Length; i++)
        {
            //float inputVal = Input.GetAxis(robotController.joints[i].inputAxis);
            if (joints[i].is_active)
            {
                if (joints[i].is_positive) robotController.RotateJoint(i, RotationDirection.Positive);
                else robotController.RotateJoint(i, RotationDirection.Negative);
                return;
            }
        }
        robotController.StopAllJointRotations();
    }

    public void ButtonDown(int joint_num, bool is_positive)
    {
        joints[joint_num].is_active = true;
        joints[joint_num].is_positive = is_positive;
    }

    public void ButtonUp(int joint_num, bool is_positive)
    {
        joints[joint_num].is_active = false;
        joints[joint_num].is_positive = is_positive;
    }
}
