using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

/// <summary>
/// スタート時、FactoryにItem作らせるためのメソッド
/// </summary>
public class OnStartCreate : MonoBehaviour
{
    [Inject]
    private ItemFactory _itemFactory;

    private int _itemAmount = 12;
    private float _itemScatter = 8f;

    void Start()
    {
        for (int i = 0; i < _itemAmount; i++)
        {
            //円形に並べてみる。
            float itemPositionX = _itemScatter * Mathf.Cos(Mathf.PI / (_itemAmount / 2f) * i);
            float itemPositionZ = _itemScatter * Mathf.Sin(Mathf.PI / (_itemAmount / 2f) * i);
            Vector3 itemPosition = new Vector3(itemPositionX, 0f, itemPositionZ);

            //ZenjectでItemとFactoryを紐づけているので出現場所を送るだけでよい
            _itemFactory.Create(itemPosition);
        }
    }


}
