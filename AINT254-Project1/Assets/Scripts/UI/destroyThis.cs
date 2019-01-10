using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class destroyThis : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (SceneManager.GetActiveScene().name == ("gameScene1"))
        {
            Destroy(this.gameObject);
        }
	}
}
