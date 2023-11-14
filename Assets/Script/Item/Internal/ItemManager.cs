using UnityEngine;
using Zenject;
using UniRx;

/// <summary>
/// スタート時、ファクトリとアイテムを利用するための上位クラス
/// アイテムの配置を行うためだけにある
/// </summary>
public class ItemManager
{
    //現在の取得アイテム数
    public ReactiveProperty<int> CurrentGotItemAmount = new ReactiveProperty<int>(0);
    //Zenjectにより注入
    [Inject]
    private ItemFactory _itemFactory;

    private ICollectable[] _iitems;
    private int _itemAmount = 12;
    private float _itemScatter = 8f;

    private Vector3 _generatePosition;

    public ItemManager(int ItemAmount, Vector3 position, ItemFactory itemFactory)
    {
        _itemAmount = ItemAmount;
        _generatePosition = position;
        _itemFactory = itemFactory;
        Debug.Log($"_itemFactory: {_itemFactory}");
    }

    public void CreateItems()
    {
        if(_itemFactory == null)
        {
            return;
        }
        _iitems = new ICollectable[_itemAmount];

        for (int i = 0; i < _itemAmount; i++)
        {
            Vector3 itemPosition = itemPositionVectorByOrder(i);

            //ZenjectでIItemとFactoryを紐づけているので出現場所を送るだけでよい
            //生成処理
            ICollectable item = _itemFactory.Create(itemPosition);

            _iitems[i] = item;

            _iitems[i].CollectedSubject.Subscribe(_ => {
                CurrentGotItemAmount.Value++;
            });
        }
    }

    private Vector3 itemPositionVectorByOrder(int order) {

        //円形に並べてみる。
        float itemPositionX = _itemScatter * Mathf.Cos(Mathf.PI / (_itemAmount / 2f) * order);
        float itemPositionZ = _itemScatter * Mathf.Sin(Mathf.PI / (_itemAmount / 2f) * order);

        //生成位置
        Vector3 returnPosition = new Vector3(itemPositionX, 0f, itemPositionZ);
        //初期位置をオブジェクトの量だけ移動
        returnPosition += _generatePosition;

        return returnPosition;
    
    }


}
