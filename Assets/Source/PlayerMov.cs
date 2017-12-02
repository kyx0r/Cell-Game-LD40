using UnityEngine;


public class PlayerMov : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private float _speed = 8f;


    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
            _rb2d.velocity += Vector2.up * _speed;

        if (Input.GetKey(KeyCode.A))
            _rb2d.velocity += Vector2.left * _speed;

        if (Input.GetKey(KeyCode.S))
            _rb2d.velocity += Vector2.down * _speed;

        if (Input.GetKey(KeyCode.D))
            _rb2d.velocity += Vector2.right * _speed;
    }

    private void LimitSpeed()
    {
        if (_rb2d.velocity.x >= _speed || _rb2d.velocity.y >= _speed)
        {
            _rb2d.velocity = new Vector2(_speed, _speed);
        }
    }
}
