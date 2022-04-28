using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CircleTypeChange : MonoBehaviour
{
    [SerializeField] private Sprite _spriteTypeOn;
    [SerializeField] private Sprite _spriteTypeOff;
    private SpriteRenderer _spriteRenderer;
    [HideInInspector] public bool _isOn = false;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TurnOn()
    {
        _spriteRenderer.sprite = _spriteTypeOn;
        _isOn = true;
    }

    public void TurnOff()
    {
        _spriteRenderer.sprite = _spriteTypeOff;
        _isOn = false;
    }
}
