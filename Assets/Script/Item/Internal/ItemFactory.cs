using UnityEngine;
using Zenject;
/// <summary>
/// Item���쐬���邽�߂̃t�@�N�g���N���X�ł��B
/// ������Zenject������Ă���܂�
/// </summary>
namespace Item
{
    internal class ItemFactory : PlaceholderFactory<Vector3, ICollectable> { }
}
