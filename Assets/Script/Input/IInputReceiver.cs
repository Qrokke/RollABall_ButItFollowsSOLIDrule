using UnityEngine;

/// <summary>
/// 入力を受け付けるためのスクリプトにつけるインタフェース
/// 現在は移動することのみ可能
/// </summary>
public interface IInputReceivable
{
    public Vector3 GetMoveVector();

}
