using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AngleButtonClick : MonoBehaviour
{
    public int state = 0;
    [SerializeField]
    private TMP_Text _title;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAngleButtonClick()
    {
        state = (state + 1) % 5;
        if (state == 0)
            _title.text = "-π";
        else if (state == 1)
            _title.text = "-π/2";
        else if (state == 2)
            _title.text = "0";
        else if (state == 3)
            _title.text = "π/2";
        else if (state == 4)
            _title.text = "π";
        else
            _title.text = "Ups";
    }
}
