using UnityEngine;
using TMPro;

public class DisplayData : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _destroyed;
    [SerializeField] private TextMeshProUGUI _skipped;

    private void OnEnable()
    {
        DestroyCircle.OnSkippedCircle += UpdateText;
        Click.OnClickCircle += UpdateTextDestroyed;
    }
    private void OnDestroy()
    {
        DestroyCircle.OnSkippedCircle -= UpdateText;
        Click.OnClickCircle -= UpdateTextDestroyed;
    }
    private void UpdateTextDestroyed(int destroyedCircle)
    {
        _destroyed.text = "Уничтожено: " + destroyedCircle.ToString();
    }
    private void UpdateText(int skippedCircle)
    {
        _skipped.text = "Пропущено: " + skippedCircle.ToString();
    }
}
