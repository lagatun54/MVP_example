using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveCommand : MonoBehaviour
{
    protected Transform _transform;
    protected float _step = 100f;

    public MoveCommand(Transform transform, float step)
    {
        _transform = transform;
        _step = step;
    }
    
    public abstract void Execute();
    public abstract void Undo();
}
