using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackGeneration : MonoBehaviour {
    public GameObject chunk;
    private float zChunk;
    private float chunkLength = 500;
    //private bool preMade = false;
    //private int trackLength;
    // Use this for initialization
    void Start () {
        
        zChunk = chunk.transform.position.z + chunkLength;
        //trackLength = 5;
        InvokeRepeating("createChunk", 0f, 3f);
    }

    // Update is called once per frame
    void Update () {

    }

    void createChunk()
    {
        Instantiate(chunk, new Vector3(chunk.transform.position.x, chunk.transform.position.y, zChunk), Quaternion.identity);
        zChunk += 500;
    }
}
