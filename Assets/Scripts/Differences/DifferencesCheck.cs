using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifferencesCheck : MonoBehaviour
{
    public int This;
    public int DiffCheck;
    public GameObject Circle;
    public GameObject VictoryPanel;
    public bool[] VictoryBool;
    Difference Diff;
    // Start is called before the first frame update
    void Start()
    {
        Diff = FindObjectOfType<Difference>();
    }

    // Update is called once per frame
    void Update()
    {
        Victory();
    }

    public void OnMouseDown()
    {
        Circle.SetActive(true);
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
        {
            Circle.transform.position = hit.point;
        }
        DiffCheck = 0;
    }

    public void Victory()
    {
        if(VictoryBool[0]&& VictoryBool[1]&& VictoryBool[2]&& VictoryBool[3]&& VictoryBool[4]&& VictoryBool[5])
        {
            VictoryPanel.SetActive(true);
            PersistantObject.Differences = 1;

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
