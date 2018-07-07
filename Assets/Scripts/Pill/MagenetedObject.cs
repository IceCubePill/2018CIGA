using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MagenetedObject : MonoBehaviour
{
   // public bool IsMagenet_N = true;
    public enum Maganet
    {
        N,
        S,
        None
        
    }
    
    public Maganet maganet =Maganet.None;
    public float MaxFroce = 100;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
