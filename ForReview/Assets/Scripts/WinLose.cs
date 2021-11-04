using UnityEngine;
using System;

public class WinLose : MonoBehaviour
{
    [SerializeField] private int _scoreForWin;
    [SerializeField] private int _scoreForLose;

    //Или вместо статических событий лучше реализовать singleton?
    public static Action OnWin;
    public static Action OnLose;

    private void OnEnable()
    {
        DestroyCircle.OnSkippedCircle += CheckSkippedCircle;
        Click.OnClickCircle += CheckClickCircle;
    }
    private void OnDisable()
    {
        DestroyCircle.OnSkippedCircle -= CheckSkippedCircle;
        Click.OnClickCircle -= CheckClickCircle;
    }

    private void CheckSkippedCircle(int skipped)
    {
        if(skipped == _scoreForLose)
        {
            OnLose?.Invoke();
            Time.timeScale = 0;
        }
    }
    private void CheckClickCircle(int destroy)
    {
        if(destroy == _scoreForWin)
        {
            OnWin?.Invoke();
            Time.timeScale = 0;
        }
    }

}
