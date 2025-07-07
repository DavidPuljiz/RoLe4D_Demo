using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class lwr_anim : MonoBehaviour
{
    public Button Next;
    private int step = 0;
    private int step_N = 9;
    private string lwr_base = "ROOM_DH/Pedestal_LWR/kuka_lbr_iiwa_14_r820/base_link";
    // Start is called before the first frame update
    void Start()
    {
        Next.onClick.AddListener(NextStep);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NextStep()
    {
        step = (step + 1) % step_N;
        Debug.Log(step);
        string go_name = lwr_base;
        if(step==0)
        {
            //ENABLE ALL LINKS
            GameObject.Find(go_name).SetActive(true);

            //Enable ARROWS
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_1").SetActive(true);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_2").SetActive(true);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_3").SetActive(true);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_4").SetActive(true);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_5").SetActive(true);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_6").SetActive(true);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_7").SetActive(true);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_8").SetActive(true);


        }
        else if (step==1)
        {
            go_name += "/link_"+step.ToString();
            GameObject.Find(go_name).SetActive(false);

            //Disable ARROWS
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_1").SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_2").SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_3").SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_4").SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_5").SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_6").SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_7").SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_8").SetActive(false);

            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_1").SetActive(true);
            //GameObject.Find("ROOM_DH/Pedestal_UR10/ur_DH_coo_2").SetActive(true);

        }

        else if (step == 2)
        {
            for (int i=1; i<step;i++)
            {
                go_name += "/link_" + i.ToString();
            }
            GameObject.Find(go_name).SetActive(true);
            go_name += "/link_" + step.ToString();
            GameObject.Find(go_name).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_2").SetActive(true);

        }

        else if (step == 3)
        {
            for (int i = 1; i < step; i++)
            {
                go_name += "/link_" + i.ToString();
            }
            GameObject.Find(go_name).SetActive(true);
            go_name += "/link_" + step.ToString();
            GameObject.Find(go_name).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_" + (step - 2).ToString()).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_" + step.ToString()).SetActive(true);
      
        }

        else if (step == 4)
        {
            for (int i = 1; i < step; i++)
            {
                go_name += "/link_" + i.ToString();
            }
            GameObject.Find(go_name).SetActive(true);
            go_name += "/link_" + step.ToString();
            GameObject.Find(go_name).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_" + (step - 2).ToString()).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_" + step.ToString()).SetActive(true);

        }

        else if (step == 5)
        {
            for (int i = 1; i < step; i++)
            {
                go_name += "/link_" + i.ToString();
            }
            GameObject.Find(go_name).SetActive(true);
            go_name += "/link_" + step.ToString();
            GameObject.Find(go_name).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_" + (step - 2).ToString()).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_" + step.ToString()).SetActive(true);

        }

        else if (step == 6)
        {
            for (int i = 1; i < step; i++)
            {
                go_name += "/link_" + i.ToString();
            }
            GameObject.Find(go_name).SetActive(true);
            go_name += "/link_" + step.ToString();
            GameObject.Find(go_name).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_" + (step - 2).ToString()).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_" + step.ToString()).SetActive(true);

        }

        else if (step == 7)
        {
            for (int i = 1; i < step; i++)
            {
                go_name += "/link_" + i.ToString();
            }
            GameObject.Find(go_name).SetActive(true);
            go_name += "/link_" + step.ToString();
            GameObject.Find(go_name).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_" + (step - 2).ToString()).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_" + step.ToString()).SetActive(true);

        }
        else if (step == 8)
        {
            for (int i = 1; i < step; i++)
            {
                go_name += "/link_" + i.ToString();
            }
            GameObject.Find(go_name).SetActive(true);

            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_" + (step - 2).ToString()).SetActive(false);
            GameObject.Find("ROOM_DH/Pedestal_LWR/lwr_DH_coo_" + step.ToString()).SetActive(true);

        }
    }
}
