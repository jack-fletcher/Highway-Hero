using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashScript : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("gameOver");
        }
        else if(other.gameObject.CompareTag("Traffic"))
        {
       //     Destroy(other.gameObject);
        }
    }
}