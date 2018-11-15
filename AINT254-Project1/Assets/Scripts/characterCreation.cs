using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterCreation : MonoBehaviour {
    public static GameObject selectedCar;
	// Use this for initialization
	void Start () {
        if (selectedCar == null)
        {
            selectedCar = Resources.Load("Prefabs/purplePurveyor") as GameObject;
        }
        Instantiate(selectedCar);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
