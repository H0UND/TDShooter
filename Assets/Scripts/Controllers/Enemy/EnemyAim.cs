using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAim : MonoBehaviour
{
    [SerializeField]
    private EnemyController _enemy;

    private int _reloadTime = 30;

    [SerializeField]
    private int _reload = 30;

    private void OnTriggerStay(Collider other)
    {
        if (other.name != "Player")
        {
            return;
        }
        //Debug.Log(other.name);

        if (_reload >= _reloadTime)
        {
            _reload = 0;
            _enemy.Shoot();
            //Debug.Log("Shoot");
            return;
        }

        //Debug.Log("_reload");
        _reload++;
    }
}
