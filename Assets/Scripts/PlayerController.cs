using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    
    [Header("Moving settings")]
    [SerializeField] private float moveSpeed;

    [SerializeField] private float turnSpeed;
    private Vector3 moveVector; 

    public void OnMove()
    {
        moveVector = Vector3.zero;
        
        if (Input.GetKey(KeyCode.A))
            moveVector += Vector3.left * moveSpeed;
        if (Input.GetKey(KeyCode.D))
            moveVector += Vector3.right * moveSpeed;
        if (Input.GetKey(KeyCode.W))
            moveVector += Vector3.forward * moveSpeed;
        if (Input.GetKey(KeyCode.S))
            moveVector += Vector3.back * moveSpeed;
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
    
    private void Update()
    {
        OnMove();
    }

    void FixedUpdate()
    {
        rb.AddForce(moveVector);
        RotateToVelocity(turnSpeed, moveVector);
    }
}
