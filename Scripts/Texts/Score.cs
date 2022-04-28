using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    private int _scoreNumber;

    private void Awake()
    {
        ScoreEventManager.OnCircleClickedRight.AddListener(AddScore);
        ScoreEventManager.OnCircleClickedRight.AddListener(SetScore);

        ScoreEventManager.OnCircleClickedWrong.AddListener(SubstractScore);
        ScoreEventManager.OnCircleClickedWrong.AddListener(SetScore);
    }

    private void Start()
    {
        _scoreNumber = 0;
    }

    private void SetScore()
    {
        _scoreText.text = "Score: " + _scoreNumber; 
    }

    private void AddScore()
    {
        _scoreNumber++;
    }

    private void SubstractScore()
    {
        _scoreNumber--;
    }
}
