using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class ScaleCircle : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.onValueChanged.AddListener(SaveValueSlider);
        _slider.value = PlayerPrefs.GetFloat("SliderValue", _slider.minValue);
    }

    private void Update()
    {
        VariateCircle[] clones = FindObjectsOfType(typeof(VariateCircle)) as VariateCircle[];
        foreach(var clone in clones)
        {
            clone.transform.localScale = new Vector2(_slider.value, _slider.value);
        }
    }
    private void SaveValueSlider(float value)
    {
        PlayerPrefs.SetFloat("SliderValue", value);
    }
}
