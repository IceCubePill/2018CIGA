using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityArea : MonoBehaviour
{
    public float GravatyFactory = -1;

    private float rawgravaty;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //void OnCollisionEnter2D(Collision2D c2d)
    //{
    //    if (c2d.gameObject.layer == 9)
    //    {
    //        rawgravaty = c2d.gameObject.GetComponent<CharacterContral>().GravatyFactor;
    //        c2d.gameObject.GetComponent<CharacterContral>().GravatyFactor = GravatyFactory;
    //    }
    //}
    //void OnCollisionExit2D(Collision2D c2d)
    //{
    //    if (c2d.gameObject.layer == 9)
    //    {
    //        rawgravaty = c2d.gameObject.GetComponent<CharacterContral>().GravatyFactor;
    //        c2d.gameObject.GetComponent<CharacterContral>().GravatyFactor = GravatyFactory;
    //    }
    //}
    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.gameObject.layer == 9)
        {
            rawgravaty = c2d.GetComponent<CharacterContral>().GravatyFactor;
            c2d.GetComponent<CharacterContral>().GravatyFactor = GravatyFactory;
        }
    }
    void OnTriggerExit2D(Collider2D c2d)
    {
        if (c2d.gameObject.layer == 9)
        {
            c2d.GetComponent<CharacterContral>().GravatyFactor = rawgravaty;
        }
    }
}
