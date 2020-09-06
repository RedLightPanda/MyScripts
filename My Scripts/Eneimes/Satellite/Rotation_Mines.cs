using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Mines : MonoBehaviour
{
    [SerializeField]
    float RotationSpeed = 1f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, RotationSpeed) * Time.deltaTime);
    }
}
