using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePoint : MonoBehaviour
{
    [SerializeField]
    private GameController _gameController;

    private void OnTriggerEnter(Collider other)
    {
        var bullet = other.GetComponent<Bullet>();

        if (bullet != null)
        {
            var rb = bullet.GetComponent<Rigidbody>();
            var velocity = rb.velocity;
            if (velocity.magnitude >= 5f)
            {
                Debug.Log($"Damage {velocity.magnitude}");
                _gameController.AddEnemyScore();
            }
        }
    }
}
