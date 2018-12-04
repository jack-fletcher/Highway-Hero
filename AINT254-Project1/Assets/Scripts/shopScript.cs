using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shopScript : MonoBehaviour
{
    bool[] purchased = new bool[5] { true, false, false, false, false };
    private int purchasedLength;
    private int position = 0;
    public Text titleText = null;
    public Text Coins = null;
    public Text Cost = null;
    public Text purchase = null;
    public Text selected = null;
    private int coinCost;
    public Text baseSpeed = null;
    public Text turnSpeed = null;
    public Text maxSpeed = null;
    private float getbaseSpeed;
    private float getTurnSpeed;
    private float getMaxSpeed;
    public GameObject shopCar;
    private GameObject hoveredCar;
    // Use this for initialization
    void Start()
    {


 

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
        }
        else
        {
            position++;
        }
        UIChanges();
    }

    public void leftButton()
    {
        if (position == 0)
        {
            position = purchasedLength;

        }
        else
        {
            position--;
        }
        UIChanges();
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
            movementScript.baseSpeed = getbaseSpeed;
            movementScript.turnSpeed = getTurnSpeed;
            movementScript.maxSpeed = getMaxSpeed;
        }
        else 
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
                getbaseSpeed = 50f;
                getTurnSpeed = 0.25f;
                getMaxSpeed = 100f;
                baseSpeed.text = "Base Speed: " + getbaseSpeed;
                turnSpeed.text = "Turn Speed: " + getTurnSpeed + " seconds";
                maxSpeed.text = "Max speed: " + getMaxSpeed;
                Cost.text = "Cost:" + " " + coinCost.ToString();

                break;
            case 1:
                titleText.text = "Red Rammer";
                coinCost = 50;
                hoveredCar = Resources.Load("Prefabs/redRammer") as GameObject;
                shopCar = Resources.Load("Prefabs/redRammerShop") as GameObject;
                getbaseSpeed = 30f;
                getTurnSpeed = 0.25f;
                getMaxSpeed = 80f;
                baseSpeed.text = "Base Speed: " + getbaseSpeed;
                turnSpeed.text = "Turn Speed: " + getTurnSpeed + " seconds";
                maxSpeed.text = "Max speed: " + getMaxSpeed;
                Cost.text = "Cost:" + " " + coinCost.ToString();

                break;
            case 2:
                titleText.text = "Green Giant";
                coinCost = 75;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                hoveredCar = Resources.Load("Prefabs/greenGiant") as GameObject;
                shopCar = Resources.Load("Prefabs/greenGiantShop") as GameObject;
                getbaseSpeed = 30f;
                getTurnSpeed = 0.25f;
                getMaxSpeed = 80f;
                baseSpeed.text = "Base Speed: " + getbaseSpeed;
                turnSpeed.text = "Turn Speed: " + getTurnSpeed + " seconds";
                maxSpeed.text = "Max speed: " + getMaxSpeed;

                break;
            case 3:
                titleText.text = "Blazing Blue";
                coinCost = 200;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                hoveredCar = Resources.Load("Prefabs/blazingBlue") as GameObject;
                shopCar = Resources.Load("Prefabs/blazingBlueShop") as GameObject;
                getbaseSpeed = 30f;
                getTurnSpeed = 0.25f;
                getMaxSpeed = 80f;
                baseSpeed.text = "Base Speed: " + getbaseSpeed;
                turnSpeed.text = "Turn Speed: " + getTurnSpeed + " seconds";
                maxSpeed.text = "Max speed: " + getMaxSpeed;
                break;
            case 4:
                titleText.text = "White whip";
                coinCost = 20;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                hoveredCar = Resources.Load("Prefabs/whiteWhip") as GameObject;
                shopCar = Resources.Load("Prefabs/whiteWhipShop") as GameObject;
                getbaseSpeed = 30f;
                getTurnSpeed = 0.25f;
                getMaxSpeed = 80f;
                baseSpeed.text = "Base Speed: " + getbaseSpeed;
                turnSpeed.text = "Turn Speed: " + getTurnSpeed + " seconds";
                maxSpeed.text = "Max speed: " + getMaxSpeed;
                break;

            default:
                break;
        }
    }

    void UIChanges()
    {

    }
}

