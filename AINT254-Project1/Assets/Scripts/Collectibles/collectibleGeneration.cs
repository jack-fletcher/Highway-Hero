using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibleGeneration : MonoBehaviour {
    public GameObject[] collectibles = new GameObject[3];
    private GameObject collectible;
    private int collectibleLoc;
    private float zCollectible;
    System.Random rnd = new System.Random();
    int[] xValues = new int[3] { -10, 0, 10 };

    // Use this for initialization
    void Start () {
        //preplaces 20 collectibles
        zCollectible = 30;
        InvokeRepeating("createCollectibles", 0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void createCollectibles()
    {
        ////pick a random x value from -10, 0, 10 to choose which lane the coin is in
       
        collectibleLoc = xValues[rnd.Next(0, xValues.Length)];

        //generates a collectible based on what number is generated
        int numGen = rnd.Next(0, 100);
        //2% chance of lifeup
        if (numGen <= 2)
        {
            collectible = collectibles[1];
        }
        else if (numGen > 2 && numGen < 60)
        {
            //58% chance of no collectible
            //collectible is an empty prefab
            collectible = collectibles[2];
        }
        else if (numGen >= 60)
        {
            //40% chance of collectible being a coin
            collectible = collectibles[0];
        }
        //collectible = collectibles[rnd.Next(0, collectibles.Length)];
        Instantiate(collectible, new Vector3(collectibleLoc, collectible.transform.position.y, zCollectible), Quaternion.identity);
        zCollectible += 50;
        
    }
}
