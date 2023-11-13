using UnityEngine;
using Zenject;

/// <summary>
/// プレイヤーを移動させる処理を実行するスクリプト
/// </summary>

//動かすためにRigidbodyが必須である
[RequireComponent(typeof(Rigidbody))]

public class PlayerMover : MonoBehaviour
{
    private Rigidbody _rigidbody;

    //入力を受け取る先のインタフェース
    //DIを行うためInject属性をつける
    [Inject]
    private IInputReceivable _inputReceivable;

    //移動速度
    [SerializeField]
    private float movementSpeed = 5f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        move();
    }

    //移動処理
    private void move()
    {
        Vector3 inputMoveDirection = movementSpeed * Time.deltaTime * _inputReceivable.GetMoveVector();
        _rigidbody.AddForce(inputMoveDirection);
    }
}
