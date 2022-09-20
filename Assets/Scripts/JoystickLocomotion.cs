// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using OVR;

// public class JoystickLocomotion : MonoBehaviour
// {
//     public Rigidbody robot;
//     public float speed;
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         var joystickAxis = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick, OVRInput.Controller.RTouch);
//         float fixedY = robot.position.y;

//         robot.position +=(transform.right * joystickAxis.x + transform.forward * joystickAxis.y) * Time.deltaTime * speed;
//         robot.position - new Vector3(robot.position.x,fixedY, robot.position.z);
//     }
// }
