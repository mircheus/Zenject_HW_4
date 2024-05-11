using UnityEngine;
using Zenject;

namespace Homework_4.Homework_4_2
{
    public class GameplayMediatorInstaller : MonoInstaller
    {
        [SerializeField] private DefeatPanel _defeatPanel;
        
        public override void InstallBindings()
        {
            Container.Bind<GameplayMediator>().AsSingle();
            Container.Bind<Level>().AsSingle();
            Container.BindInstance(_defeatPanel).AsSingle();
        }
    }
}