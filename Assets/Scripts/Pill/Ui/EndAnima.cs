using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class EndAnima : MonoBehaviour
{
    public GameObject canvens;
    private VideoPlayer vp;
	// Use this for initialization
	void Start ()
	{
	    vp = GetComponent<VideoPlayer>();
        StartCoroutine(EndAniam());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator EndAniam()
    {
        while (vp.isPlaying)
        {
            yield return new WaitForEndOfFrame();
        }
        canvens.SetActive(true);
    }
}
