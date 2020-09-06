using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satellite : MonoBehaviour
{
    [SerializeField]
    private int _hits= 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    //Know when hit
    //Take away hit point per hit
    //Destory after 3 hits.

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Laser")
        {
            HitPoints();
            Destroy(other.gameObject);

            if (_hits < 1)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public void HitPoints()
    {
        _hits--;
    }

}
