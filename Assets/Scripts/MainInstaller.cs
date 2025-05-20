using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class MainInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //—цены ебез аддитивности 
        //if (FindObjectsOfType<MainInstaller>().Length > 0)
        //{
        //    Destroy(gameObject);
        //    return;
        //}

        //base.InstallBindings();
        Container.Bind<SingleController>().AsSingle();
        Container.BindInterfacesTo<MultiplayerController>().AsSingle();    

        //DontDestroyOnLoad(gameObject);
    }
}

public class SingleController : IController { }

public class MultiplayerController : IController { }

public interface IController
{
}