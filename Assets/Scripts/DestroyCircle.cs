using UnityEngine;
using System;

public class DestroyCircle : MonoBehaviour
{
    [SerializeField] private int _skippedCircle;

    public static Action<int> OnSkippedCircle;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        _skippedCircle++;
        OnSkippedCircle?.Invoke(_skippedCircle);
    }
}
