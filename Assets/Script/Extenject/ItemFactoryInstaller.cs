using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ItemFactoryInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //ICreatorが要求されたときにItemFactoryを作って注入する。
        Container
            .Bind<ICreatable>()
            .To<ItemFactory>()
            .AsCached();
    }
}
