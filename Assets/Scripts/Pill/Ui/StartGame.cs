using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public  GameObject panle;
	// Use this for initialization
	void Start () {
		Object.DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.anyKey)
	    {
	        panle.SetActive(true);

        }
	}

    public void LoadScene(int i)
    {
        StartCoroutine(Loading(i));

    }

    IEnumerator Loading(int i)
    {
        SceneManager.LoadScene(5);
        panle.SetActive(false);
       AsyncOperation ao= SceneManager.LoadSceneAsync(i);
        ao.allowSceneActivation = false;
        while (!ao.isDone)
        {
            yield return new WaitForEndOfFrame();
        }

        ao.allowSceneActivation = true;
    }
}
