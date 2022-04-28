using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour
{
    [SerializeField] private GameObject _circle;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _changeDirectionChance;
    [SerializeField] private float _timeToCheckIfChangeRotationDirection;
    private float _direction = 1f;
    private float _timeCount = 0f;

    private void Update()
    {
        if (CheckIfChangeRotationDirection(
            ref _timeCount,
            _changeDirectionChance,
            _timeToCheckIfChangeRotationDirection))
        {
            ChangeRotationDirection(ref _direction);
        }
        RotateGO(_circle, _direction * _rotationSpeed);
    }

    private void RotateGO(GameObject gameObject, float rotationSpeed)
    {
        gameObject.transform.Rotate(new Vector3(0, 0, rotationSpeed * Time.deltaTime));
    }

    private bool CheckIfChangeRotationDirection(
        ref float _timeCount, 
        float changeDirectionChance,
        float timeToCheckIfChangeRotationDirection)
    {
        _timeCount += Time.deltaTime;
        if (_timeCount > timeToCheckIfChangeRotationDirection)
        {
            _timeCount = 0f;
            if (Random.Range(0f, 1f) < changeDirectionChance) return true;
            else return false;
        }
        else return false;
    }

    private void ChangeRotationDirection(ref float direction)
    {
        direction *= -1f;
    }
}
