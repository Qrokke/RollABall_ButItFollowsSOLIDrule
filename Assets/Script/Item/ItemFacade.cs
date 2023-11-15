using UnityEngine;
using UniRx;
using Zenject;

/// <summary>
/// アイテムの処理を利用するためのファサード
/// </summary>

namespace Item
{
    public class ItemFacade : MonoBehaviour
    {
        public ReactiveProperty<int> CurrentGotItemAmount { get; private set; }
        [HideInInspector]
        public int ItemAmount = 12;

        [Inject]
        private ItemFactory _itemFactory;

        private ItemManager _itemGenerator;

        private void Start()
        {
            //アイテム関連の生成や初期化を行う
            _itemGenerator = new ItemManager(ItemAmount, this.transform.position, _itemFactory);
            CurrentGotItemAmount = _itemGenerator.CurrentGotItemAmount;
        }

        //アイテムの生成
        public void CreateItems()
        {
            _itemGenerator.CreateItems();
        }

        //アイテムの再生成
        public void RefreshAll()
        {
            _itemGenerator.DeleteItems();
        }
    }
}