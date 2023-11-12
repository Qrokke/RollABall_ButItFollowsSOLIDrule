using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// プレイヤーを移動させる処理を実行するスクリプト
/// </summary>

//動かすためにRigidbodyを使用する
[RequireComponent(typeof(Rigidbody))]

public class PlayerMover : MonoBehaviour
{
    private Rigidbody _rigidbody;

    //入力を受け取る先のインタフェース
    private IInputReceivable _inputReceivable;

    //移動速度
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
