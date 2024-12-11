using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{
    public float WallkSpeed = 1;
    public Rigidbody UnityChan;
    // Start is called before the first frame update
    void Start()
    {
        UnityChan = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x >= 0)
        {
            transform.Translate(-3, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x <= 3)
        {
            transform.Translate(3, 0, 0);
        }
        transform.Translate(0, 0, WallkSpeed / 10);
    }
}
