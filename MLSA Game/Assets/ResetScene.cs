using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ResetScene : MonoBehaviour
{
private Scene scene;

void Start()
{
scene = SceneManager.GetActiveScene();
}

 void OnTriggerEnter(Collider plyr)
    {
          try{  
            if (plyr.gameObject.tag == "Player"){
          Debug.Log("reset expercted");
           SceneManager.LoadScene(scene.name);
           }
         }
      catch(Exception e){print("error");}
      }
}
