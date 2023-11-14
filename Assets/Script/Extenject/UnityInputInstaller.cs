using UnityEngine;
using Zenject;

/// <summary>
/// UnityInput�̈ˑ����̒������s���N���X
/// SOLID������Dependency Inversion��a�����Ŏ������邽��
/// </summary>
public class UnityInputInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //IInputReceivable���v�����ꂽ�Ƃ���UnityInputProvider�𒍓�����B
        Container
            .Bind<IInputReceivable>()
            .To<UnityInputReceiver>()
            .AsSingle();
        //�L���b�V�����ꂽ������I�u�W�F�N�g���ǂ������`�F�b�N������
    }
}