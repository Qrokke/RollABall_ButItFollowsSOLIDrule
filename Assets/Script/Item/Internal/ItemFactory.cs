using UnityEngine;
using Zenject;
/// <summary>
/// Itemを作成するためのファクトリクラスです。
/// 実装はZenjectがやってくれます
/// </summary>
public class ItemFactory : PlaceholderFactory<Vector3,ICollectable>{}
