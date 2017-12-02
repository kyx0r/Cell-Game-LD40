using UnityEngine;


public class BloodCell : MonoBehaviour
{
    private Vector2 direction;
    private Rigidbody2D _rb2d;
    private float speed;
    private Vector2 travelVec;



    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        speed = GenerateSpeed();
        direction = GenerateDirection();
        travelVec = new Vector2(direction.x * speed, direction.y * speed);
    }

    private Vector2 GenerateDirection()
    {
        //Generate X
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);

        return new Vector2(x, y);
    }

    private float GenerateSpeed()
    {
        //Generate a random speed for blood cell
        float spd = Random.Range(3f, 11f);

        return spd;
    }

    private void TravelInDirection()
    {
        _rb2d.velocity = travelVec;
    }

    private void Update()
    {
        TravelInDirection();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Boundary"))
        {
            Debug.Log("Blood Cell Exited game world");
            Destroy(gameObject);
        }
    }
}
