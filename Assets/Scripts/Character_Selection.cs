using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Character_Selection : MonoBehaviour
{
    private GameObject[] Characters;
    private int index;
    public int selectedCharacter = 0;
    public string sceneToLoad;
    public string exitName;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Characters = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            Characters[i] = transform.GetChild(i).gameObject;
        }
        foreach (GameObject go in Characters)
            go.SetActive(false);
        if(Characters[0])
            Characters[0].SetActive(true);
    }

    public void ToggleLeft()
    {
        Characters[index].SetActive(false);
        index--;
        if(index < 0){
            index = Characters.Length -1;
        }
        Characters[index].SetActive(true);
    }
    
    public void ToggleRight()
    {
        Characters[index].SetActive(false);
        index++;
        if(index == Characters.Length )
        {
            index = 0;
        }

        Characters[index].SetActive(true);
    }

    public void ConfirmButton()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        if (index == 0)
        {
            SceneManager.LoadScene("Outside");
        }
        
        if(index == 1)
        {
            SceneManager.LoadScene("Outside2");
        }
    }

}