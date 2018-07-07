using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class SavePoint : MonoBehaviour
{
    private BoxCollider2D bc2d;
	// Use this for initialization
    private Vector2 SavePosition_P1=Vector2.zero;
    private Vector2 SavePosition_P2=Vector2.zero;
    private GameContralor contralor;
	void Start ()
	{
	    bc2d = GetComponent<BoxCollider2D>();
	    contralor = FindObjectOfType<GameContralor>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.gameObject.layer==9)
        {
            if (c2d.GetComponent<CharacterContral>().IsP2)
            {
                SavePosition_P2 = c2d.transform.position;
            }
            else
            {
                SavePosition_P1 = c2d.transform.position;
            }
        }

        if (SavePosition_P1!=Vector2.zero && SavePosition_P2!=Vector2.zero)
        {
            contralor.QuickSave(SavePosition_P1,SavePosition_P2);
        }
    }
}
