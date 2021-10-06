using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 direction;
    public float playerSpeed = 2.0f;
    public float gravity = -10f;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        direction *= playerSpeed;

        if (direction != Vector3.zero)
        {
             transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.20f);
        }

        direction.y = gravity * Time.deltaTime;

        controller.Move(direction * Time.deltaTime);
    }
}