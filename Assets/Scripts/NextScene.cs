using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{

    public void LoadScene(string sceneName)

    {
        SceneManager.LoadSceneAsync(sceneName);
    }
    // private int nextSceneToLoad;

    // // Start is called before the first frame update
    // private void LoadScene()
    // {
    //     nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     SceneManager.LoadScene(nextSceneToLoad);
    // }
}
