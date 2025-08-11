using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatballPlayerControl : MonoBehaviour
{
    public int liczbaPunktow = 0;

    Rigidbody rigidbody;
    public float moveSpeed = 2.0f;

    public Transform startPoint;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(-1 * moveSpeed * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(1 * moveSpeed * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(0, 0, -1 * moveSpeed * Time.deltaTime, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(0, 0, 1 * moveSpeed * Time.deltaTime, ForceMode.Impulse);
        }

        if (transform.position.y < 1.3)
        {
            transform.position = startPoint.position;
            rigidbody.velocity = Vector3.zero;
        }

        if (Input.GetKeyDown("space") && GetComponent<Rigidbody>().transform.position.y <= 1.58f)
        {
            Vector3 jump = new Vector3(0.0f, 50.0f, 0.0f);

            GetComponent<Rigidbody>().AddForce(jump);
        }


    }
}
