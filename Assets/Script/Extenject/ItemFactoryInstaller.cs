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
        //ICreatorが要求されたときにItemFactoryを作って注入する。
        Container
            .Bind<ICreatable>()
            .To<ItemFactory>()
            .AsCached();*/
    }
}
