using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissingImagesMinigame : MonoBehaviour
{
    public GameObject[] MissingFigure;
    public bool[] FigureFound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BoolsCheck();
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
}
