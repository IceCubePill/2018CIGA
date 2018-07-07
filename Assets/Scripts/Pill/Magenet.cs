using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magenet : MonoBehaviour
{
    [Header("半径")]
    public float range=1.5f;

    private CharacterContral cc;
	// Use this for initialization
	void Start ()
	{
	    cc = transform.parent.GetComponent<CharacterContral>();
	    GetComponent<CircleCollider2D>().radius = range;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 10|| collider.gameObject.layer == 9)
        {

            MagenetedObject mo = collider.GetComponent<MagenetedObject>();
            int dic=mo.maganet==cc.GetComponent<MagenetedObject>() .maganet? -1:1;
            if (cc.GetComponent<MagenetedObject>().maganet==MagenetedObject.Maganet.None||mo.maganet==MagenetedObject.Maganet.None)
            {
                dic = 0;
            }
            Vector2 direct=(mo.transform.position - cc.transform.position).normalized;
            if (collider.gameObject.layer == 10)
            {
                cc.GetComponent<Rigidbody2D>().AddForce(direct * dic * mo.MaxFroce * (Vector2.Distance(cc.transform.position, mo.transform.position)) / 5);
            }
            else if (collider.gameObject.layer == 9)
            {
             
                cc.GetComponent<Rigidbody2D>().AddForce(direct * dic * mo.MaxFroce );
            }




        }
    }

  
}
