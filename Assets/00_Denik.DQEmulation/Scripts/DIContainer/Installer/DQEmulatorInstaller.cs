using Denik.DQEmulation.Model;
using Denik.DQEmulation.Presenter;
using Denik.DQEmulation.Repository;
using Denik.DQEmulation.View;
using UnityEngine;
using Zenject;

namespace Denik.DQEmulation.Installer
{
    public class DQEmulatorInstaller : MonoInstaller
    {
        [SerializeField]
        private PlayerModel _playerModel = default;
        [SerializeField]
        private EnemyModel _enemyModel = default;
        [SerializeField]
        private PlayerView _playerView = default;
        [SerializeField]
        private EnemyView _enemyView = default;

        public override void InstallBindings()
        {
            // Resource Provider
            Container.Bind(typeof(EnemyResourceProvider)).AsCached();
            Container.Bind(typeof(PlayerResourceProvider)).AsCached();
            // 以下と同じ
            // Container.Bind<PlayerRepository>().AsCached();

            // Model
            Container.BindInterfacesAndSelfTo(typeof(EnemyModel)).FromInstance(_enemyModel).AsCached();
            Container.BindInterfacesAndSelfTo(typeof(PlayerModel)).FromInstance(_playerModel).AsCached();

            // View
            Container.BindInterfacesAndSelfTo(typeof(EnemyView)).FromInstance(_enemyView).AsCached();
            Container.BindInterfacesAndSelfTo(typeof(PlayerView)).FromInstance(_playerView).AsCached();

            // Presenter
            Container.Bind(typeof(DQEmulationPresenter), typeof(IInitializable))
                .To(typeof(DQEmulationPresenter))
                .AsCached();
        }
    }
}