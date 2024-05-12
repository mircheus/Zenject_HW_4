using System;
using UnityEngine.SceneManagement;
using Zenject;

namespace Homework_4.Homework_4_3
{
    public class ZenjectSceneLoaderWrapper
    {
        private readonly ZenjectSceneLoader _zenjectSceneLoader;
    
        public ZenjectSceneLoaderWrapper(ZenjectSceneLoader zenjectSceneLoader)
        {
            _zenjectSceneLoader = zenjectSceneLoader;
        }

        public void Load(int sceneID, Action<DiContainer> action = null)
        {
            _zenjectSceneLoader.LoadScene(sceneID, LoadSceneMode.Single, container => action?.Invoke(container));
        }
    }
}

