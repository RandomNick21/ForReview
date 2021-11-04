using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateStateUI : MonoBehaviour
{
    [SerializeField] private GameObject _uiForWin;
    [SerializeField] private GameObject _uiForLose;

    private void OnEnable()
    {
        WinLose.OnWin += Win;
        WinLose.OnLose += Lose;
    }
    private void OnDisable()
    {
        WinLose.OnWin -= Win;
        WinLose.OnLose -= Lose;
    }
    private void Win()
    {
        _uiForWin.SetActive(true);
    }
    private void Lose()
    {
        _uiForLose.SetActive(true);
    }
}
