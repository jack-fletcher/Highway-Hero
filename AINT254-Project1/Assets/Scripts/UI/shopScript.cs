using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class shopScript : MonoBehaviour
{
    bool[] purchased = new bool[8] { true, false, false, false, false, false, false, false };
    public bool[] currentSelection = new bool[8]  { false, false, false, false, false, false, false, false };
    public static GameObject[] shopCar = new GameObject[5];


    private int purchasedLength;
    private int position = 0;
    public TextMeshProUGUI titleText = null;
    public TextMeshProUGUI Coins = null;
    public TextMeshProUGUI Cost = null;
    public TextMeshProUGUI purchase = null;
    public TextMeshProUGUI selected = null;
    public TextMeshProUGUI description = null;
    private int coinCost;
    public Camera cam;
    private GameObject hoveredCar;
    private Vector3 camPos;
    // Use this for initialization
    void Start()
    {
        Load();
        Time.timeScale = 1f;

        purchasedLength = (purchased.Length - 1);

        if (PlayerPrefs.HasKey("coins"))
        {

            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + PlayerScript.currentCoin);



        }

        else
        {
            PlayerPrefs.SetInt("coins", (int)PlayerScript.currentCoin);
        }

    }

    public void rightButton()
    {
        if (position == purchasedLength)
        {
            position = 0;
            cam.transform.position = new Vector3(7.2f, 0, 0);
        }
        else
        {
            position++;
            cam.transform.position = cam.transform.position + new Vector3(40, 0, 0);
        }
        //UIChanges();
    }


    public void purchaseButton()
    {

        if (PlayerPrefs.GetInt("coins") > coinCost && purchased[position] == false)
        {
            purchased[position] = true;
            PlayerPrefs.SetInt("coins", (PlayerPrefs.GetInt("coins") - coinCost));
            Save();
        }



    }
    public void carSelect()
    {

        if (purchased[position] == true)
        {
            for (int i = 0; i < currentSelection.Length; i++)
            {
                currentSelection[i] = false;
            }
            currentSelection[position] = true;
            //selected.text = "Selected!";
            PlayerPrefs.SetString("ChosenCar", titleText.text);

        }
        else
        {
            selected.text = "Select";
        }
        Save();
    }

    // Update is called once per frame
    void Update()

    {
        Coins.text = "Coins:" + " " + PlayerPrefs.GetInt("coins");
        if (purchased[position] == true)
        {
            purchase.text = "Purchased";
        }
        else
        {
            purchase.text = "Purchase";
        }
        if (currentSelection[position] == true)
        {
            selected.text = "Selected";
        }
        else
        {
            selected.text = "Select";
        }
        switch (position)
        {
            case 0:

                titleText.text = "Red Car";
                coinCost = 0;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                description.text = "This battered bright red wagon could use an oil change. It handles decently. It is 13 years old. It has spinning rims and a sunroof. The styling features rounded edges.";
                break;
            case 1:
                titleText.text = "SchoolBus";
                coinCost = 20;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                description.text = "This schoolbus is in terrible mechanical shape. It handles superbly. It has a CB radio and a diesel engine.";
                break;
            case 2:
                titleText.text = "Green Car";
                coinCost = 50;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                description.text = "This green compact car runs great aside from a rattling sound. It has large blind spots and a diesel engine. It handles moderately well. The styling features asymmetry.";
                break;
            case 3:
                titleText.text = "Blue Car";
                coinCost = 75;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                description.text = "This blue wagon runs fine at most speeds. It handles fantastically. It has a filthy interior, a navigation system, a backup camera and a diesel engine. It is very high-priced. The styling features sleek lines."; 
                break;
            case 4:
                titleText.text = "Yellow Car";
                coinCost = 200;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                description.text = "This gold sedan could use an oil change. It has a lowered body, leather seats and a moonroof. The styling features boxy structures";
                break;
            case 5:
                titleText.text = "Blue Bus";
                coinCost = 20;
                description.text = "This pale blue buss drives like it's about to fall apart. It has a stick shift, a turbo booster and an electric engine. The styling features ovoid windows.";
                Cost.text = "Cost:" + " " + coinCost.ToString();

                break;

            case 6:
                titleText.text = "Police Car";
                coinCost = 20;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                description.text = "This cop car could use a few small repairs. It is brand new. It is relatively cheap. It handles terribly. It has a dash computer, a lowered body and an electric engine.";
                break;
            case 7:
                titleText.text = "Taxi";
                coinCost = 20;
                description.text = "This rusted taxi could use an oil change. It has a CB radio, spinning rims and a diesel engine. It handles moderately well. ";
                Cost.text = "Cost:" + " " + coinCost.ToString();

                break;
            default:
                break;
        }
    }
    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/Purchased.dat");

        PlayerData data = new PlayerData();
        for (int i = 0; i < purchased.Length; i++)
        {
            data.purchased[i] = purchased[i];
            data.currentSelection[i] = currentSelection[i];
        }
        bf.Serialize(file, data );
        file.Close();
    }
    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/Purchased.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/Purchased.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            for (int i = 0; i < purchased.Length; i++)
            {


                purchased[i] = data.purchased[i];
                currentSelection[i] = data.currentSelection[i];
            }
        }
    }

    [Serializable]

    private class PlayerData {

        public bool[] purchased = new bool[8];
        public bool[] currentSelection = new bool[8];
    }
}

