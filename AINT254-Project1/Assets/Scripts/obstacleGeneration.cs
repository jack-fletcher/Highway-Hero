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
   public float zObject = -100;
  public  float zEnv = 0;
  public  float zRoad = 500;
    static System.Random rnd = new System.Random();
    bool cpuSaver = false;
    public int trackLength = 5;
    int x; 
    // Use this for initialization
    void Start()
    {
        
    }
    //6 -2 14 are the numbers which a square can be instantiated on on the x axis 763
    // Update is called once per frame
    void Update()
    {
        //int x = xValues[rnd.Next(0, xValues.Length)];

        //float x = Random.Range(-8, 20);
        if (cpuSaver == false)
        {
            for (int i = 0; i < trackLength; i++)



            {
                 x = xValues[rnd.Next(0, xValues.Length)];
                Instantiate(obstacle, new Vector3(x, 0, zObject), Quaternion.identity);
                Instantiate(leftBarrier, new Vector3(-265, 0, zEnv), Quaternion.identity);
                Instantiate(rightBarrier, new Vector3(265, 0, zEnv), Quaternion.identity);
                Instantiate(road, new Vector3(0, 0, zRoad), Quaternion.identity);
                zObject = zObject + 50;
                zEnv = zEnv + 507;
                zRoad = zRoad + 500;
                Debug.Log(x);
                cpuSaver = true;

            }
        }

        else if (zObject < zRoad)
        {
            x = xValues[rnd.Next(0, xValues.Length)];
            Instantiate(obstacle, new Vector3(x, 0, zObject), Quaternion.identity);
            zObject = zObject + 50;


        }
    }
    



}
