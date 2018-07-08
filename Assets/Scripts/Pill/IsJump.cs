using UnityEngine;

namespace Assets.Scripts.Pill
{
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
}
