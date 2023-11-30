using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Audio_Trigger : MonoBehaviour
{
    public AudioSource Raudio;

    void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
                Raudio.Play();
        }
    }

    void OnTriggerExit(Collider player)
    {

        if(player.gameObject.tag == "Player")
        {
            Raudio.Stop();
        }
    }
}
