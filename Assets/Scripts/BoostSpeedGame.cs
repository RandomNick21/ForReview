using UnityEngine;

public class BoostSpeedGame : MonoBehaviour
{
    [SerializeField] private float _multiplierSpeed = 2;
    private float _time;

    private void Update()
    {
        _time += Time.deltaTime;
        Physics2D.gravity = new Vector2(0, -(_time / _multiplierSpeed + 10));
    }
}
