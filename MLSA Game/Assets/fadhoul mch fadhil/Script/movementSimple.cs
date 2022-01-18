using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class movementSimple : MonoBehaviour
{
    Rigidbody characterController;

    public float speed = 9.0f;
    public float speedcam = 20.0f;
    public Joystick JoyStick;

    private Vector3 moveDirection = Vector3.zero;
    private Vector3 movecamDirection = Vector3.zero;

   
    private void Start()
    {
        characterController = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //#region mobile
          //var horizontal = JoyStick.Horizontal;
         // var vertical = JoyStick.Vertical;
        //#endregion
        //#region desktop
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        //#endregion
        transform.Translate(new Vector3(0, 0, vertical) * (speed * Time.deltaTime));
        transform.Rotate(new Vector3(0, horizontal, 0) * (speedcam * Time.deltaTime));


        

            moveDirection = new Vector3(0.0f, 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;
            
            
        

    }
}