using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllers : MonoBehaviour
{
    public Rigidbody RB;
    public float maxSpeed;
    public float forwardAccel = 8f, reverseAccel = 4f;
    private float speedInput;
    // Start is called before the first frame update
    void Start()
    {
        RB.transform.parent = null;   
    }

    // Update is called once per frame
    void Update()
    {
        speedInput = 0f;
        if(Input.GetAxis("Vertical") > 0);
        transform.position = RB.position;
    }

    void FixedUpdate()
    {
        RB.AddForce(new Vector3(0f, 0f, 28f));
    }
}
