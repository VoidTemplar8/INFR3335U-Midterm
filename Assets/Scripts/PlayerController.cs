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
      //  controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        direction *= playerSpeed;

        direction.y = gravity * Time.deltaTime;

        controller.Move(direction * Time.deltaTime);
    }
}
