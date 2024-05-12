using System;

namespace Examples.Loader
{
    public class SceneLoader : ISimpleSceneLoader, ILevelLoader
    {
        private ZenjectSceneLoaderWrapper _zenjectSceneLoaderWrapper;
        
        public SceneLoader(ZenjectSceneLoaderWrapper zenjectSceneLoaderWrapper)
        {
            _zenjectSceneLoaderWrapper = zenjectSceneLoaderWrapper;
        }

        public void Load(LevelLoadingData levelLoadingData)
        {
            _zenjectSceneLoaderWrapper.Load((int)SceneID.GameplayLevel,
                container =>
                {
                    container.BindInstance(levelLoadingData).AsSingle();
                });
        }
        
        public void Load(SceneID sceneID)
        {
            if (sceneID == SceneID.GameplayLevel)
                throw new ArgumentException($"{SceneID.GameplayLevel} cannot be started without configuration loading, use ILevelLoader instead");
            
            _zenjectSceneLoaderWrapper.Load((int)sceneID);
        }
    }
}