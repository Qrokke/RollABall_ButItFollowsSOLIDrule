using UnityEngine;

/// <summary>
/// キーボード入力を受け付けるクラス
/// </summary>
public class UnityInputReceiver : IInputReceivable
{
    public Vector3 GetMoveVector()
    {
        Vector3 moveVector = new Vector3(0f,0f,0f);
        moveVector.x = Input.GetAxis("horizontal");
        moveVector.y = Input.GetAxis("vertical");
        return moveVector;
    }
}
