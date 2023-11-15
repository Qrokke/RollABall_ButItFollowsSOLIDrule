using UnityEngine;
using Zenject;
using Item;

/// <summary>
/// Item�̐������@��Zenject�ɂ���č쐬�����B
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
