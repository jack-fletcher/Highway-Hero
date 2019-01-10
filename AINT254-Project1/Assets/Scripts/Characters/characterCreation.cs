using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterCreation : MonoBehaviour {
    public GameObject[] carSelection = new GameObject[8];
    string selectedCar;
    GameObject instantiatedCar;
	// Use this for initialization
	void Start () {

        if (PlayerPrefs.HasKey("ChosenCar"))
        {
            selectedCar = PlayerPrefs.GetString("ChosenCar");
        }
        else
        {
            PlayerPrefs.SetString("ChosenCar", "Red Car");
        }
        switch (selectedCar.ToString())
        {
            case "Red Car":
                Instantiate(carSelection[0], new Vector3(0, carSelection[0].transform.position.y, carSelection[0].transform.position.z), Quaternion.identity);
                break;
            case "SchoolBus":
                Instantiate(carSelection[1], new Vector3(0, carSelection[1].transform.position.y, carSelection[1].transform.position.z), Quaternion.identity);
                break;
            case "Green Car":
                Instantiate(carSelection[2], new Vector3(0, carSelection[2].transform.position.y, carSelection[2].transform.position.z), Quaternion.identity);
                break;
            case "Blue Car":
                Instantiate(carSelection[3], new Vector3(0, carSelection[3].transform.position.y, carSelection[3].transform.position.z), Quaternion.identity);
                break;
            case "Yellow Car":
                Instantiate(carSelection[4], new Vector3(0, carSelection[4].transform.position.y, carSelection[4].transform.position.z), Quaternion.identity);
                break;
            case "Blue Bus":
                Instantiate(carSelection[5], new Vector3(0, carSelection[5].transform.position.y, carSelection[5].transform.position.z), Quaternion.identity);
                break;
            case "Police Car":
                Instantiate(carSelection[6], new Vector3(0, carSelection[6].transform.position.y, carSelection[6].transform.position.z), Quaternion.identity);
                break;
            case "Taxi":
                Instantiate(carSelection[7], new Vector3(0, carSelection[7].transform.position.y, carSelection[7].transform.position.z), Quaternion.identity);
                break;

        }
        //if (selectedCar == null)
        //{
        //    selectedCar = Resources.Load("Prefabs/redCar") as GameObject;
        //}
        //Instantiate(selectedCar, new Vector3(selectedCar.transform.position.x, selectedCar.transform.position.y, selectedCar.transform.position.z), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
