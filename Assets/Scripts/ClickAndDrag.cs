using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{
    // Check if mouse clicked
    bool clicked = false;

    public GameObject theCube;

    // Speed
    public float speed = 0.001f;

    // The coordinate where the mouse clicked
    Vector3 mouseInitialPos = Vector3.zero;
    public Vector3 dir = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (!clicked)
            {
                clicked = true;
                mouseInitialPos = Input.mousePosition;
            }

            // Direction the mouse dragging to
            dir = mouseInitialPos - Input.mousePosition;

            // Direction in 2D
            Vector3 twoDdirection = new Vector3(dir.x, 0, dir.y);

            twoDdirection.Normalize();

            // Move the cube
            theCube.transform.position -= twoDdirection*speed;
            //Debug.Log("Pressed");
        }
        else
        {
            // Refresh the variables after releasing the mouse
            clicked = false;
            mouseInitialPos = Vector3.zero;
            dir = Vector3.zero;
            //Debug.Log("Not pressed");
        }
    }
}
