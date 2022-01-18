using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
    public Rigidbody body;

    private float inputH;
    private float inputV;
    // Start is called before the first frame update
    void Start()
    {
         try{  
         body = GetComponent<Rigidbody>();
         }
      catch(Exception e){print("error");}
    
       
    }

    // Update is called once per frame
    void Update()
    {
         try{  
          float moveX = inputH*20f*Time.deltaTime;
        float moveZ = inputV*50f*Time.deltaTime;

         body.velocity = new Vector3(moveX,0f,moveZ);
         }
      catch(Exception e){print("error");}
       
    }
}
