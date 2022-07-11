using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinChecker : MonoBehaviour
{
    [SerializeField] private Tower _tower;
    [SerializeField] private messageBox _messageBox;
    private void OnEnable()
    {
        _tower.SizeUpdated += OnSizeUpdated;
    }
    private void OnDisable()
    {
        _tower.SizeUpdated -= OnSizeUpdated;
    }
    private void OnSizeUpdated(int size)
    {
        if (size == 0)
        {
            _messageBox.gameObject.SetActive(true);
            this.enabled = false;
        }
    }
}
