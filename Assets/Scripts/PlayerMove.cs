using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //NONPHYSICAL MOVE
    [SerializeField] private Transform _playerTransform;

    [SerializeField] private float _moveSpeedForward;
    [SerializeField] private float _moveSpeedSide;

    [SerializeField] private float _jerkDistance;

     public readonly float _jerkTime = 0.8f;


    public void MoveF(float forwardValue)
    {
        _playerTransform.localPosition +=  forwardValue * _moveSpeedForward * _playerTransform.forward;
    }

    public void MoveS(float sideValue)
    {
        _playerTransform.localPosition +=  sideValue * _moveSpeedSide * _playerTransform.right;
    }

    public void Jerk()
    {
        _playerTransform.localPosition += _playerTransform.forward * _jerkDistance;
    }
}
