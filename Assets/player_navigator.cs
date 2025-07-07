using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Sprites;
using UnityEngine.UI;
using TMPro;
public class player_navigator : MonoBehaviour
{
    public GameObject XR_Origin_Object;
    public GameObject Video_Object;
    private VideoPlayer player;
    private bool first_start = true;
    private MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        //At the start the outside and hallway arrows guide player to cinema
        GameObject.Find("Player_Navigation/Arrow_outside").GetComponent<MeshRenderer>().enabled=true;
        GameObject.Find("Player_Navigation/Arrow_hallway").GetComponent<MeshRenderer>().enabled = true;

        GameObject.Find("Player_Navigation/Arrow_cinema").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("Player_Navigation/Arrow_hallway_2").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("Player_Navigation/Arrow_DH_1").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("Player_Navigation/Arrow_DH_2").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("Player_Navigation/Arrow_DH_3").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("Player_Navigation/Arrow_DH_4").GetComponent<MeshRenderer>().enabled = false;

        /*
                GameObject.Find("Player_Navigation/Arrow_outside").SetActive(true);
                GameObject.Find("Player_Navigation/Arrow_hallway").SetActive(true);

                GameObject.Find("Player_Navigation/Arrow_cinema").SetActive(false);
                GameObject.Find("Player_Navigation/Arrow_hallway_2").SetActive(false);
                GameObject.Find("Player_Navigation/Arrow_DH_1").SetActive(false);
                GameObject.Find("Player_Navigation/Arrow_DH_2").SetActive(false);
                GameObject.Find("Player_Navigation/Arrow_DH_3").SetActive(false);
                GameObject.Find("Player_Navigation/Arrow_DH_4").SetActive(false);
        */
        player =Video_Object.GetComponent<VideoPlayer>();
        Debug.Log("Outside and hallway arrows enabled");
    }

    // Update is called once per frame
    void Update()
    {

        //When the player enters halway disable outside arrow
        if (XR_Origin_Object.transform.position.z > 5 && GameObject.Find("Player_Navigation/Arrow_outside").GetComponent<MeshRenderer>().enabled)
        {
            GameObject.Find("Player_Navigation/Arrow_outside").GetComponent<MeshRenderer>().enabled = false;
            Debug.Log("Outside aarrows disabled");
        }

        //When the player plays the video disable hallway arrow, and enable the cinema and 2nd hallway arrow guiding player to DH room and the 1st arrow in DH room
        if (player.isPlaying && first_start)
        {
            GameObject.Find("Player_Navigation/Arrow_cinema").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("Player_Navigation/Arrow_hallway").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Player_Navigation/Arrow_hallway_2").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("Player_Navigation/Arrow_DH_1").GetComponent<MeshRenderer>().enabled = true;
            first_start = false;
            Debug.Log("Player started video event");
        }
       
        //When the player enters DH room disable cinema and 2nd hallway arrow
        if ((XR_Origin_Object.transform.position.z > 5) && (XR_Origin_Object.transform.position.x > 8))
        {
            GameObject.Find("Player_Navigation/Arrow_cinema").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Player_Navigation/Arrow_hallway_2").GetComponent<MeshRenderer>().enabled = false;
            Debug.Log("Player entered DH room");
        }

        //when player is within 1 m of 1st arrow in DH room, siable it and enable the second and so on...

        if (Vector3.Distance(XR_Origin_Object.transform.position, GameObject.Find("Player_Navigation/Arrow_DH_1").transform.position)<2.0)
        {
            GameObject.Find("Player_Navigation/Arrow_DH_1").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Player_Navigation/Arrow_DH_2").GetComponent<MeshRenderer>().enabled = true;
            Debug.Log("near 1st arrow");
        }

        if (Vector3.Distance(XR_Origin_Object.transform.position, GameObject.Find("Player_Navigation/Arrow_DH_2").transform.position) < 2.0)
        {
            GameObject.Find("Player_Navigation/Arrow_DH_2").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Player_Navigation/Arrow_DH_3").GetComponent<MeshRenderer>().enabled = true;
            Debug.Log("near 2nd arrow");
        }


        if (Vector3.Distance(XR_Origin_Object.transform.position, GameObject.Find("Player_Navigation/Arrow_DH_3").transform.position) < 2.0)
        {
            GameObject.Find("Player_Navigation/Arrow_DH_3").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Player_Navigation/Arrow_DH_4").GetComponent<MeshRenderer>().enabled = true; 
            Debug.Log("near 3rd arrow");
        }

    }
}
