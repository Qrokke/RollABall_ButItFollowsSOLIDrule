using UnityEngine;
using UniRx;
using Zenject;

/// <summary>
/// �A�C�e���̏����𗘗p���邽�߂̃t�@�T�[�h
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
            //�A�C�e���֘A�̐����⏉�������s��
            _itemGenerator = new ItemManager(ItemAmount, this.transform.position, _itemFactory);
            CurrentGotItemAmount = _itemGenerator.CurrentGotItemAmount;
        }

        //�A�C�e���̐���
        public void CreateItems()
        {
            _itemGenerator.CreateItems();
        }

        //�A�C�e���̍Đ���
        public void RefreshAll()
        {
            _itemGenerator.DeleteItems();
        }
    }
}