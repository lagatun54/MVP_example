using System;
using Model;
using UnityEngine;
using View;
using Zenject;

namespace Installer
{
    public class SceneInstaller: MonoInstaller
    {
        [SerializeField] private PlayerView _playerView;

        public override void InstallBindings()
        {
            Container.Bind<PlayerView>().FromInstance(_playerView).AsSingle();
            Container.Bind(typeof(IInitializable), typeof(IDisposable)).To<PlayerPresenter>().AsSingle();
            Container.Bind<PlayerModel>().AsSingle();
        }
    }
}