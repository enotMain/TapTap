using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleClick : MonoBehaviour
{
    private CircleTypeChange _circleTypeChange;

    private void Awake()
    {
        _circleTypeChange = GetComponent<CircleTypeChange>();
    }

    private void OnMouseDown()
    {
        if (_circleTypeChange._isOn)
        {
            ScoreEventManager.SendCircleClickedRight();
            _circleTypeChange.TurnOff();
        }
        else
        {
            ScoreEventManager.SendCircleClickedWrong();
        }
    }
}
