using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ur10_anim : MonoBehaviour
{
    public Button Next;
    private int step = 0;
    private int step_N = 8;
    private string ur10_base = "ROOM_DH/Pedestal_UR10/ur10/world/base_link";
    // Start is called before the first frame update
    void Start()
    {
        Next.onClick.AddListener(NextStep);

        //DISABLE ARROWS
        GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_1").SetActive(false);
        GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_2").SetActive(false);
        GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_3").SetActive(false);
        GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_4").SetActive(false);
        GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_5").SetActive(false);
        GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_6").SetActive(false);
        GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_7").SetActive(false);

        //DISABLE TEXT
        GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J1").SetActive(false);
        GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J2").SetActive(false); 
        GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J3").SetActive(false);
        GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J4").SetActive(false);
        GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J5").SetActive(false);
        GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J6").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NextStep()
    {
        step = (step + 1) % step_N;
        //GameObject Temp;
        Debug.Log(step);
        string go_name = ur10_base;
        if(step==0)
        {
            //ENABLE ALL LINKS
            GameObject.Find(go_name).SetActive(true);
            go_name += "/shoulder_link";
            GameObject.Find(go_name).SetActive(true);
            go_name += "/upper_arm_link";
            GameObject.Find(go_name).SetActive(true);
            go_name += "/forearm_link";
            GameObject.Find(go_name).SetActive(true);
            go_name += "/wrist_1_link";
            GameObject.Find(go_name).SetActive(true);
            go_name += "/wrist_2_link";
            GameObject.Find(go_name).SetActive(true);
            go_name += "/wrist_3_link";
            GameObject.Find(go_name).SetActive(true);
            go_name += "/ee_link";
            GameObject.Find(go_name).SetActive(true);

            //DISABLE ARROWS          
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_1").SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_2").SetActive(false);         
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_3").SetActive(false);            
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_4").SetActive(false);         
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_5").SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_6").SetActive(false);           
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_7").SetActive(false);

            //DISABLE TEXT
            GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J1").SetActive(false);
            GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J2").SetActive(false);
            GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J3").SetActive(false);
            GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J4").SetActive(false);
            GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J5").SetActive(false);
            GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J6").SetActive(false);

        }
        else if (step==1)
        {
            go_name += "/shoulder_link";
            GameObject.Find(go_name).SetActive(false);
            
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_1").SetActive(true);            
            //GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_2").SetActive(true);
           
        }

        else if (step == 2)
        {
            go_name += "/shoulder_link";
            GameObject.Find(go_name).SetActive(true);
            go_name += "/upper_arm_link";
            GameObject.Find(go_name).SetActive(false);            
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_2").SetActive(true);
            GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J1").SetActive(true);
        }

        else if (step == 3)
        {
            go_name += "/shoulder_link/upper_arm_link";
            GameObject.Find(go_name).SetActive(true);
            go_name += "/forearm_link";
            GameObject.Find(go_name).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_1").SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_3").SetActive(true);
            GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J2").SetActive(true);
        }

        else if (step == 4)
        {
            go_name += "/shoulder_link/upper_arm_link/forearm_link";
            GameObject.Find(go_name).SetActive(true);
            go_name += "/wrist_1_link";
            GameObject.Find(go_name).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_2").SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_4").SetActive(true);
            GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J3").SetActive(true);
        }

        else if (step == 5)
        {
            go_name += "/shoulder_link/upper_arm_link/forearm_link/wrist_1_link";
            GameObject.Find(go_name).SetActive(true);
            go_name += "/wrist_2_link";
            GameObject.Find(go_name).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_3").SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_5").SetActive(true);
            GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J4").SetActive(true);
        }

        else if (step == 6)
        {
            go_name += "/shoulder_link/upper_arm_link/forearm_link/wrist_1_link/wrist_2_link";
            GameObject.Find(go_name).SetActive(true);
            go_name += "/wrist_3_link";
            GameObject.Find(go_name).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_4").SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_6").SetActive(true);
            GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J5").SetActive(true);
        }

        else if (step == 7)
        {
            go_name += "/shoulder_link/upper_arm_link/forearm_link/wrist_1_link/wrist_2_link/wrist_3_link";
            GameObject.Find(go_name).SetActive(true);            
            //GameObject.Find(go_name).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_5").SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_7").SetActive(true);
            GameObject.Find("ROOM_DH/wall_boards/board_ur10/Canvas_UR10/Text_J6").SetActive(true);
        }
    }
}
