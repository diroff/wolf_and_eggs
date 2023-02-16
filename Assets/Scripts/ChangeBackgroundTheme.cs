using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackgroundTheme : MonoBehaviour
{
    [SerializeField] private Color _whiteThemeColor;
    [SerializeField] private Color _blackThemeColor;

    private Camera _mainCamera;

    private void Start()
    {
        _mainCamera = Camera.main;
        _mainCamera.backgroundColor = _whiteThemeColor;
    }

    public void ChangeColor()
    {
        if (_mainCamera.backgroundColor == _whiteThemeColor)
            _mainCamera.backgroundColor = _blackThemeColor;
        else if (_mainCamera.backgroundColor == _blackThemeColor)
            _mainCamera.backgroundColor = _whiteThemeColor;
    }
}
