using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantObject : MonoBehaviour
{
    public static int Intruder;
    public static int Differences;
    public static int Fifteen;
    public static int CompletedMinigames;
    public static int MaintainLanguage;
    // Start is called before the first frame update
    void Start()
    {
        Intruder = PlayerPrefs.GetInt("Intr");
        Differences = PlayerPrefs.GetInt("Diff");
        Fifteen = PlayerPrefs.GetInt("Puzzle");
        MaintainLanguage = PlayerPrefs.GetInt("Language");
    }

    // Update is called once per frame
    void Update()
    {
        CheckCompletedMinigames();
    }

    public void CheckCompletedMinigames()
    {
        if(Intruder==0&&Differences==0&&Fifteen==0)
        {
            CompletedMinigames = 0;
        }
        else if(Intruder==1||Differences==1||Fifteen==1)
        {
            CompletedMinigames = 1;
        }
        else if(Intruder==1&&Differences==1||Differences==1&&Fifteen==1||Intruder==1&&Fifteen==1)
        {
            CompletedMinigames = 2;
        }
        else if(Intruder==1&&Differences==1&&Fifteen==1)
        {
            CompletedMinigames = 3;
        }
    }
}
