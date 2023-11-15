using UniRx;
using UnityEngine;
using Item;

/// <summary>
/// スコアに関するデータの仲介役
/// ゲームデータの数値はScoreDataに保持されている
/// そのゲームへの反映はFacadeへ
/// その表示はTextへ
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
