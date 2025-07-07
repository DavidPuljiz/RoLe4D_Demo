using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class teachpad_button_plugin : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    
    public int joint_num;
    public bool is_positive;
    public GameObject teachpad_controller;

    public void OnPointerDown(PointerEventData eventData)
    {
        teachpad_controller.GetComponent<TeachpadController>().ButtonDown(joint_num, is_positive);

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        teachpad_controller.GetComponent<TeachpadController>().ButtonUp(joint_num, is_positive);
    }
}
