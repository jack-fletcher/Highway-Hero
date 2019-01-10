using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleChangerScript : MonoBehaviour {
    public static bool isBoosted;
    private ParticleSystem pSystem;

    // Use this for initialization
    public void Start()
    {
        isBoosted = false;
    }

    // Update is called once per frame
    void Update () {
        pSystem = GetComponent<ParticleSystem>();
        var main = pSystem.main;
        //grey, base
        if (isBoosted == false)
        {
            main.startColor = new Color(0.5f, 0.5f, 0.5f, 1f);
        }
        if (isBoosted == true)
        {
            //red
            main.startColor = new Color(1f, 0f, 0f, 1f);
        }
    }

    public void boostedColour()
    {
        //red
        var main = pSystem.main;

        main.startColor = new Color(1f,0f ,0f ,1f );

    }
    public void notBoosted()
    {
        var main = pSystem.main;

        main.startColor = new Color(0.5f, 0.5f, 0.5f, 1f);

    }
}
