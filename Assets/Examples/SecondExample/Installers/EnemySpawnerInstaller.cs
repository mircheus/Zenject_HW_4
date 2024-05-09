using Zenject;

namespace Examples.SecondExample
{
    public class EnemySpawnerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<EnemyFactory>().AsSingle();
        }
    }
}