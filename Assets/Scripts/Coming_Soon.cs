using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coming_Soon : MonoBehaviour
{
    public Canvas Soon;
    // Start is called before the first frame update

    void Start()
    {
        Soon.enabled = false;
    }
    void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            Soon.enabled = true;

        }
    }

    void OnTriggerExit(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            Soon.enabled = false;
        }
    }


}
