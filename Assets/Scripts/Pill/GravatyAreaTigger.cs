using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravatyAreaTigger : MonoBehaviour
{
    private GravityArea GA;
	// Use this for initialization
	void Start ()
	{
	    GA = transform.parent.GetComponent<GravityArea>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   void  OnTriggerEnter2D(Collider2D c2d)
   {
       if (c2d.gameObject .layer==9)
       {
            GA.enabled = true;
       }
      
   }
    void OnTriggerExit2D(Collider2D c2d)
    {
        if (c2d.gameObject.layer == 9)
        {
            GA.Exit2D();
            GA.enabled = false;
        }
      
    }
}
