using UnityEngine;

public class AnimateHandler
{
    private Animator _animator;

    private AnimHashBase _animatorHash;
    
    private const float fadeTime = 0.1f;

    public AnimateHandler(Animator animator)
    {
        _animator = animator;
    }

    public void Init()
    {
        _animatorHash = new AnimHashBase();

        _animatorHash.SetCurrentHashes();
    }

    public void PlayAnimation(int animHash)
    { 
        _animator.CrossFade(animHash, fadeTime);
    }    

    public void Stop()
    {
        _animator.StopPlayback();
    }
}
