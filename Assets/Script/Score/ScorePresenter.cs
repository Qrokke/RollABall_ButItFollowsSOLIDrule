using UniRx;
using UnityEngine;
using Item;

/// <summary>
/// �X�R�A�Ɋւ���f�[�^�̒����
/// �Q�[���f�[�^�̐��l��ScoreData�ɕێ�����Ă���
/// ���̃Q�[���ւ̔��f��Facade��
/// ���̕\����Text��
/// </summary>
public class ScorePresenter : MonoBehaviour
{
    private ScoreData _scoreData;
    
    [SerializeField]
    private ItemFacade _itemFacade;

    [SerializeField]
    private LeftOverScript _leftOverScript;

    [SerializeField]
    private GameClearText _gameClearText;

    void Awake()
    {
        _scoreData = new ScoreData();
        _itemFacade.ItemAmount = _scoreData.MaxScore;
        _itemFacade.CreateItems();
        _itemFacade.CurrentGotItemAmount.Subscribe(x => {
            _leftOverScript.UpDateText(x);
            if(x >= _scoreData.MaxScore)
            {
                _gameClearText.OpenText();
            }
        });
    }

}
