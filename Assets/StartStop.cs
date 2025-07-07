using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Sprites;
using UnityEngine.UI;
using TMPro;

public class StartStop : MonoBehaviour
{
    // Start is called before the first frame update
    private VideoPlayer player;
    public Button button;
    public Sprite startSprite;
    public Sprite stopSprite;
    public Button ff;
    public Button rewind;

    void Start()
    {
        player = GetComponent<VideoPlayer>();
        ff.onClick.AddListener(FF_Press);
        rewind.onClick.AddListener(Rewind_Press);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeStartStop()
    {
        if (player.isPlaying == false)
        {
            player.Play();
            button.image.sprite = stopSprite;
        }
        else
        {
            player.Pause();
            button.image.sprite = startSprite;
        }
    }

    void FF_Press()
    {
        double time;
        if (!player.isPlaying) return;
        Debug.Log("Current Time:" + player.time.ToString());
        time = player.time + 2.0;
        if (time > player.clip.length) time = player.clip.length;
        player.time = time;
        Debug.Log("Time after FF press:" + player.time.ToString());
    }

    void Rewind_Press()
    {
        double time;
        if (!player.isPlaying)
        {
            if (player.time == player.clip.length)
            {
                time = player.time - 2.0;
                player.time = time;
                player.Play();
            }
            else return;
        }
        Debug.Log("Current Time:"+  player.time.ToString());
        time = player.time - 2.0;
        if (time < 0) time = 0.0;
        player.time = time;
        Debug.Log("Time after Rewind press:"+ player.time.ToString());
    }
}
