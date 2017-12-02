using UnityEngine;


public class BloodCell : MonoBehaviour
{
    private Vector2 direction;
    private Rigidbody2D _rb2d;

    [Range(3f, 11f)]
    public float speed = 6f;


    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private float GenerateDirection()
    {
        //Generate Z rotation, degrees
        float z = Random.Range(0f, 360f);

        return z;
    }

    private float GenerateSpeed()
    {
        //Generate a random speed for blood cell
        float spd = Random.Range(3f, 11f);

        return spd;
    }

    private void TravelInDirection()
    {
        float randDirection = GenerateDirection();
        float randSpeed = GenerateSpeed();
        
        
    }
}
