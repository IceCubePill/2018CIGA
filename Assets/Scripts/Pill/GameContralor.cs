using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContralor : MonoBehaviour
{
    public CharacterContral P1_Contral;
    public CharacterContral P2_Contral;
    public  Vector2 SavePosition_P1;
    public Vector2 SavePosition_P2;
    // Use this for initialization
    void Start () {
	//	Object.DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public  void QuickSave(Vector2 p1,Vector2 p2)
    {
        SavePosition_P1 = p1;
        SavePosition_P2 = p2;
    }
    public void QuickLoad()
    {
        P1_Contral.transform.position = SavePosition_P1;
        P2_Contral.transform.position = SavePosition_P2;
        P1_Contral.IsContral = true;
        P2_Contral.IsContral = true;
        P1_Contral.isflood = true;
        P2_Contral.isflood = true;

    }

}
