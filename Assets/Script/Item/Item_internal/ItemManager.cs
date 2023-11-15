using UnityEngine;
using Zenject;
using UniRx;

/// <summary>
/// �X�^�[�g���A�t�@�N�g���ƃA�C�e���𗘗p���邽�߂̏�ʃN���X
/// �A�C�e���̔z�u���s�����߂����ɂ���
/// </summary>
namespace Item
{
    internal class ItemManager
    {
        //���݂̎擾�A�C�e����
        public ReactiveProperty<int> CurrentGotItemAmount = new ReactiveProperty<int>(0);

        //Zenject�ɂ�蒍��
        [Inject]
        private ItemFactory _itemFactory;

        private ICollectable[] _iitems;
        private int _itemAmount = 12;
        private float _itemScatter = 8f;

        private Vector3 _generatePosition;

        //�R���X�g���N�^
        public ItemManager(int ItemAmount, Vector3 position, ItemFactory itemFactory)
        {
            _itemAmount = ItemAmount;
            _generatePosition = position;
            _itemFactory = itemFactory;
        }

        //�A�C�e���̏o������
        public void CreateItems()
        {
            _iitems = new ICollectable[_itemAmount];

            for (int i = 0; i < _itemAmount; i++)
            {
                Vector3 itemPosition = itemPositionVectorByOrder(i);

                //Zenject��IItem��Factory��R�Â��Ă���̂ŏo���ꏊ�𑗂邾���ł悢
                //��������
                ICollectable item = _itemFactory.Create(itemPosition);

                _iitems[i] = item;

                //�W�߂�ꂽ�Ƃ����C�x���g���󂯎���ē��_�𑝂₷
                _iitems[i].CollectedSubject.Subscribe(_ =>
                {
                    CurrentGotItemAmount.Value++;
                });
            }
        }

        public void DeleteItems()
        {
            foreach (ICollectable item in _iitems)
            {
                if (item == null) continue;
                item.Vanish();
            }
        }

        private Vector3 itemPositionVectorByOrder(int order)
        {

            //�~�`�ɕ��ׂĂ݂�B
            float itemPositionX = _itemScatter * Mathf.Cos(Mathf.PI / (_itemAmount / 2f) * order);
            float itemPositionZ = _itemScatter * Mathf.Sin(Mathf.PI / (_itemAmount / 2f) * order);

            //�����ʒu
            Vector3 returnPosition = new Vector3(itemPositionX, 0f, itemPositionZ);
            //�����ʒu���I�u�W�F�N�g�̗ʂ����ړ�
            returnPosition += _generatePosition;

            return returnPosition;

        }


    }
}