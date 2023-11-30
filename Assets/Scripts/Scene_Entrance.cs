using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Entrance : MonoBehaviour
{
    public string LastExitName;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetString("LastExitName") == LastExitName)
        {
            Player_Script.instance.transform.position = transform.position;
            Player_Script.instance.transform.eulerAngles = transform.eulerAngles;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
