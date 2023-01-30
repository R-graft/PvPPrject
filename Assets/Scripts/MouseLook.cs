using UnityEngine;

public class MouseLook
{
    private Camera _mCamera;

    private Transform _mTransform;

    private const float MouseSensitivity = 2;

    private float _mousValueX;

    private float _mousValueY;

    public MouseLook(Camera camera, Transform transform)
    {
        _mCamera = camera;

        _mTransform = transform;
    }
    public void FollowMouse()
    {
        _mousValueX = Input.GetAxis("Mouse X") * MouseSensitivity;

        _mousValueY = Input.GetAxis("Mouse Y") * MouseSensitivity;

        _mTransform.localRotation = Quaternion.AngleAxis(_mTransform.localEulerAngles.y + _mousValueX, Vector3.up);

        _mCamera.transform.localRotation = Quaternion.AngleAxis(_mCamera.transform.localEulerAngles.x - _mousValueY, Vector3.right);
    }
}
