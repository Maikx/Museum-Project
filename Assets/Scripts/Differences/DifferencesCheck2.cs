using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifferencesCheck2 : MonoBehaviour
{
    public int This;
    public int DiffCheck;
    public GameObject Circle;
    Difference diff;
    // Start is called before the first frame update
    void Start()
    {
        diff = FindObjectOfType<Difference>();
    }

    // Update is called once per frame
    void Update()
    {

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
}
