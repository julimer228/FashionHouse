using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerMovemenInUnity : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 3f;


    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 forward = Camera.main.transform.forward;
        forward.y = 0;

        Vector3 move = Camera.main.transform.right * x + forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
}
