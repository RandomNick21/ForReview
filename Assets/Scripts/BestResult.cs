using UnityEngine;
using TMPro;

public class BestResult : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _destroyedBest;

    private void Update()
    {
        _destroyedBest.text = "”ничтожено: " + PlayerPrefs.GetInt("BestDestroyedScore", 0).ToString();
    }
}
