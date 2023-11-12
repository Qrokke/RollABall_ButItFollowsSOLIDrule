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
            .BindFactory<Vector3,IItem, ItemFactory> ()
            .To<Item>()
            .FromComponentInNewPrefab(_itemPrefab);
    }
}
