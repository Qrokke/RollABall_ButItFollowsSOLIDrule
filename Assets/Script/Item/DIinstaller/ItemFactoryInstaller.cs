using UnityEngine;
using Zenject;
using Item;

/// <summary>
/// Itemの生成方法はZenjectによって作成される。
/// </summary>
public class ItemFactoryInstaller : MonoInstaller
{
    [SerializeField] private GameObject _itemPrefab;
    public override void InstallBindings()
    {
        Container
            .BindFactory<Vector3, ICollectable, ItemFactory>()
            .To<CollectableItem>()
            .FromComponentInNewPrefab(_itemPrefab);
    }
}
