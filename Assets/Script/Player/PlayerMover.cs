using UnityEngine;
using Zenject;

/// <summary>
/// �v���C���[���ړ������鏈�������s����X�N���v�g
/// </summary>

//���������߂�Rigidbody���K�{�ł���
[RequireComponent(typeof(Rigidbody))]

public class PlayerMover : MonoBehaviour
{
    private Rigidbody _rigidbody;

    //���͂��󂯎���̃C���^�t�F�[�X
    //DI���s������Inject����������
    [Inject]
    private IInputReceivable _inputReceivable;

    //�ړ����x
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

    //�ړ�����
    private void move()
    {
        Vector3 inputMoveDirection = movementSpeed * Time.deltaTime * _inputReceivable.GetMoveVector();
        _rigidbody.AddForce(inputMoveDirection);
    }
}
