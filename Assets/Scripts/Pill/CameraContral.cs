using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContral : MonoBehaviour
{
    public CharacterContral P1;
    public CharacterContral P2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	  transform.position=new Vector3((P1.transform.position.x + P2.transform.position.x)/2,transform.position.y,transform.position.z);
	}
}
