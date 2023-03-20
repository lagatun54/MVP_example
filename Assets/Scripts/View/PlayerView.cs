using System;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using UnityEngine.UI;

namespace View
{
    public sealed class PlayerView : MonoBehaviour
    {
        [SerializeField] Text countLabel;
        [SerializeField] Button countUpButton;
        [SerializeField] Button countDownButton;
        
        public IObservable<Unit> OnCountUpButtonClickAsObservable() => countUpButton.OnClickAsObservable();
        public IObservable<Unit> OnCountDownButtonClickAsObservable() => countDownButton.OnClickAsObservable();
        
        
        public void UpdateCountLabel(int count)
        {
            countLabel.text = $"Count: {count}";
        }
    }
}
