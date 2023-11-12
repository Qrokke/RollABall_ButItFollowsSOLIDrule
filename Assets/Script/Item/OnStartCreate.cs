using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

/// <summary>
/// �X�^�[�g���AFactory��Item��点�邽�߂̃��\�b�h
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
            //�~�`�ɕ��ׂĂ݂�B
            float itemPositionX = _itemScatter * Mathf.Cos(Mathf.PI / (_itemAmount / 2f) * i);
            float itemPositionZ = _itemScatter * Mathf.Sin(Mathf.PI / (_itemAmount / 2f) * i);
            Vector3 itemPosition = new Vector3(itemPositionX, 0f, itemPositionZ);

            //Zenject��Item��Factory��R�Â��Ă���̂ŏo���ꏊ�𑗂邾���ł悢
            _itemFactory.Create(itemPosition);
        }
    }


}
