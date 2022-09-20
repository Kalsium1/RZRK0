using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene0timer1 : MonoBehaviour
{


    public GameObject Canvas = null;

   

    public void timer()
    {
        Canvas.SetActive(false);
        StartCoroutine(WaitBeforeShow());
    }


    IEnumerator WaitBeforeShow()
    {
        yield return new WaitForSeconds(15);
        Canvas.SetActive(true);
   
    }

    

}
