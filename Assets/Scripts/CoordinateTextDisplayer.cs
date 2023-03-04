using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoordinateTextDisplayer : MonoBehaviour
{
    public GameObject gameManager;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = gameManager.GetComponentInChildren<ClickAndDrag>().dir;
        GetComponentInChildren<Text>().text = dir.ToString();
    }
}
