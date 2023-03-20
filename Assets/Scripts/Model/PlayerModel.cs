using System.Collections.Generic;
using System.Linq;
using Model.Move;
using UniRx;
using UnityEngine;

namespace Model
{
    public class PlayerModel
    {
        private static GameObject _pivotTransform = GameObject.Find("Player");

        private readonly ReactiveProperty<int> _count = new ReactiveProperty<int>();
        public IReadOnlyReactiveProperty<int> Count => _count;

        private List<MoveCommand> _moveCommands = new List<MoveCommand>();

        public void StepGo()
        {
            CountUp();
        }

        public void StepUndoGo()
        {
            CountDown();
        }
    
        public void CountUp()
        {
            _count.Value += 1;
        }

        public void CountDown()
        {
            _count.Value -= 1;
        }
    }
}
