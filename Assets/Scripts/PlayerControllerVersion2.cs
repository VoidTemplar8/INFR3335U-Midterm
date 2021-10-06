using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerVersion2 : MonoBehaviour
{
    private CharacterController controller;

    private Vector3 moveDirection = Vector3.zero;

    public float moveSpeed = 2.0f;
    public float gravity = -30;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
        float AxisX = Input.GetAxis("Horizontal");
        float AxisZ = Input.GetAxis("Vertical");

        moveDirection = new Vector3(AxisX, 0, AxisZ);
        moveDirection *= moveSpeed;

        if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDirection), 0.20f);
        }

        moveDirection.y = gravity;

        controller.Move(moveDirection * Time.deltaTime);


    }


}
