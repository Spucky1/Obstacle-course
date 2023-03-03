using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{

    MeshRenderer renderer;
    [SerializeField]float TimetoWait = 3f;
    Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rd = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rd.useGravity = false;

            
   }
    

    // Update is called once per frame
    void Update()
    {
        if(Time.time > TimetoWait) 
        {
            
            rd.useGravity = true;
            renderer.enabled = true;
        }
        
    }
}

