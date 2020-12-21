using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMinigame : MonoBehaviour
{
    public Text Completed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Completed.text = PersistantObject.CompletedMinigames.ToString()+"/3";
    }
    public void Back()
    {
        Scene CurrentScene = SceneManager.GetActiveScene();
        string SceneName = CurrentScene.name;
        if(SceneName=="Intruder")
        {
            PlayerPrefs.SetInt("Intr", 1);
        }
        else if(SceneName=="Differences")
        {
            PlayerPrefs.SetInt("Diff", 1);
        }
        else if(SceneName=="Puzzle 15")
        {
            PlayerPrefs.SetInt("Puzzle", 1);
        }

        SceneManager.LoadScene(1);
    }
}
