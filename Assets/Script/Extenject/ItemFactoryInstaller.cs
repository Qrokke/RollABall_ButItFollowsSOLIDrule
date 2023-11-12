using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ItemFactoryInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //ICreator‚ª—v‹‚³‚ê‚½‚Æ‚«‚ÉItemFactory‚ğì‚Á‚Ä’“ü‚·‚éB
        Container
            .Bind<ICreatable>()
            .To<ItemFactory>()
            .AsCached();
    }
}
