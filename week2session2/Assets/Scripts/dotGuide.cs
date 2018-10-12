using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotGuide : MonoBehaviour {
    [SerializeField]
    public float gravity = -9.81f;
    public float force = 10;
    private GameObject prefabDot;
    private GameObject[] createGuideArray;
    private Transform transformPos;
    private Camera cam;
    private Vector3 direction;
    private Vector3 cameraPos;

    void Start(){
    createGuideArray = new GameObject[10];
        prefabDot = GameObject.Find("dot");
        cam = Camera.main;
       
        
        transformPos = transform;

       for(int i = 0; i < createGuideArray.Length; i++)
        {
            GameObject tempObject = Instantiate(prefabDot);
            createGuideArray[i] = tempObject;
           // createGuideArray[i].SetActive(false);
        }
}
    private void Update()
    {
        cameraPos = cam.WorldToScreenPoint(transform.position);
        cameraPos.z = 0;

        if (Input.GetMouseButtonDown(0))
        {

            
            direction = (Input.mousePosition - cameraPos).normalized;
            Aim();
        }
        if (Input.GetMouseButtonUp(0))
        {

        }
    }


    //dx = sx * t
    //dy = sy * t - 0.5 * g * t^2
    
        ////dx is distance on x
        //sx = speed on x - vector
        //t = Time  = 
        //Sy speed on y = - vector
        //g = gravity - earth gravity = 9.81f
        //pow2 = power of 2
    private void Aim()
    {
        float t;
        float Sx = direction.x * force;
        float Dx;
        float Sy = direction.y * force;
        float Dy;

        for (int i = 0; i < createGuideArray.Length; i++)
        {
             t = i;
             Dx = Sx * t;
            Dy = (Sy * t) - (0.5f * gravity * (t * t));
            createGuideArray[i].transform.position = new Vector3(transformPos.position.x + Dx, transformPos.position.y + Dy, transform.position.z);
            createGuideArray[i].SetActive(true);
        }
         
        
    }
}
