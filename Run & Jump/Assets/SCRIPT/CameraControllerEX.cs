using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerEX : MonoBehaviour
{
    public GameObject player;
    public GameObject wall;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset.x = 0;
        offset.y = transform.position.y - player.transform.position.y;
        offset.z = transform.position.z - player.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position.x = player.transform.position.x + offset.x;
        //transform.position.y = player.transform.position.y + offset.y;
        //transform.position.z = player.transform.position.z + offset.z;
    }
}
