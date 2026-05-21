using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    [SerializeField] private float _speed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(_speed, 0, 0)*Time.deltaTime + transform.position;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(-_speed, 0, 0) * Time.deltaTime + transform.position;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(0,_speed, 0) * Time.deltaTime + transform.position;
        }


        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(0, -_speed, 0) * Time.deltaTime + transform.position;
        }
    }
}
