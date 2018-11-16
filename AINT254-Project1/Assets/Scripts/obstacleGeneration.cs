using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleGeneration : MonoBehaviour
{
   int[] xValues = new int[3] { -10, 0, 10 };
    public GameObject obstacle;
    public GameObject leftBarrier;
    public GameObject rightBarrier;
    public GameObject road;
    public GameObject coin;
   public float zObject = -100;
  public  float zEnv = 0;
  public  float zRoad = 500;
     System.Random rnd = new System.Random();
    int coinloc;
    private bool preMade = false;
    public int trackLength = 5;
    private int x; 
    // Use this for initialization
    void Start()
    {
        //premake the first x chunks of path where x is tracklength
        for (int i = 0; i < trackLength; i++)



        {
            createObstacles();
        }
        preMade = true;
        createObstacles();
    }
    //6 -2 14 are the numbers which a square can be instantiated on on the x axis 763
    // Update is called once per frame
    void Update()
    {
        //fills spacew with obstacles/collectables
        if (zObject < zRoad)
        {
            coinloc = xValues[rnd.Next(0, xValues.Length)];

            x = xValues[rnd.Next(0, xValues.Length)];
            Instantiate(obstacle, new Vector3(x, 0, zObject), Quaternion.identity);
            Instantiate(coin, new Vector3(coinloc, 0, zObject), Quaternion.identity);

            zObject = zObject + 50;


        }


    }

    public void createObstacles()
    {
        x = xValues[rnd.Next(0, xValues.Length)];
        coinloc = xValues[rnd.Next(0, xValues.Length)];
        Instantiate(obstacle, new Vector3(x, 0, zObject), Quaternion.identity);
        Instantiate(leftBarrier, new Vector3(-265, 0, zEnv), Quaternion.identity);
        Instantiate(rightBarrier, new Vector3(265, 0, zEnv), Quaternion.identity);
        Instantiate(road, new Vector3(0, 0, zRoad), Quaternion.identity);
        Instantiate(coin, new Vector3(coinloc, 0, zObject), Quaternion.identity);
        zObject = zObject + 50;
        zEnv = zEnv + 507;
        zRoad = zRoad + 500;

        if (preMade == true)
        {
            Invoke("createObstacles", 5);
        }


    }
    



}
