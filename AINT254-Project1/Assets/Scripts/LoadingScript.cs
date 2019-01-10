using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class LoadingScript : MonoBehaviour {
     AsyncOperation async;
    
    public TextMeshProUGUI loadText;
    // Use this for initialization
    void Start () {
        
        StartCoroutine("Load");
        loadText.text = "Loading Game...";
	}
	
	// Update is called once per frame
	void Update ()
    {



        

	}
    //loads scene assets
    IEnumerator Load()
    {

        async = SceneManager.LoadSceneAsync("gameScene1");
        async.allowSceneActivation = false;
        while (!async.isDone)
        {
            if (async.progress >= 0.9f)
            {
                loadText.text = "Press any key to start";
                if (Input.anyKeyDown)
                {
                    async.allowSceneActivation = true;
                }
                yield return null;
            }
        }



    }

    IEnumerator Flash()
    {
        yield return new WaitForSeconds(1f);
        //loadText.enabled = !loadText.enabled;
    }

}
