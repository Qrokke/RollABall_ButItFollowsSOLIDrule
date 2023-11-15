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
        }
        public void CreateItems()
        {
            _itemGenerator = new ItemManager(ItemAmount, this.transform.position, _itemFactory);
            CurrentGotItemAmount = _itemGenerator.CurrentGotItemAmount;
            _itemGenerator.CreateItems();
        }
        public void RefreshAll()
        {

        }
    }
}