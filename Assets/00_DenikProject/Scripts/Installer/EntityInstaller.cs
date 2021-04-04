using DenikProject.DQEmulation.Model;
using UnityEngine;
using Zenject;

namespace DenikProject.DQEmulation.Installer
{
    [CreateAssetMenu(fileName = "EntityInstaller", menuName = "Installers/EntityInstaller")]
    public class EntityInstaller : ScriptableObjectInstaller<EntityInstaller>
    {
        [SerializeField]
        private PlayerEntity _playerEntity = default;
        [SerializeField]
        private EnemyEntity _enemyEntity = default;

        public override void InstallBindings()
        {
            Container.Bind<PlayerEntity>().FromInstance(_playerEntity).AsCached();
            Container.Bind<EnemyEntity>().FromInstance(_enemyEntity).AsCached();
        }
    }
}