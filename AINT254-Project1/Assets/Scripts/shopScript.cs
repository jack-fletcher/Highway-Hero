using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shopScript : MonoBehaviour
{
    bool[] purchased = new bool[5] { false, false, false, false, false };

    public int position = 0;
    public Text titleText = null;
    public Text Coins = null;
    public Text Cost = null;
    public Text purchase = null;
    public Text selected = null;
    public int coinCost;
    public GameObject shopCar;
    private GameObject hoveredCar;
    // Use this for initialization
    void Start()
    {

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
        position++;


    }

    public void leftButton()
    {
        position--;
    }
    public void purchaseButton()
    {

        if (PlayerPrefs.GetInt("coins") > coinCost && purchased[position] == false)
        {
            purchased[position] = true;
            PlayerPrefs.SetInt("coins", (PlayerPrefs.GetInt("coins") - coinCost));
            
        }
        
           
        
    }
    public void carSelect()
    {

        if (purchased[position] == true)
            {
            characterCreation.selectedCar = hoveredCar;
            selected.text = "Selected!";
        }
        
        {
            selected.text = "Select";
        }
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
        switch (position)
        {
            case 0:
                titleText.text = "Purple Purveyor";
                coinCost = 0;
                hoveredCar = Resources.Load("Prefabs/purplePurveyor") as GameObject;
                shopCar = Resources.Load("Prefabs/purplePurveyorShop") as GameObject;

                Cost.text = "Cost:" + " " + coinCost.ToString();
                break;
            case 1:
                titleText.text = "Red Rammer";
                coinCost = 50;
                hoveredCar = Resources.Load("Prefabs/redRammer") as GameObject;
                shopCar = Resources.Load("Prefabs/redRammerShop") as GameObject;

                Cost.text = "Cost:" + " " + coinCost.ToString();

                break;
            case 2:
                titleText.text = "Green Giant";
                coinCost = 75;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                hoveredCar = Resources.Load("Prefabs/greenGiant") as GameObject;
                shopCar = Resources.Load("Prefabs/greenGiantShop") as GameObject;

                break;
            case 3:
                titleText.text = "Blazing Blue";
                coinCost = 200;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                hoveredCar = Resources.Load("Prefabs/blazingBlue") as GameObject;
                shopCar = Resources.Load("Prefabs/blazingBlueShop") as GameObject;

                break;
            case 4:
                titleText.text = "White whip";
                coinCost = 20;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                hoveredCar = Resources.Load("Prefabs/whiteWhip") as GameObject;
                shopCar = Resources.Load("Prefabs/whiteWhipShop") as GameObject;

                break;

            default:
                break;
        }
    }
}

