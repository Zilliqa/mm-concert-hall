using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Choices_Trigger_CS : MonoBehaviour
{
    public Canvas Choice_Canvas;
    public Canvas Soon_Canvas;
    public Button Btn_S1;
    public Button Btn_S2;
    public Button Btn_S3;
    public AudioSource Raudio1;
    [SerializeField] private Animator QCSAgent;
    [SerializeField] string videoFileName;
    public VideoPlayer videoPlayer;

    void Start()
    {
        Choice_Canvas.enabled = false;
        Soon_Canvas.enabled = false;
        QCSAgent.SetBool("Explain", false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            Raudio1.Play();
            Choice_Canvas.enabled = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

    public void Service1()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Choice_Canvas.enabled = false;
        QCSAgent.SetBool("Explain", true);
        string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
        Debug.Log(videoPath);
        videoPlayer.url = videoPath;
        videoPlayer.Play();
    }

    public void Service2()
    {
        Choice_Canvas.enabled = false;
        Soon_Canvas.enabled = true;
    }

    public void Service3()
    {
        Choice_Canvas.enabled = false;
        Soon_Canvas.enabled = true;
    }

    void OnTriggerExit(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            Choice_Canvas.enabled = false;
            Soon_Canvas.enabled = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
