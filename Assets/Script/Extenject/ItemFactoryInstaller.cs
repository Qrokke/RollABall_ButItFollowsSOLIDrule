using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ItemFactoryInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //ICreator���v�����ꂽ�Ƃ���ItemFactory������Ē�������B
        Container
            .Bind<ICreatable>()
            .To<ItemFactory>()
            .AsCached();
    }
}
