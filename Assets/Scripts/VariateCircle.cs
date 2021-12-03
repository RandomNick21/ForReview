using UnityEngine;

[RequireComponent(typeof(SpriteRenderer), typeof(Rigidbody2D))]
public class VariateCircle : MonoBehaviour
{
    [SerializeField] private int _minMass = 5;
    [SerializeField] private int _maxMass = 20;

    //Хотя может кэширование тут бессмысленно
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.mass = Random.Range(_minMass, _maxMass);
    }
}
