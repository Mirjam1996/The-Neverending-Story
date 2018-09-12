using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;
    public float lookSmooth = 0.09f;
    public Vector3 offsetFromTarget = new Vector3(0, 2, -4);
    public float xTilt = 15;
    public float zTilt = 10;

    Vector3 destination = Vector3.zero;
    CharacterController charController;

    float rotateVelocity = 0;

    void Start()
    {
        SetCameraTarget(target);
    }

    void SetCameraTarget(Transform t)
    {
        target = t;
        if (target != null)
        {
            if (target.GetComponent<CharacterController>())
            {
                charController = target.GetComponent<CharacterController>();
            }
            else
                Debug.LogError("The camera's target needs a character controller.");
        }
        else
            Debug.LogError("Your camera needs a target.");
    }


    void LateUpdate()
    {
        //moving & rotating
        MoveTotarget();
        LookAtTarget();
    }

    void MoveTotarget()
    {
        destination = charController.TargetRotation * offsetFromTarget;
        destination += target.position;
        transform.position = destination;

    }

    void LookAtTarget()
    {
        float eulerYAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, target.eulerAngles.y, ref rotateVelocity, lookSmooth);
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, eulerYAngle, 0);
    }
}
