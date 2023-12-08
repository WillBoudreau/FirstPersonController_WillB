using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField]  private CharacterController controller;
    [SerializeField]  private float speed = 12f;
    [SerializeField]  private float gravity = -9.81f;
                     Vector3 velocity;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move);
        
        velocity.y += gravity * Time.deltaTime;

        controller.Move(gravity * Time.deltaTime);
    }
}
