using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberBox : MonoBehaviour
{
    public int index = 0;
    public int x = 0;
    public int y = 0;
    private Puzzle puzzle;

    private Action<int, int> swapFunc = null;

    private void Start()
    {
        puzzle = GameObject.Find("Puzzle").GetComponent<Puzzle>();
        Status();
    }

    public void Init(int i, int j, int index, Sprite sprite, Action<int, int> swapFunc)
    {
        this.index = index;
        this.GetComponent<SpriteRenderer>().sprite = sprite;
        UpdatePos(i, j);
        this.swapFunc = swapFunc;
    }


    public void UpdatePos(int i, int j)
    {
        x = i;
        y = j;
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        Status();
        float elapesedTime = 0;
        float duration = 0.2f;
        Vector2 start = this.gameObject.transform.localPosition;
        Vector2 end = new Vector2(x, y);

            while(elapesedTime<duration)
            {
            this.gameObject.transform.localPosition = Vector2.Lerp(start, end, (elapesedTime / duration));
            elapesedTime += Time.deltaTime;
            yield return null;
            }
    }

    public bool IsEmpty()
    {
        return index == 16;
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && swapFunc != null)
        {
            swapFunc(x, y);
        }
    }

    void Status()
    {
        if (index == 1 && x == 1 && y == 3)
        {
            Debug.Log("Index 1 is correct");
            puzzle.index1 = true;
        }   

        if (index == 1 && x != 1 || index == 1 && y != 3)
            puzzle.index1 = false;

        if (index == 2 && x == 1 && y == 1)
        {
            Debug.Log("Index 2 is correct");
            puzzle.index2 = true;
        }

        if (index == 2 && x != 1 || index == 1 && y != 1)
            puzzle.index2 = false;


        if (index == 3 && x == 2 && y == 2)
        {
            Debug.Log("Index 3 is correct");
            puzzle.index3 = true;
        }

        if (index == 3 && x != 2 || index == 3 && y != 2)
            puzzle.index3 = false;

        if (index == 4 && x == 3 && y == 3)
        {
            Debug.Log("Index 4 is correct");
            puzzle.index4 = true;
        }

        if (index == 4 && x != 3 || index == 4 && y != 3)
            puzzle.index4 = false;

        if (index == 5 && x == 0 && y == 2)
        {
            Debug.Log("Index 5 is correct");
            puzzle.index5 = true;
        }

        if (index == 5 && x != 0 || index == 5 && y != 2)
            puzzle.index5 = false;

        if (index == 6 && x == 0 && y == 1)
        {
            Debug.Log("Index 6 is correct");
            puzzle.index6 = true;
        }

        if (index == 6 && x != 0 || index == 6 && y != 1)
            puzzle.index6 = false;

        if (index == 7 && x == 1 && y == 2)
        {
            Debug.Log("Index 7 is correct");
            puzzle.index7 = true;
        }

        if (index == 7 && x != 1 || index == 7 && y != 2)
            puzzle.index7 = false;

        if (index == 8 && x == 0 && y == 0)
        {
            Debug.Log("Index 8 is correct");
            puzzle.index8 = true;
        }

        if (index == 8 && x != 0 || index == 8 && y != 0)
            puzzle.index8 = false;

        if (index == 9 && x == 2 && y == 1)
        {
            Debug.Log("Index 9 is correct");
            puzzle.index9 = true;
        }

        if (index == 9 && x != 2 || index == 9 && y != 1)
            puzzle.index9 = false;

        if (index == 10 && x == 0 && y == 3)
        {
            Debug.Log("Index 10 is correct");
            puzzle.index10 = true;
        }

        if (index == 10 && x != 0 || index == 10 && y != 3)
            puzzle.index10 = false;

        if (index == 11 && x == 3 && y == 2)
        {
            Debug.Log("Index 11 is correct");
            puzzle.index11 = true;
        }

        if (index == 11 && x != 3 || index == 11 && y != 2)
            puzzle.index11 = false;

        if (index == 12 && x == 1 && y == 0)
        {
            Debug.Log("Index 12 is correct");
            puzzle.index12 = true;
        }

        if (index == 12 && x != 1 || index == 12 && y != 0)
            puzzle.index12 = false;

        if (index == 13 && x == 3 && y == 1)
        {
            Debug.Log("Index 13 is correct");
            puzzle.index13 = true;
        }

        if (index == 13 && x != 3 || index == 13 && y != 1)
            puzzle.index13 = false;

        if (index == 14 && x == 2 && y == 0)
        {
            Debug.Log("Index 14 is correct");
            puzzle.index14 = true;
        }

        if (index == 14 && x != 2 || index == 14 && y != 0)
            puzzle.index14 = false;

        if (index == 15 && x == 3 && y == 0)
        {
            Debug.Log("Index 15 is correct");
            puzzle.index15 = true;
        }

        if (index == 15 && x != 3 || index == 15 && y != 0)
            puzzle.index15 = false;
    }
}
