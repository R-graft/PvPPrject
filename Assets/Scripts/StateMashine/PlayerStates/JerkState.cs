public class JerkState : State
{
    private float _jerkLength;

    private const float _jerkTimeScale = 0.02f;
    public JerkState(AnimateHandler animator, PlayerMove move, PlayerController controller)
    {
        _animator = animator;
        _move = move;
        _controller = controller;
    }

    public override void Enter()
    {
        _animator.PlayAnimation(AnimHashBase._hashJerk);

        _jerkLength = _move._jerkTime;
    }
    public override void FixedUpdate()
    {
        if (_jerkLength <= 0)
        {
            _controller.OnStateExit();
        }
        else
        {
            _move.Jerk();

            _jerkLength -= _jerkTimeScale;
        }
    }
}
