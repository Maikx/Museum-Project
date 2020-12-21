using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public NumberBox boxPrefab;

    public NumberBox[,] boxes = new NumberBox[4, 4];

    public Sprite[] sprites;

    public bool index1;
    public bool index2;
    public bool index3;
    public bool index4;
    public bool index5;
    public bool index6;
    public bool index7;
    public bool index8;
    public bool index9;
    public bool index10;
    public bool index11;
    public bool index12;
    public bool index13;
    public bool index14;
    public bool index15;

    void Start()
    {
        Init();
    }

    private void Update()
    {
        Victory();
    }

    void Init()
    {
        int n = 0;
        for (int y=3;y>=0;y--)
        for (int x=0;x<4;x++)
        {
                NumberBox box = Instantiate(boxPrefab, new Vector2(x, y), Quaternion.identity);
                box.Init(x, y, n + 1, sprites[n], ClickToSwap);
                boxes[x, y] = box;
                n++;
        }
    }

    void ClickToSwap(int x, int y)
    {
        int dx = getDx(x, y);
        int dy = GetDy(x, y);

        var from = boxes[x, y];
        var target = boxes[x + dx, y + dy];

        //swap this 2 boxes
        boxes[x, y] = target;
        boxes[x + dx, y + dy] = from;

        //update pos 2 boxes
        from.UpdatePos(x + dx, y + dy);
        target.UpdatePos(x, y);
    }

    int getDx(int x, int y)
    {
        //is right empty
        if (x < 3 && boxes[x + 1, y].IsEmpty())
            return 1;
        //is left empty
        if (x > 0 && boxes[x - 1, y].IsEmpty())
            return -1;
        return 0;
    }

    int GetDy(int x, int y)
    {
        //is top empty
        if (y < 3 && boxes[x, y + 1].IsEmpty())
            return 1;
        //is bottom empty
        if (y > 0 && boxes[x, y - 1].IsEmpty())
            return -1;
        return 0;
    }

    void Victory()
    {
        if (index1 == true && index2 == true && index3 == true && index4 == true && index5 == true && index6 == true && index7 == true && index8 == true && index9 == true && index10 == true && index11 == true && index12 == true && index13 == true && index14 == true && index15 == true)
        {
            Debug.Log("Victory");
            PersistantObject.Fifteen = 1;

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
}
