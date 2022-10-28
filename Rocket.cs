using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rb;
    int rotating;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rotating = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
            rotating--;
        if (Input.GetKey(KeyCode.RightArrow))
            rotating++;
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity += transform.up * 0.5f;
        }
        // https://docs.unity3d.com/ScriptReference/Rigidbody.AddRelativeTorque.html
        rb.AddRelativeTorque(new Vector3(0, 0, rotating * 10 * -1));
    }
}
