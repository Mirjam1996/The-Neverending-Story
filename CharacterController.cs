using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float inputDelay = 0.1f;
    public float forwardVelocity = 14;
    public float rotateVelocity = 100;

    Quaternion targetRotation;
    Rigidbody rBody;
    float forwardInput, turnInput;

    public Quaternion TargetRotation
    {
        get { return targetRotation; }
    }

    void Start()
    {
        targetRotation = transform.rotation;
        if (GetComponent<Rigidbody>())
            rBody = GetComponent<Rigidbody>();
        else
            Debug.LogError("The character needs a rigidbody.");

        forwardInput = turnInput = 0;
    }

    void GetInput()
    {
        forwardInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
    }

    void Update()
    {
        GetInput();
        Turn();
        if (Input.GetKey(KeyCode.LeftShift))
        {
            forwardVelocity = 21;
        }
        else
            forwardVelocity = 12;
    }

    void FixedUpdate()
    {
        Run();
    }

    void Run()
    {
        if (Mathf.Abs(forwardInput) > inputDelay)
        {
            //move
            rBody.velocity = transform.forward * forwardInput * forwardVelocity;
        }
        else
        {
            //zero.Velocity
            rBody.velocity = Vector3.zero;
        }
    }

    void Turn()
    {
        targetRotation *= Quaternion.AngleAxis(rotateVelocity * turnInput * Time.deltaTime, Vector3.up);
        transform.rotation = targetRotation;

    }
}
