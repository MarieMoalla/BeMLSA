using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MainMenu : MonoBehaviour
{
   public void PlayGame () {
      try{  
         SceneManager.LoadScene("Scene1");
         }
      catch(Exception e){print("error");}
    
   }
   public void Quit(){
      try{   
        Debug.Log("Quit!");
       Application.Quit();}
      catch(Exception e){print("error");}
      
   }
    public void Menu(){
      try{   
        Debug.Log("Quit!");
      SceneManager.LoadScene("Default");}
      catch(Exception e){print("error");}
      
   }
   public void Update(){
      try{   if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape key was pressed");
            SceneManager.LoadScene("Default");
        }}
      catch(Exception e){print("error");}
     
   }
}
