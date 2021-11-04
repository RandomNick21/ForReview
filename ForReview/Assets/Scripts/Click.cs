using UnityEngine;
using System;

public class Click : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;

    private int _destroyedCircle;
    public static Action<int> OnClickCircle;
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(_camera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null && Input.GetMouseButtonDown(0))
        {
            ParticleSystem particle = Instantiate(_particleSystem, hit.collider.transform.position, Quaternion.identity);
            particle.Play();

            Destroy(hit.collider.gameObject);
            _destroyedCircle++;
            OnClickCircle?.Invoke(_destroyedCircle);

            if (_destroyedCircle > PlayerPrefs.GetInt("BestDestroyedScore", 0))
            {
                PlayerPrefs.SetInt("BestDestroyedScore", _destroyedCircle);
            }
        }

    }
}
