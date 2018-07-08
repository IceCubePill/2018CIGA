using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerArea : MonoBehaviour
{
    private AudioSource AS;
	// Use this for initialization
	void Start ()
	{
	    AS = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.layer==9)
        {
            collider2D.GetComponent<CharacterContral>().Dead();
            AS.Play();
        }
    }
}
