using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashScript : MonoBehaviour
{
    private AudioSource crash;
    public GameObject explosion;
    public static bool isDead;
    private Renderer[] renderer;
   
    //  public static bool invincible = false;
    // GameObject explosion;

    private void Start()
    {
        isDead = false;
        crash = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        renderer = GetComponentsInChildren<Renderer>();
        foreach (Renderer r in renderer)
        {
            r.enabled = true;
        }
    }
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
                    PlayerScript.invincible = true;
                    crash.Play();
                    Instantiate(explosion, transform.position, Quaternion.identity);
                    RendererOff();
                    //  PlayerMovement.currentSpeed = 50;
                    Invoke("disable", 2f);
                }

            }
            if (PlayerScript.invincible == true)
            {
                RendererOff();
                Invoke("disable", 2f);
            }
            //Destroy(other.gameObject);
            //Instantiate(explosion, this.transform);
            else if (PlayerScript.lives == 0)
            {
                renderer = other.GetComponentsInChildren<Renderer>();
                RendererOff();
                Instantiate(explosion, other.transform.position, Quaternion.identity);
                other.gameObject.GetComponent<MeshCollider>().enabled = false;
                Light[] light = other.gameObject.GetComponentsInChildren<Light>();
                foreach (Light thing in light)
                {
                    thing.enabled = false;
                }
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
        // Time.timeScale = 0;
       
        AudioListener.pause = true;
        isDead = true;
        //SceneManager.LoadScene("gameOver");

    }
    void RendererOff()
    {
        
        foreach (Renderer r in renderer)
        {
            r.enabled = false;
        }
    }
    private void disable()
    {
        this.gameObject.SetActive(false);

    }
}