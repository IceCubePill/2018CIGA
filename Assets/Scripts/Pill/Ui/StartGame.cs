using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public  GameObject panle;

    public int index=0;

    private bool IsStart = false;
	// Use this for initialization
	void Start () {
		Object.DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
	    if (IsStart==false)
	    {
	        if (Input.anyKey)
	        {
	            IsStart = true;
	            LoadScene(1);
	        }
	        //panle.SetActive(true);

        }
	    if (Input.GetKeyDown(KeyCode.F1))
	    {
	        LoadScene(1);

	    }
	    if (Input.GetKeyDown(KeyCode.F2))
	    {
	        LoadScene(2);

	    }
	    if (Input.GetKeyDown(KeyCode.F3))
	    {
	        LoadScene(3);

	    }
    }

    public void LoadScene(int i)
    {
        StartCoroutine(Loading(i));
        index = i;

    }

    IEnumerator Loading(int i)
    {
        if (i>4)
        {
           yield return null;
        }
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
