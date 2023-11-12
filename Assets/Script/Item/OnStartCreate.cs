using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

/// <summary>
/// スタート時、Factoryにもの作らせる
/// </summary>
public class OnStartCreate : MonoBehaviour
{
    [Inject]
    private ItemFactory _itemFactory;
    private List<ICollectable> _items;

    private int _itemAmount = 12;
    private float _itemScatter = 8f;

    void Start()
    {
        for (int i = 0; i < _itemAmount; i++)
        {
            float itemPositionX = _itemScatter * Mathf.Cos(Mathf.PI / (_itemAmount / 2f) * i);
            float itemPositionZ = _itemScatter * Mathf.Sin(Mathf.PI / (_itemAmount / 2f) * i);
            Vector3 itemPosition = new Vector3(itemPositionX, 0f, itemPositionZ);

            _itemFactory.Create(itemPosition);
        }
    }


}
