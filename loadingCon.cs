using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadingCon : MonoBehaviour {

    public GameObject lodingScreenObj; // lodingGameObj
    public Slider loadingBar; // loding bar slider
    public GameObject start; // start button
    AsyncOperation async;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Level()
    {
        start.SetActive(false); // disbale start button then hit play
        StartCoroutine("LoadLevel"); // call level
    }


    IEnumerator LoadLevel()
    {
        lodingScreenObj.SetActive(true); // loading screen object set true 
        async = SceneManager.LoadSceneAsync(1); // load level in background
        async.allowSceneActivation = false; // as soon as level is done loading show level on the screen

        while (async.isDone == false) // while level is not  completely loaded
        {
            loadingBar.value = async.progress; // value of progrees always begins at 0 end at 1. set lodingbar value to async.progress
            if (async.progress == 0.9f) // is progress value are 0.9f 
            {
                loadingBar.value = 1f; //set loding bar value to 1 it means level are completely loaded
                async.allowSceneActivation = true; // active level and show on screen
            }
            yield return null; // execution paused at the next frame
        }
    }
}
