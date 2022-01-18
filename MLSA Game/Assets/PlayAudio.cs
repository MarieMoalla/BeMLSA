using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayAudio : MonoBehaviour
{
    public AudioSource openDoor;
   
    public void PlayOpenDoor (){
         try{  
           openDoor.Play();
         }
      catch(Exception e){print("error");}
  
    }
   
}
