using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyJoystick;
using UnityEngine.SceneManagement;

public class BallMotor : MonoBehaviour
{

    public float moveSpeed = 5.0f;
    public float drag = 0.5f;
    public float terminalRotationSpeed = 25.0f;
    public Vector3 MoveVector { set; get; }
    public Joystick joystick;

    //for jumping
    public float jumpSpeed = 3f;
    public float jumpDelay = 2f;
    private bool canjump;
    private bool isjumping;
    private float countDown;

    private Rigidbody thisRigidbody;

    // Start is called before the first frame update
    private void Start()
    {
        thisRigidbody = gameObject.AddComponent<Rigidbody>();
        thisRigidbody.maxAngularVelocity = terminalRotationSpeed;
        thisRigidbody.drag = drag;
        //for jumping
        canjump = true;
        countDown = jumpDelay;


    }


    // Update is called once per frame
    private void Update()
    {
        MoveVector = PoolInput();
        Move();

        //for jumping
        if (isjumping && countDown > 0)
            countDown -= Time.deltaTime;
        else
        {
            canjump = true;
            isjumping = false;
            countDown = jumpDelay;
        }

    }

    public void StartLetsJump()
    {
        if (canjump)
        {
            canjump = false;
            isjumping = true;
            thisRigidbody.AddForce(0, jumpSpeed, 0, ForceMode.Impulse);
        }
    }

    private void Move()
    {
        thisRigidbody.AddForce((MoveVector * moveSpeed));
    }


    private Vector3 PoolInput()
    {
        Vector3 dir = Vector3.zero;

        dir.x = joystick.Horizontal();
        dir.z = joystick.Vertical();


        if (dir.magnitude > 1)
            dir.Normalize();
        return dir;

    }


}
