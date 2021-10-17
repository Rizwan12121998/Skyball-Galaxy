using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyJoystick;

public class BallMotor : MonoBehaviour
{

    public float moveSpeed = 5.0f;
    public float drag = 0.5f;
    public float terminalRotationSpeed = 25.0f;
    public Vector3 MoveVector { set; get; }
    public Joystick joystick;
    public AudioSource tickSource;

    private Rigidbody thisRigidbody;

    // Start is called before the first frame update
    private void Start()
    {
        thisRigidbody = gameObject.AddComponent<Rigidbody>();
        thisRigidbody.maxAngularVelocity = terminalRotationSpeed;
        thisRigidbody.drag = drag;
        tickSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()
    {
        MoveVector = PoolInput();

        Move();
    }

    private void Move()
    {
        thisRigidbody.AddForce((MoveVector * moveSpeed));
    }

    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            tickSource.Play();
        }
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
