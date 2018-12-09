using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleGeneration : MonoBehaviour
{
   int[] xValues = new int[3] { -10, 0, 10 };
    public GameObject[] obstacles = new GameObject[5];
    public GameObject[] collectibles = new GameObject[8];
    public GameObject obstacle;
    public GameObject leftBarrier;
    public GameObject rightBarrier;
    public GameObject road;
    public GameObject collectible;
   public float zObject = -100;
  public  float zEnv = 0;
  public  float zRoad = 500;
     System.Random rnd = new System.Random();
    int collectibleLoc;
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
            collectibleLoc = xValues[rnd.Next(0, xValues.Length)];
            obstacle = obstacles[rnd.Next(0, obstacles.Length)];
            collectible = collectibles[rnd.Next(0, collectibles.Length)];
            x = xValues[rnd.Next(0, xValues.Length)];
            Instantiate(obstacle, new Vector3(0, 0, zObject), Quaternion.identity);
            Instantiate(collectible, new Vector3(collectibleLoc, 0, zObject), Quaternion.identity);

            zObject = zObject + 50;


        }


    }

    public void createObstacles()
    {
        x = xValues[rnd.Next(0, xValues.Length)];
        collectibleLoc = xValues[rnd.Next(0, xValues.Length)];
                    obstacle = obstacles[rnd.Next(0, obstacles.Length)];
        collectible = collectibles[rnd.Next(0, collectibles.Length)];

        Instantiate(obstacle, new Vector3(0, 0, zObject), Quaternion.identity);
        Instantiate(leftBarrier, new Vector3(-515, 0, zEnv), Quaternion.identity);
        Instantiate(rightBarrier, new Vector3(15, 0, zEnv), Quaternion.identity);
        Instantiate(road, new Vector3(0, 0, zRoad), Quaternion.identity);
        Instantiate(collectible, new Vector3(collectibleLoc, 0, zObject), Quaternion.identity);
        zObject = zObject + 50;
        zEnv = zEnv + 500;
        zRoad = zRoad + 500;

        if (preMade == true)
        {
            Invoke("createObstacles", 5);
        }


    }
    



}
