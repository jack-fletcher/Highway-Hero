using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashScript : MonoBehaviour
{
    GameObject explosion;

    void OnTriggerEnter(Collider other)
    {
        explosion = Resources.Load("Prefabs/Explosion") as GameObject;
        if (other.gameObject.CompareTag("Player"))
        {
            //Destroy(other.gameObject);
            //Instantiate(explosion, this.transform);
            
           SceneManager.LoadScene("gameOver");
        }
        else if(other.gameObject.CompareTag("Traffic"))
        {
       //     Destroy(other.gameObject);
        }
    }
}