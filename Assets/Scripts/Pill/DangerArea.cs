using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerArea : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.layer==9)
        {
            collider2D.GetComponent<CharacterContral>().Dead();
        }
    }
}
