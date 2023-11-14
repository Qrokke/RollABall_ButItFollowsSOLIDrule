using UniRx;

/// <summary>
/// スコアデータを保持するクラス
/// </summary>
public class ScoreData
{
    public int MaxScore { get; private set; } 
        = 12; 
    public ReactiveProperty<int> CurrentScore { get; private set; }
        = new ReactiveProperty<int>(0);

}
