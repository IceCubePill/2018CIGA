using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class VectorArea : MonoBehaviour
{
    private bool P2_Readdy = false;
    private bool P1_Readdy = false;
    private StartGame gameStart;
    private AudioSource AS;
    // Use this for initialization
    void Start ()
    {
        AS = GetComponent<AudioSource>();
        gameStart = FindObjectOfType<StartGame>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.gameObject.layer==9)
        {
            CharacterContral cc=c2d.GetComponent<CharacterContral>();
            if (cc.IsP2)
                P2_Readdy = true;
            else
                P1_Readdy = true;
            cc.IsContral = false;

            if (P1_Readdy && P2_Readdy)
            {
                StartCoroutine(PlaySE());
            }
        }

       
    }

    IEnumerator PlaySE()
    {
        AS.Play();
        while (AS.isPlaying)
        {
            yield return new WaitForEndOfFrame();
        }
        gameStart.LoadScene(++gameStart.index);
     
    }
}
