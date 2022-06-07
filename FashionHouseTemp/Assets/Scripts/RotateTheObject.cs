using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTheObject : MonoBehaviour
{
    public void Rotate()
    {

        transform.eulerAngles += new Vector3(0, 45, 0);
    }
}
