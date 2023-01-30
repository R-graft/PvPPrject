public class RunState : State
{  
    public RunState(AnimateHandler animator, PlayerMove move, InputManager input, PlayerController controller)
    {
        _animator = animator;
        _move = move;
        _input = input;
        _controller = controller;
    }

    public override void Enter()
    {
        _animator.PlayAnimation(AnimHashBase._hashRunF);
    }

    public override void Update()
    {
        if (!_input.MoveRequest())
        {
            _controller.OnStateExit();
        }
    }
    public override void FixedUpdate()
    {
        _move.MoveF(_input._inputForward);

        _move.MoveS(_input._inputSide);
    }
}
