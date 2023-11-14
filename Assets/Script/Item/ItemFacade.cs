using UnityEngine;
using UniRx;
using Zenject;

/// <summary>
/// �A�C�e���̏����𗘗p���邽�߂̃t�@�T�[�h
/// </summary>
public class ItemFacade : MonoBehaviour
{
    public ReactiveProperty<int> CurrentGotItemAmount { get; private set; }
    [HideInInspector]
    public int ItemAmount;


    [Inject]
    private ItemFactory _itemFactory;

    private ItemManager _itemGenerator;

    private void Start()
    {
        _itemGenerator = new ItemManager(ItemAmount, this.transform.position, _itemFactory);
        CurrentGotItemAmount = _itemGenerator.CurrentGotItemAmount;
    }
    public void CreateItems()
    {
        _itemGenerator.CreateItems();
    }
    public void RefreshAll()
    {

    }
}
