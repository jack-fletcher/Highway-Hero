using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour {


    public static ObjectPooler Instance;
    private void Awake()
    {
        Instance = this;
    }

    public GameObject[] carPrefab = new GameObject[5];
    public List<Pool> pools;
    System.Random rnd = new System.Random();
    //collection of keys and value, key[string] and a gameobject in the queue as its 'definition'

    public Dictionary<string, Queue<GameObject>> poolDictionary;
    // Use this for initialization
    void Start () {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();
        foreach (Pool pool in pools)
        {
            
            //make new queue of gameobjects
            Queue<GameObject> objectPool = new Queue<GameObject>();
            for (int i = 0; i < pool.size; i++)
            {
                //fill list with next car prefab
                pool.prefab  = carPrefab[rnd.Next(0, carPrefab.Length)];

                GameObject obj = Instantiate(pool.prefab);
                //sets them to false
                obj.SetActive(false);
                //adds them to the queue
                objectPool.Enqueue(obj);
            }
            //adds the queue to the dictionary
            poolDictionary.Add(pool.tag, objectPool);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Spawn(string tag, Vector3 position, Quaternion rotation)
    {
        //gets a gameObject from the queue
        GameObject spawnedObj = poolDictionary[tag].Dequeue();
        //sets it to active + pos/rot
        spawnedObj.SetActive(true);
        spawnedObj.transform.position = position;
        spawnedObj.transform.rotation = rotation;


        poolDictionary[tag].Enqueue(spawnedObj);

        //return spawnedObj;
    }

    [System.Serializable]
    public class Pool
    {
        public string tag;
        
        public GameObject prefab;
        public int size;
    }
}
