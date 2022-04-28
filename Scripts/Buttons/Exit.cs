using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Exit : MonoBehaviour
{
    [SerializeField] private Button _exit;

    private void Awake()
    {
        _exit.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        ExitApp();
    }

    private void ExitApp()
    {
        Application.Quit();
    }
}
