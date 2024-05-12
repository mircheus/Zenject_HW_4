using System;

namespace Homework_4.Homework_4_3
{
    public class SceneLoader : ISimpleSceneLoader, ILevelLoader
    {
        private ZenjectSceneLoaderWrapper _zenjectSceneLoaderWrapper;
        
        public SceneLoader(ZenjectSceneLoaderWrapper zenjectSceneLoaderWrapper)
        {
            _zenjectSceneLoaderWrapper = zenjectSceneLoaderWrapper;
        }

        public void Load(ModeLoadingData modeLoadingData)
        {
            _zenjectSceneLoaderWrapper.Load(1, // TODO: Remove magic number
                container =>
                {
                    container.BindInstance(modeLoadingData).AsSingle();
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