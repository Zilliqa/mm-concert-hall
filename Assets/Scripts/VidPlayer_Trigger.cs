using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Choices_Trigger : MonoBehaviour
{
    public Canvas Choice_Canvas;
    public AudioSource Raudio;
    [SerializeField] private Animator QEmployee;
    [SerializeField] string videoFileName;
    public VideoPlayer vidPlayer;
    bool VidPlayed;

    void Start()
    {
        Choice_Canvas.enabled = false;
        QEmployee.SetBool("PlayPoint", false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        VidPlayed = false;
    }

    void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            Choice_Canvas.enabled = true;
            Raudio.Play();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;

            if (VidPlayed == false)
            {
                string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
                Debug.Log(videoPath);
                vidPlayer.url = videoPath;
                vidPlayer.Play();
            }
        }
    }

    void OnTriggerExit(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            Choice_Canvas.enabled = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            VidPlayed = true;
        }
    }
}
