using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rigidbody;

    [SerializeField]
    private float _speed = 5f;

    private float _livetime;
    private float _livetimeLimit = 500f;

    void Start()
    {
        _rigidbody.AddForce(transform.forward * _speed, ForceMode.Force);
    }

    private void FixedUpdate()
    {
        _livetime++;
        if (_livetime >= _livetimeLimit)
        {
            Destroy(gameObject);
        }

        if (transform.position.y <= -5.0f)
        {
            Destroy(gameObject);
        }
    }
}
