using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 7.0f;

    [SerializeField]
    private float _rotateSpeed = 3.0f;

    [SerializeField]
    private Rigidbody _rigidbody;

    [SerializeField]
    private GameObject _bullet;

    [SerializeField]
    private GameObject _level;

    [SerializeField]
    private GameObject _gun;

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_bullet, _gun.transform.position, transform.rotation, _level.transform);
        }
    }

    private void FixedUpdate()
    {
        WalkPlayer();
        RotatePlayer();

    }

    private void WalkPlayer()
    {
        var verticalAxis = Input.GetAxis("Vertical");
        _rigidbody.velocity = _speed * verticalAxis * transform.forward;
    }

    private void RotatePlayer()
    {
        var horisontalAxis = Input.GetAxis("Horizontal");
        transform.Rotate(0f, horisontalAxis * _rotateSpeed, 0f);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + transform.forward);
    }
}