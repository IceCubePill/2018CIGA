using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsJump : MonoBehaviour
{
    private CharacterContral cc;
	// Use this for initialization
	void Start ()
	{
	    cc = transform.parent.GetComponent<CharacterContral>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(cc.isflood);
	}

    void OnTriggerStay2D(Collider2D c2d)
    {
        if (c2d.gameObject.layer==12)
        {
            cc.isflood = true;;
        }
    }
    void OnTriggerExit2D(Collider2D c2d)
    {
        if (c2d.gameObject.layer == 12)
        {
            cc.isflood = false; ;
        }
    }
}
