using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerArea : MonoBehaviour
{
    private AudioSource AS;

    private GameContralor GC;
	// Use this for initialization
	void Start ()
	{
	    AS = GetComponent<AudioSource>();
	    GC = FindObjectOfType<GameContralor>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.layer==9)
        {
            StartCoroutine(Dead());
        }
    }

    IEnumerator Dead()
    {
        GC.P1_Contral.IsContral = false;
        GC.P2_Contral.IsContral = false;
        AS.Play();
        while (AS.isPlaying)
        {
            yield return new WaitForEndOfFrame();
        }
        GC.QuickLoad();
       
    }
}
