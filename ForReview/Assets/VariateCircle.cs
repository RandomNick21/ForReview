using UnityEngine;

[RequireComponent(typeof(SpriteRenderer), typeof(Rigidbody2D))]
public class VariateCircle : MonoBehaviour
{
    [SerializeField] private int MinMass = 3;
    [SerializeField] private int MaxMass = 6;

    //Хотя может кэширование тут бессмысленно
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.mass = Random.Range(MinMass, MaxMass);
    }
}
