using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;

    public CharacterController controller;
    public float gravity = -9.81f;
    private Vector3 v;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    private bool isGrounded;
    


    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && v.y < 0f) v.y = -2f;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move*speed*Time.deltaTime);
        v.y += gravity * Time.deltaTime;
        controller.Move(v*Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            UIManager.main.ToggleUIArt(true);//remnove arguments alter
            UIManager.main.ToggleUIArt(true);
        }
        
    }
}
