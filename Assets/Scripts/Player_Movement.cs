using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float speed, movement;
    [SerializeField] private float JumpForce;
    public bool isGameStart = false;
    private Rigidbody rb;
    public float RotationSp;
    private bool turnLeft = false, turnRight = false;
    public AudioSource engineAudio;
    public float minPitch = 0.8f;
    public float maxPitch = 2.4f;
    public float topSpeed = 50f;
    public float pitchSmoothSpeed = 4f;
    private float targetPitch;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        if (engineAudio != null)
        {
            engineAudio.loop = true;
            engineAudio.pitch = minPitch;
            if (!engineAudio.isPlaying)
            {
                engineAudio.Play();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (engineAudio != null)
        {
            float speedRatio = Mathf.Clamp01(speed / topSpeed);
            targetPitch = Mathf.Lerp(minPitch, maxPitch, speedRatio);
            engineAudio.pitch = Mathf.Lerp(engineAudio.pitch, targetPitch, Time.deltaTime * pitchSmoothSpeed);
        }
        //restart game if goes out of the ground


        //if(Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    transform.Rotate(0, RotationSp * Time.deltaTime, 0);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))

        //{
        //    transform.Rotate(0, -RotationSp * Time.deltaTime, 0);
        //}
        //if (isGameStart)
        {
            ContinMovement();
            Rotate();
           // moveplayer();

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    Jump();
            //}
        }
    }

    private void moveplayer()
    {
        //float horizontalInput = Input.GetAxis("Horizontal");
        //Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * speed * Time.deltaTime;
        //transform.Translate(movement, Space.World);
        transform.position += transform.forward * speed* Time.deltaTime;
        Debug.LogError("Accelerate called  ===1" + movement);

    }

    public void Accelerate()
    {
        speed += 5f;
        if(speed > topSpeed) speed = topSpeed;
        Debug.LogError("Accelerate called===" + speed);
        Debug.Log("accelerate");
    }

    public void Brake()
    {
        speed -= 8f;                            // CHANGE from: movement = 0f;
        if (speed < 0f) speed = 0f;             // ADD clamp
        Debug.Log("Brake called===" + speed);
        //speed -= 8f;
        //if(speed < 0f) speed = 0f;
        //movement = 0f;
        //Debug.LogError("Brake called===" + movement);
    }
    public void Rotate()
    {
        if (turnRight)
        {
            transform.Rotate(0, RotationSp * Time.deltaTime, 0);
        }
        if (turnLeft)
        {
            transform.Rotate(0, -RotationSp * Time.deltaTime, 0);
        }
    }
    //public void RotateLeft()
    //{
    //    transform.Rotate(0, -30f, 0);
    //}

    //public void RotateRight()
    //{
    //    transform.Rotate(0, 30f, 0);
    //}
    public void ContinMovement()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        // rb.transform.Translate(Vector3.forward * movement * Time.deltaTime,Space.World);

    }

    public void Start_turnRight()
    {
        turnRight = true;
    }
    public void Start_turnLeft()
    {
        turnLeft = true;
    }
    public void Stop_turnRight()
    {
        turnRight = false;
    }
    public void Stop_turnLeft()
    {
        turnLeft = false;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    
}
