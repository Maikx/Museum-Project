using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissingImagesMinigame : MonoBehaviour
{
    public GameObject[] MissingFigure;
    public GameObject VictoryPanel;
    public bool[] FigureFound;
    public int Win = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BoolsCheck();
        if(Win==3)
        {
            Victory();
        }
    }

    public void BoolsCheck()
    {
        if(FigureFound[0]==false)
        {
            MissingFigure[0].SetActive(false);
        }
        else
        {
            MissingFigure[0].SetActive(true);
        }

        if (FigureFound[1] == false)
        {
            MissingFigure[1].SetActive(false);
        }
        else
        {
            MissingFigure[1].SetActive(true);
        }
        
        if (FigureFound[2] == false)
        {
            MissingFigure[2].SetActive(false);
        }
        else
        {
            MissingFigure[2].SetActive(true);
        }
    }

    public void Victory()
    {
        VictoryPanel.SetActive(true);
        PersistantObject.Intruder = 1;

        if (PersistantObject.Intruder == 0 && PersistantObject.Differences == 0 && PersistantObject.Fifteen == 0)
        {
            PersistantObject.CompletedMinigames = 0;
        }
        else if (PersistantObject.Intruder == 1 || PersistantObject.Differences == 1 || PersistantObject.Fifteen == 1)
        {
            PersistantObject.CompletedMinigames = 1;
        }
        else if (PersistantObject.Intruder == 1 && PersistantObject.Differences == 1 || PersistantObject.Differences == 1 && PersistantObject.Fifteen == 1 || PersistantObject.Intruder == 1 && PersistantObject.Fifteen == 1)
        {
            PersistantObject.CompletedMinigames = 2;
        }
        else if (PersistantObject.Intruder == 1 && PersistantObject.Differences == 1 && PersistantObject.Fifteen == 1)
        {
            PersistantObject.CompletedMinigames = 3;
        }
    }
}
