using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Camera _playerCamera;
    [SerializeField] private PlayerMove _playerMove;
    [SerializeField] private Animator _playerAnimator;
    [SerializeField] private Transform _playerTransform;

    private AnimateHandler _animateHandler;
    private InputManager _inputs;
    private MouseLook _mouseLook;

    [HideInInspector]public StateMashine stateMashine;

    private void Awake()
    {
        _mouseLook = new MouseLook(_playerCamera, _playerTransform);

        stateMashine = new StateMashine();

        _inputs = new InputManager();

        _animateHandler = new AnimateHandler(_playerAnimator);

        _animateHandler.Init();
    }

    private void Start()
    {
        stateMashine.Init(new IdleState(_animateHandler, _inputs, this));

        _inputs.OnInputJerk += ()=> stateMashine.ChangeState(new JerkState(_animateHandler, _playerMove, this));
    }
    private void Update()
    {
        _inputs.GetInputs();

        _mouseLook.FollowMouse();

        stateMashine.CurrentState.Update();
    }

    private void FixedUpdate()
    {
        stateMashine.CurrentState.FixedUpdate();
    }

    public void OnStateExit()
    {
        if (_inputs.MoveRequest())
        {
            stateMashine.ChangeState(new RunState(_animateHandler, _playerMove, _inputs, this));
        }
        else
        {
            stateMashine.ChangeState(new IdleState(_animateHandler, _inputs, this));
        }
    }
}
