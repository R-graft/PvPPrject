public class IdleState : State
{
    public IdleState(AnimateHandler animator, InputManager inputs, PlayerController controller)
    {
        _animator = animator;
        _input = inputs;
        _controller = controller;
    }

   public override void Enter()
    {
        _animator.PlayAnimation(AnimHashBase._hashIdle);
    }

    public override void Update()
    {
        if (_input.MoveRequest())
        {
            _controller.OnStateExit();
        }
    }
}
