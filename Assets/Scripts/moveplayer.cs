using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        float tspeed = speed * Time.deltaTime;



        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, tspeed);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -tspeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-tspeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(tspeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += new Vector3(0, -tspeed, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, tspeed, 0);
        }
















    }
}
