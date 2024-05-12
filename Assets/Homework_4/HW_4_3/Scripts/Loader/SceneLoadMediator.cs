namespace Homework_4.Homework_4_3
{
    public class SceneLoadMediator
    {
        private ISimpleSceneLoader _simpleSceneLoader;
        private ILevelLoader _levelLoader;

        public SceneLoadMediator(ISimpleSceneLoader simpleSceneLoader, ILevelLoader levelLoader)
        {
            _simpleSceneLoader = simpleSceneLoader;
            _levelLoader = levelLoader;
        }

        public void GoToGameplayScene(ModeLoadingData modeLoadingData)
        {
            _levelLoader.Load(modeLoadingData);
        }

        public void GoToModeSelectionMenu()
        {
            _simpleSceneLoader.Load(SceneID.ModeSelection);
        }
    }
}