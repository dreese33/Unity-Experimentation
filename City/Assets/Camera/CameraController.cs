using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int speed = 50;

        this.UpdateXYZ(speed);
    }

    void UpdateXYZ(int speed)
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
    }
}
