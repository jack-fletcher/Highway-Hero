using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customInput : MonoBehaviour {

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30), ("Horizontal Axis: " + Input.GetAxis("Horizontal")));
        GUI.Label(new Rect(10, 30, 200, 30), ("Vertical Axis: " + Input.GetAxis("Vertical")));
        
    }
}

