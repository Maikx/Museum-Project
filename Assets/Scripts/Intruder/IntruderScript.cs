using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntruderScript : MonoBehaviour
{
    public int Intr;
    MissingImagesMinigame MiM;
    // Start is called before the first frame update
    void Start()
    {
        MiM = FindObjectOfType<MissingImagesMinigame>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        MiM.Win++;
        this.gameObject.SetActive(false);
        if (Intr==0)
        {
            MiM.FigureFound[0] = true;
        }
        else if(Intr==1)
        {
            MiM.FigureFound[1] = true;
        }
        else if(Intr==2)
        {
            MiM.FigureFound[2] = true;
        }
    }
}
