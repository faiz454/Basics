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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
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
           // moveplayer();

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    Jump();
            //}
        }
    }

    private void moveplayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
        Debug.LogError("Accelerate called  ===1" + movement);

    }

    public void Accelerate()
    {
        movement += 5f;
        Debug.LogError("Accelerate called===" + movement);
    }

    public void Brake()
    {
        movement = 0f;
        Debug.LogError("Brake called===" + movement);
    }
    public void RotateLeft()
    {
        transform.Rotate(0, 30f, 0);
    }

    public void RotateRight()
    {
        transform.Rotate(0, -30f, 0);
    }
    public void ContinMovement()
    {
        rb.transform.Translate(Vector3.forward * movement * Time.deltaTime,Space.World);
        
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    
}
