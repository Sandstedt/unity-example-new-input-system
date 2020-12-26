using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    
    [Header("Moving settings")]
    public InputAction walkAction;
    [SerializeField] private float moveSpeed;

    [SerializeField] private float turnSpeed;
    private Vector3 moveVector;

    void OnEnable()
    {
        walkAction.Enable();
    }

    void OnDisable()
    {
        walkAction.Disable();
    }
    
    void Update()
    {
        moveVector = Vector3.zero;
        var moveDirection = walkAction.ReadValue<Vector2>();
        moveVector += new Vector3(moveDirection.x, 0f, moveDirection.y) * moveSpeed; // * Time.deltaTime
    }

    public void RotateToVelocity(float turnSpeed, Vector3 dir)
    {
        Quaternion slerp;

        if (dir.magnitude > 0.1)
        {
            dir.y = dir.y + (dir.magnitude * 0.2f); 
            Quaternion dirQ = Quaternion.LookRotation(dir);
            slerp = Quaternion.Slerp(rb.rotation, dirQ, turnSpeed * Time.deltaTime);
        }
        else
        {
            Quaternion upright = Quaternion.Euler(0, transform.eulerAngles.y, 0);
            slerp = Quaternion.Slerp(rb.rotation, upright, turnSpeed * Time.deltaTime);
        }
        rb.MoveRotation(slerp);
    }

    void FixedUpdate()
    {
        rb.AddForce(moveVector);
        RotateToVelocity(turnSpeed, moveVector);
    }
}
