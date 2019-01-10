using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleGeneration : MonoBehaviour
{




   int[] xValues = new int[3] { -10, 0, 10 };
    private GameObject obstacle;
    private float obstacleLoc;
    private float zObject;
     System.Random rnd = new System.Random();


    private int x;
    // Use this for initialization
    void Start()
    {

        InvokeRepeating("createObstacles", 0f, 0.5f);
    }
    //-10, 0, 10 are the lane x values 
    // Update is called once per frame
    void FixedUpdate()
    {



    }

    public void createObstacles()
    {
        obstacleLoc = xValues[rnd.Next(0, xValues.Length)];

        ObjectPooler.Instance.Spawn("Vehicles", new Vector3(obstacleLoc, 1.5f, zObject), Quaternion.identity);
        zObject += 50;
        //obstacleLoc = xValues[rnd.Next(0, xValues.Length)];
        //obstacle = obstacles[rnd.Next(0, obstacles.Length)];
        //Instantiate(obstacle, new Vector3 (obstacleLoc, obstacle.transform.position.y, zObject), Quaternion.identity);
        //zObject += 50;
    }

 


}
