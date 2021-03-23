using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletStartPosition;

    private float _speed = 5;
    private Vector3 _direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");

        if (Input.GetMouseButton(0))
        {
            Fire();
        }
    }

    private void FixedUpdate()
    {
        var speed = _direction * _speed * Time.deltaTime;
        transform.Translate(speed);
    }

    private void Fire()
    {
        Instantiate(bullet, bulletStartPosition.position , Quaternion.identity);
    }
}
