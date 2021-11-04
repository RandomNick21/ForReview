using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private Button _button;
    private bool _state;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }
    private void OnEnable()
    {
        _button.onClick.AddListener(PauseGame);
    }
    private void OnDisable()
    {
        _button.onClick.RemoveListener(PauseGame);
    }
    private void PauseGame()
    {
        if(!_state)
        {
            Time.timeScale = 0;
            _state = true;
        }
        else
        {
            Time.timeScale = 1;
            _state = false;
        }
    }
}
