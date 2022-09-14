using System;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private Transform _player;

    [SerializeField]
    private GameObject _bullet;

    [SerializeField]
    private GameObject _gun;

    [SerializeField]
    private GameObject _level;

    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();

        if (_agent == null)
        {
            return;
        }
        _agent.destination = _player.position;
    }

    internal void Shoot()
    {
        var position = new Vector3(
            _gun.transform.position.x,
            0.22f,
            _gun.transform.position.z);
        Instantiate(_bullet, position, transform.rotation, _level.transform);
    }

    private void FixedUpdate()
    {
        _agent.destination = _player.position;
        transform.LookAt(_player.position);
    }
}