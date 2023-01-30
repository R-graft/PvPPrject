using System;
using UnityEngine;

public class InputManager
{
    public float _inputSide;
    public float _inputForward;

    private const KeyCode JerkKey = KeyCode.Mouse1;

    public Action OnInputJerk;

    public void GetInputs()
    {
        _inputSide = Input.GetAxis("Horizontal");

        _inputForward = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(JerkKey))
        {
            OnInputJerk?.Invoke();
        }
    }

    public bool MoveRequest()
    {
        if (_inputSide != 0 || _inputForward != 0)
            return true;

        return false;
    }
}
