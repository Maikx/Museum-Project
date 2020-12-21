using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiInGame : MonoBehaviour
{
    public GameObject OptionsMenu;
    public GameObject InGameMenu;
    public GameObject DiscontMenu;
    public GameObject Map;
    public Text[] Completed;
    // Start is called before the first frame update
    void Start()
    {
        Completed[0].text = PersistantObject.CompletedMinigames.ToString() + "/3";
        Completed[1].text = PersistantObject.CompletedMinigames.ToString() + "/3";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenOption()
    {
        InGameMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }
    public void CloseOptions()
    {
        InGameMenu.SetActive(true);
        OptionsMenu.SetActive(false);
    }
    public void OpenDiscount()
    {
        OptionsMenu.SetActive(false);
        InGameMenu.SetActive(false);
        DiscontMenu.SetActive(true);
    }
    public void CloseDiscount()
    {
        InGameMenu.SetActive(true);
        DiscontMenu.SetActive(false);
    }
    public void OpenMap()
    {
        InGameMenu.SetActive(false);
        Map.SetActive(true);
    }
    public void CloseMap()
    {
        InGameMenu.SetActive(true);
        Map.SetActive(false);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
