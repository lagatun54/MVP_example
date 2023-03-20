using UnityEngine;

namespace Model.Move
{
    public class MoveStraightCommand : MoveCommand
    {
        public MoveStraightCommand(Transform transform, float step) : base(transform, step)
        {
        }

        public override void Execute()
        {
            transform.position += Vector3.forward * _step;
            Debug.Log("W key was pressed.");
        }

        public override void Undo()
        {
            transform.position += Vector3.back * _step;
            Debug.Log("S key was pressed.");
        }
    }
}