using UnityEngine;
using System;

public class Click : MonoBehaviour
{
    private int _destroyedCircle;
    public static Action<int> OnClickCircle;

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null && Input.GetMouseButtonDown(0))
        {
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
