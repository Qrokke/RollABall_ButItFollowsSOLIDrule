using UnityEngine;
using Zenject;
/// <summary>
/// Itemを作成するためのファクトリクラスです。
/// 実装はZenjectがやってくれます
/// </summary>
namespace Item
{
    internal class ItemFactory : PlaceholderFactory<Vector3, ICollectable> { }
}
