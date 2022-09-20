// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Robot_Control : MonoBehaviour
// {
//     public AudioController ac;
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void FixedUpdate()
//     {
//         //var joyInput = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);

//         //Debug.Log(joyInput);

//         //transform.localPosition += new Vector3(0, 0, joyInput.y * Time.deltaTime);
//         //transform.localEulerAngles += new Vector3(0, joyInput.x * Time.deltaTime,0);

//     }

//     void OnCollisionEnter(Collision collision)
//     {
//         if(collision.gameObject.name == "goal")
//         {
//             ac.playAudio("drilling");
//         }
//     }
//     }
