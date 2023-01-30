using UnityEngine;

public class AnimHashBase : MonoBehaviour
{
    public static int _hashIdle;
    public static int _hashRunF;
    public static int _hashRunB;
    public static int _hashRunL;
    public static int _hashRunR;
    public static int _hashJerk;

    private int GetHash(string name)
    {
        return Animator.StringToHash(name);
    }

    public void SetCurrentHashes()
    {
        _hashIdle = GetHash("idle");
        _hashRunF = GetHash("runF");
        _hashRunB = GetHash("runB");
        _hashRunL = GetHash("runL");
        _hashRunR = GetHash("runR");
        _hashJerk = GetHash("jerk");
    }
}
