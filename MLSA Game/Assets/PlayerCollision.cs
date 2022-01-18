using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerCollision : MonoBehaviour
{
    public GameObject canves ;
    
     void OnTriggerEnter(Collider plyr)
    {
          try{  
           
            if (plyr.gameObject.tag == "Player"){
        
            canves.SetActive(true);}
         }
      catch(Exception e){print("error");}
      }
     void OnTriggerExit(Collider plyr)
    {
          try{  
           if (plyr.gameObject.tag == "Player"){
        
            canves.SetActive(false);}
         }
      catch(Exception e){print("error");}
       }
         
    }  

  



