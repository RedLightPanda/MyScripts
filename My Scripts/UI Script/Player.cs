using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxStress = 100;
    public int CurrentStress;
    public int maxHealth = 100;
    public int CurrentHealth;
   
    [SerializeField]
    public Stress_Bar stressBar;
   
    [SerializeField]
    public Health_Bar healthBar;
    
    [SerializeField]
    private float _speed = 3.5f;

    [SerializeField]
    private GameObject _laserPrefab;

    [SerializeField]
    private float _fireRate = 0.5f;
   
    private float _canFire = -1f;

    //private float X_Min = -8f, X_Max = 8f;

    void Start()
    {
        StressSystem();
        HealthSystem();
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _canFire)
        {
            FireLaser();
        }
    }


    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction * _speed * Time.deltaTime);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8f, 8f), Mathf.Clamp(transform.position.y, -3.5f, 5f), 0);

    }   
    void FireLaser()
    {
        _canFire = Time.time + _fireRate;
        Instantiate(_laserPrefab, transform.position + new Vector3(0, 0, 1f), Quaternion.identity);
    }


    //When player gets hit player takes damage.
    //If HP is zero Player dies.

    void StressSystem()
    {
        CurrentStress = 0;
        //stressBar.SetStress(CurrentStress);
    }

    void HealthSystem()
    {
        CurrentHealth = 100;
        //healthBar.SetHealth(CurrentHealth);
    }

}
