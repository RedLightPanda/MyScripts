using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satelite_Movement : MonoBehaviour
{
    [SerializeField]
    public float _speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }
}
