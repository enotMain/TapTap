using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleTypeManager : MonoBehaviour
{
    [SerializeField] private GameObject _circle;
    private List<CircleTypeChange> _circles = new();
    private int _previousCircleSideIndex;
    private int _currentCircleSideIndex;

    private void Start()
    {
        GetCircleTypeChangeChildrenList(_circle.transform, _circles);
        //Debug.Log(_circles.Count);
        _currentCircleSideIndex = Random.Range(0, _circles.Count);
        _circles[_currentCircleSideIndex].TurnOn();
    }

    private void Update()
    {
        if (!_circles[_currentCircleSideIndex]._isOn) // Must work on this
        {
            _circles[_currentCircleSideIndex].TurnOff();
            _previousCircleSideIndex = _currentCircleSideIndex;
            while (_currentCircleSideIndex == _previousCircleSideIndex)
            {
                _currentCircleSideIndex = Random.Range(0, _circles.Count);
            }
            _circles[_currentCircleSideIndex].TurnOn();
        }
    }

    private void GetCircleTypeChangeChildrenList(Transform circle, List<CircleTypeChange> circles)
    {
        foreach (Transform circleChild in circle)
        {
            if (circleChild.TryGetComponent(out CircleTypeChange circleTemp))
            {
                circles.Add(circleTemp);
            }
            else
            {
                GetCircleTypeChangeChildrenList(circleChild, circles);
            }
        }
    }
}
