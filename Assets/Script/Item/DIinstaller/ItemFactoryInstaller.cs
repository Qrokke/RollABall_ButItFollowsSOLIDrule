using UnityEngine;
using Zenject;
using Item;

/// <summary>
/// Item‚Ì¶¬•û–@‚ÍZenject‚É‚æ‚Á‚Äì¬‚³‚ê‚éB
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
