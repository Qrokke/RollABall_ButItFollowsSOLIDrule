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
    private ICreatable _iCreatable;
    private int _itemAmount = 12;

    void Start()
    {
        for (int i = 0; i < _itemAmount; i++)
        {
            float itemPositionX = Mathf.Cos(Mathf.PI / (_itemAmount / 2f) * i);
            float itemPositionZ = Mathf.Sin(Mathf.PI / (_itemAmount / 2f) * i);
            Vector3 itemPosition = new Vector3(itemPositionX, 0f, itemPositionZ);
            _iCreatable.Create(itemPosition);
        }
    }


}
