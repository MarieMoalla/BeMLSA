using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class EnterMilestone : MonoBehaviour
{
   
    public void Enter () {
      try{  SceneManager.LoadScene("Scene2");}
      catch(Exception e){print("error");}
    
   }
    public void Quit () {
      try{ SceneManager.LoadScene("Scene1");}
      catch(Exception e){print("error");}
     
   }
   
}
