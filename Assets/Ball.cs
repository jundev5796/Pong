using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody2D _rigidbody;

    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        Launch();
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        _rigidbody.velocity = new Vector2(x * _speed, y * _speed);
    }

    public void Reset()
    {
        _rigidbody.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        Launch();
    }
}
