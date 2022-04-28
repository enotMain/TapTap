using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScoreEventManager : MonoBehaviour
{
    public static UnityEvent OnCircleClickedRight = new();
    public static UnityEvent OnCircleClickedWrong = new();

    public static void SendCircleClickedRight()
    {
        OnCircleClickedRight.Invoke();
    }

    public static void SendCircleClickedWrong()
    {
        OnCircleClickedWrong.Invoke();
    }
}
