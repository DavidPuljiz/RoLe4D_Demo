using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class task_script : MonoBehaviour
{
    // Start is called before the first frame update
    public int number_of_joints = 7;
   // private int[,] states = new int[number_of_joints, 4];
    
    public Button Submit;


    private int[,] solution = { { 2, 1, 2, 1 }, { 2, 1, 1, 3 }, { 2, 1, 2, 1 }, { 2, 1, 1, 3 }, { 2, 1, 2, 1 }, { 2, 1, 1, 3 }, { 2, 1, 2, 2 } };
   
    void Start()
    {
       Submit.onClick.AddListener(Solution_Submitted);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void Solution_Submitted() 
    {
        GameObject Par;
        AngleButtonClick ButtonA;
        LengthButtonClick ButtonL;
        Image img;
        for (int i = 1; i <= number_of_joints; i++)
        {
            // THETA
            Par=GameObject.Find("t"+i.ToString());
            ButtonA = Par.GetComponent<AngleButtonClick>();
            img= Par.GetComponent<Image>();
            if (ButtonA.state == solution[i-1, 0])
            {
                img.color = Color.green;
            }
            else
                img.color = Color.red;
            //A
            Par = GameObject.Find("a" + i.ToString());
            ButtonL = Par.GetComponent<LengthButtonClick>();
            img = Par.GetComponent<Image>();
            if (ButtonL.state == solution[i - 1, 1])
            {
                img.color = Color.green;
            }
            else
                img.color = Color.red;

            //D
            Par = GameObject.Find("d" + i.ToString());
            ButtonL = Par.GetComponent<LengthButtonClick>();
            img = Par.GetComponent<Image>();
            if (ButtonL.state == solution[i - 1, 2])
            {
                img.color = Color.green;
            }
            else
                img.color = Color.red;

            //Alpha
            Par = GameObject.Find("al" + i.ToString());
            ButtonA = Par.GetComponent<AngleButtonClick>();
            img = Par.GetComponent<Image>();
            if (ButtonA.state == solution[i - 1, 3])
            {
                img.color = Color.green;
            }
            else
                img.color = Color.red;
        }
  
    }


}
