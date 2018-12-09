using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashScript : MonoBehaviour
{

  //  public static bool invincible = false;
   // GameObject explosion;

    void OnTriggerEnter(Collider other)
    {
        //  explosion = Resources.Load("Prefabs/Explosion") as GameObject;
        if (other.gameObject.CompareTag("Player"))
        {
            if (PlayerScript.invincible == false)
            {
                if (PlayerScript.lives > 0)
                {
                    PlayerScript.lives -= 1;
                    Destroy(this.gameObject);
                }
            }
            if (PlayerScript.invincible == true)
            {
                Destroy(this.gameObject);
            }
            //Destroy(other.gameObject);
            //Instantiate(explosion, this.transform);
            else if (PlayerScript.lives == 0)
            {
                Destroy(other.gameObject);
                death();
                    }
        }
        //else if (other.gameObject.CompareTag("Traffic"))
        //{
        //    //     Destroy(other.gameObject);
        //}
    }

    void death()
    {
        SceneManager.LoadScene("gameOver");

    }
}