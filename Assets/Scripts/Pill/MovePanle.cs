using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePanle : MonoBehaviour
{
    public float speed = 10;
    public List<GameObject> paths = new List<GameObject>();
    private List<Vector2> point = new List<Vector2>();
    public bool IsEnable = true;
    private int index = 0;
    private Vector2 target;
    // Use this for initialization
    void Start()
    {
        if (paths.Count < 2)
        {
            IsEnable = false;

        }
        foreach (var p in paths)
        {
            point.Add(p.transform.position);
        }

        target = point[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (IsEnable)
        {
            if (Vector2.Distance(target, (Vector2)transform.position) < 1)
            {
                index++;
                if (index  >= point.Count)
                {
                    Debug.Log(index);
                    index = 0;
                    target = point[0];
                }
                else
                {
                    target = point[index];
                }
            }
            Vector2 direction = (target - (Vector2)transform.position).normalized;

            transform.position = (Vector2)transform.position + direction * speed * Time.fixedDeltaTime;

        }
    }
}
