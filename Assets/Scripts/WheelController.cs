using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using OVR;

public class WheelController : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;
    [SerializeField] WheelCollider midRight;
    [SerializeField] WheelCollider midLeft;
    

    public float acceleration = 10f;
    public float breakingForce = 50f;
    public float maxTurnAngle = 60f;

    private float currentAcceleration = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;

    private Vector2 R_joystickAxis;
    private Vector2 L_joystickAxis;

       // Start is called before the first frame update
//     void Start()
//     {
//         OVRInput.Update();
//     }

//    private void Update()
//    {
//     var joystickAxis = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
//    }
   
    private void FixedUpdate()
    {

        OVRInput.Update();
        var R_joystickAxis = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
        var L_joystickAxis = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);


        // var joystickAxis = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick, OVRInput.Controller.RTouch);

        //Get forward/reverse acc from verticle axis
         currentAcceleration = acceleration * L_joystickAxis.y;
        // currentAcceleration = acceleration * primary2DAxis.RightHanded(1);

         if (L_joystickAxis.y == 0)

         currentBreakForce = breakingForce;
         else
         currentBreakForce = 0f;


        //Apply acceleration
        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;
        backRight.motorTorque = currentAcceleration;
        backLeft.motorTorque = currentAcceleration;
        midRight.motorTorque = currentAcceleration;
        midLeft.motorTorque = currentAcceleration;


        //Apply break
        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;
        midRight.brakeTorque = currentBreakForce;
        midLeft.brakeTorque = currentBreakForce;

        //Steering
        currentTurnAngle = maxTurnAngle * (R_joystickAxis.x);
        // currentTurnAngle = maxTurnAngle * primary2DAxis.RightHanded(0);
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;
        // backRight.steerAngle = currentTurnAngle;
        // backLeft.steerAngle = currentTurnAngle;
        // midRight.steerAngle = currentTurnAngle;
        // midLeft.steerAngle = currentTurnAngle;
       
        
      
    }

    
    




  
}
