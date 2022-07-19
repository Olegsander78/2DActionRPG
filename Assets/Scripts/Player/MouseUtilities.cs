using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseUtilities : MonoBehaviour
{
    private Camera _cam;

    private void Awake()
    {
        _cam = Camera.main;
    }

    public Vector2 GetMouseDirection(Vector2 origin)
    {
        Vector2 mouseScreenPos = Mouse.current.position.ReadValue();
        Vector2 mouseWorldPos = _cam.ScreenToWorldPoint(mouseScreenPos);

        return mouseWorldPos - origin;
    }
}
