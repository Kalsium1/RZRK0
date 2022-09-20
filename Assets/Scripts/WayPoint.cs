using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{

    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex =0;

    [SerializeField] float speed = 1f;

    float num;

    void Start()
    {
        speed = Random.Range(0f, 7f);

    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < 0.1f)
        {
            // num = Random.Range(0f, 2f);

            // if (num > 1.0f)
            // {
            //     currentWaypointIndex++;
            //     if (currentWaypointIndex >= waypoints.Length)
            //     {
            //         currentWaypointIndex = 0;
            //     }
            // }

            // else
            // {
            //     currentWaypointIndex--;
            //     if (currentWaypointIndex == -1)
            //     {
            //         currentWaypointIndex = waypoints.Length - 1;
            //     }
            // }
            transform.LookAt(waypoints[currentWaypointIndex].transform);
        

        
        

             if(currentWaypointIndex >= waypoints.Length)
         {
             currentWaypointIndex = 0;
         }

         currentWaypointIndex++;
         transform.LookAt(waypoints[currentWaypointIndex].transform);
    }


         
         
        

    


        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}



