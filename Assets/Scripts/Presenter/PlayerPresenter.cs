using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Model;
using UniRx;
using View;
using Zenject;

public class PlayerPresenter: IInitializable, IDisposable
{
    private PlayerModel _playerModel;
    private PlayerView _playerView;
    
    private readonly CompositeDisposable compositeDisposable = new CompositeDisposable();
    
    public PlayerPresenter(PlayerModel playerModel, PlayerView playerView)
    {
        _playerModel = playerModel;
        _playerView = playerView;
    }
    
    void IInitializable.Initialize()
    {
        _playerView.OnCountUpButtonClickAsObservable()
                        .Subscribe(_ => _playerModel.StepGo())
                        .AddTo(compositeDisposable);
        
        _playerView.OnCountDownButtonClickAsObservable()
            .Subscribe(_ => _playerModel.StepUndoGo())
            .AddTo(compositeDisposable);
        
        _playerModel.Count
            .Subscribe(_playerView.UpdateCountLabel)
            .AddTo(compositeDisposable);
    }
    
    void IDisposable.Dispose()
    {
        compositeDisposable.Dispose();
    }
}
