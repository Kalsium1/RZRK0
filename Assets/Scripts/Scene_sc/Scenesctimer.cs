using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scenesctimer : MonoBehaviour
{


    public GameObject Canvas = null;

   

    public void timer()
    {
        Canvas.SetActive(false);
        StartCoroutine(WaitBeforeShow());
    }


    IEnumerator WaitBeforeShow()
    {
        yield return new WaitForSeconds(45);
        Canvas.SetActive(true);
   
    }

    

}
