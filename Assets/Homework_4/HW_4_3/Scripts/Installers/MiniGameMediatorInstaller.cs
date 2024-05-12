using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace Homework_4.Homework_4_3
{
    public class MiniGameMediatorInstaller : MonoInstaller
    {
        [SerializeField] private WinMenu _winMenu;
        [SerializeField] private MiniGame _miniGame;
        
        public override void InstallBindings()
        {
            Container.Bind<MiniGameMediator>().AsSingle();
            Container.BindInstance(_miniGame).AsSingle();
            Container.BindInstance(_winMenu).AsSingle();
        }
    }
}
