using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonLogic : MonoBehaviour
{
    public GameObject img;
    public void OpenA()
    {
      try{ img.SetActive(true);}
      catch(Exception e){print("error");}
    
    }

    public void onCancelPopUp(){
      try{img.SetActive(false);}
      catch(Exception e){print("error");}
      
    }
}
