using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContral : MonoBehaviour
{
    public CharacterContral P1;
    public CharacterContral P2;

    public float X_Min; public float X_Max;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float x = Mathf.Clamp((P1.transform.position.x + P2.transform.position.x) / 2, X_Min, X_Max);
	  transform.position=new Vector3(x,transform.position.y,transform.position.z);
	}
}
