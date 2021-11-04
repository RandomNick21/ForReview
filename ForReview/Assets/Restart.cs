using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))]
public class Restart : MonoBehaviour
{
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }
    private void OnEnable()
    {
        _button.onClick.AddListener(RestartScene);
    }
    private void OnDisable()
    {
        _button.onClick.RemoveListener(RestartScene);
    }
    private void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
