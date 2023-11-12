using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ItemFactoryInstaller : MonoInstaller
{
    [SerializeField] private GameObject _itemPrefab;
    public override void InstallBindings()
    {
        Container
            .BindFactory<Vector3,Item, ItemFactory> ()
            .FromComponentInNewPrefab(_itemPrefab);
        /*
        //ICreator‚ª—v‹‚³‚ê‚½‚Æ‚«‚ÉItemFactory‚ğì‚Á‚Ä’“ü‚·‚éB
        Container
            .Bind<ICreatable>()
            .To<ItemFactory>()
            .AsCached();*/
    }
}
