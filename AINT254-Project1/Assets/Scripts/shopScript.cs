using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shopScript : MonoBehaviour
{
    bool[] purchased = new bool[3] { false, false, false };

    public int position = 0;
    public Text titleText = null;
    public Text Coins = null;
    public Text Cost = null;
    public Text purchase = null;
    public int coinCost;
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

        Coins.text = "Coins:" + " " + PlayerPrefs.GetInt("coins");
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
        {
           
        }
    }


    // Update is called once per frame
    void Update()

    {
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
                Cost.text = "Cost:" + " " + coinCost.ToString();
                break;
            case 1:
                titleText.text = "Red Rammer";
                coinCost = 50;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                break;
            case 2:
                titleText.text = "Green Giant";
                coinCost = 75;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                break;
            case 3:
                titleText.text = "Blazing Blue";
                coinCost = 200;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                break;
            case 4:
                titleText.text = "White whip";
                coinCost = 20;
                Cost.text = "Cost:" + " " + coinCost.ToString();
                break;

            default:
                break;
        }
    }
}

