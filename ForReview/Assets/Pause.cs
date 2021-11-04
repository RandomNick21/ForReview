using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private Button _button;
    private bool _score;

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
        if(!_score)
        {
            Time.timeScale = 0;
            _score = true;
        }
        else
        {
            Time.timeScale = 1;
            _score = false;
        }
    }
}
