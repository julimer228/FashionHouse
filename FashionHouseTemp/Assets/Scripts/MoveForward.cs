using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float Speed = 3;

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Vector3 forward = Camera.main.transform.forward;
            forward.y = 0;
            this.transform.position += forward * Speed * Time.deltaTime;
        }
    }
}
