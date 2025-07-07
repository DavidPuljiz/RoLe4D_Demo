using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LengthButtonClick : MonoBehaviour
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
    public void OnLenghtButtonClick()
    {
        state = (state + 1) % 3;
        if (state == 0)
            _title.text = "-";
        else if (state == 1)
            _title.text = "0";
        else if (state == 2)
            _title.text = "+";
        else
            _title.text = "Ups";
    }
}
