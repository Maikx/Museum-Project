using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difference : MonoBehaviour
{
    public int Diff;
    public int PictureN;
    public GameObject Partner;
    public GameObject Circle;
    public bool Pressed;
    public bool Comp;
    DifferencesCheck DC;
    DifferencesCheck2 DC2;
    // Start is called before the first frame update
    void Start()
    {
        DC = FindObjectOfType<DifferencesCheck>();
        DC2 = FindObjectOfType<DifferencesCheck2>();
    }

    // Update is called once per frame
    void Update()
    {
        BoolsCheck();
    }
    public void OnMouseDown()
    {
        if(PictureN==0)
        {
            DC.Circle.SetActive(false);
            DC.DiffCheck = Diff;
        }
        else if(PictureN==1)
        {
            DC2.Circle.SetActive(false);
            DC2.DiffCheck = Diff;
        }
    }

    public void BoolsCheck()
    {
        if(PictureN==0)
        {
            if (DC.DiffCheck == Diff)
            {
                Pressed = true;
            }
            else
            {
                Pressed = false;
            }
        }
        else if(PictureN==1)
        {
            if(DC2.DiffCheck==Diff)
            {
                Pressed = true;
            }
            else
            {
                Pressed = false;
            }
        }
        if (Pressed == true || Comp == true)
        {
            Circle.SetActive(true);
        }
        else if(Pressed==false && Comp==false)
        {
            Circle.SetActive(false);
        }
        if(DC.DiffCheck==DC2.DiffCheck && DC.DiffCheck==Diff)
        {
            Comp = true;
        }
        if(Comp==true)
        {
            if(Diff==1)
            {
                DC.VictoryBool[0] = true;
            }
            if (Diff == 2)
            {
                DC.VictoryBool[1] = true;
            }
            if (Diff == 3)
            {
                DC.VictoryBool[2] = true;
            }
            if (Diff == 4)
            {
                DC.VictoryBool[3] = true;
            }
            if (Diff == 5)
            {
                DC.VictoryBool[4] = true;
            }
            if (Diff == 6)
            {
                DC.VictoryBool[5] = true;
            }
        }
    }
}
