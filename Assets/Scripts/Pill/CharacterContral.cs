using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterContral : MonoBehaviour
{
    [HideInInspector]
    public bool IsContral=true;
    [HideInInspector]
    public bool isflood = true;

    public bool IsP2=false;

    //public bool IsMagnet_N = true;
    [Header("速度")]
    public float Speed = 100;

    [Header("重力因子")]
    public  float GravatyFactor=1;


    private float t_right;


    private SpriteRenderer sr;
    private MagenetedObject mo;
    private Rigidbody2D r2d;
    private CircleCollider2D circleCollider;
    private Magenet mage;

    private GameContralor contralor;
    // Use this for initialization
    void Start ()
    {
        sr = GetComponent<SpriteRenderer>();  
        mo = GetComponent<MagenetedObject>();
        r2d = GetComponent<Rigidbody2D>();
        mage = GetComponentInChildren<Magenet>();
        circleCollider = GetComponent<CircleCollider2D>();
        contralor = FindObjectOfType<GameContralor>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
	{
	    CheckInput();
	    CheckFloor();
	    CheckGravity();

	}
    
    void CheckInput()
    {
        if (!IsP2)
        {
            if (!isflood)
            {
                 t_right = (Input.GetKey(KeyCode.D) ? 1 : 0) - (Input.GetKey(KeyCode.A) ? 1 : 0);
                if (t_right != 0)
                {
                     transform.Translate(t_right * Speed * Time.fixedDeltaTime, 0, 0);
                }
            }
            if ((Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.K)) && !(Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.K)))
            {
                if (Input.GetKey(KeyCode.J))
                {
                    sr.color = Color.blue;
                    mo.maganet = MagenetedObject.Maganet.N;
                }
                else if (Input.GetKey(KeyCode.K))
                {
                    sr.color = Color.red;
                    mo.maganet = MagenetedObject.Maganet.S;
                }
            }
            else
            {
                sr.color = Color.white;
                mo.maganet = MagenetedObject.Maganet.None;
            }
        }
        else
        {
            if (!isflood)
            {
                t_right = (Input.GetKey(KeyCode.RightArrow) ? 1 : 0) - (Input.GetKey(KeyCode.LeftArrow) ? 1 : 0);
                if (t_right != 0)
                {
                 transform.Translate(t_right * Speed * Time.fixedDeltaTime, 0, 0);
                }

            }
          

            if ((Input.GetKey(KeyCode.Keypad4) || Input.GetKey(KeyCode.Keypad6)) && !(Input.GetKey(KeyCode.Keypad4) && Input.GetKey(KeyCode.Keypad6)))
            {
                if (Input.GetKey(KeyCode.Keypad4))
                {
                    sr.color = Color.blue;
                    mo.maganet = MagenetedObject.Maganet.N;
                }
                else if (Input.GetKey(KeyCode.Keypad6))
                {
                    sr.color = Color.red;
                    mo.maganet = MagenetedObject.Maganet.S;
                }
            }
            else
            {
                sr.color = Color.white;
                mo.maganet = MagenetedObject.Maganet.None;
            }
        }
    }

    void CheckFloor()
    {
       RaycastHit2D rh2d= Physics2D.Raycast(transform.position, Vector2.down*GravatyFactor, circleCollider.radius*transform.localScale.x*2, (1 << 12) );
        if (rh2d==false)
        {
           Debug.Log("jump");
           isflood = true;
        }
        else
        {
            Debug.Log("land");
            isflood = false;
         
        }
    }
    
    void CheckGravity()
    {
        r2d.AddForce(new Vector2(0,-GravatyFactor*9.8f*r2d.mass));
    }


    public void Dead()
    {
        contralor.QuickLoad();
    }
}
