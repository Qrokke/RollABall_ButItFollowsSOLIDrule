using UniRx;

/// <summary>
/// �X�R�A�f�[�^��ێ�����N���X
/// </summary>
public class ScoreData
{
    public int MaxScore { get; private set; } 
        = 12; 
    public ReactiveProperty<int> CurrentScore { get; private set; }
        = new ReactiveProperty<int>(0);

}
