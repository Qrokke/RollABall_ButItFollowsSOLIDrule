using UnityEngine;

/// <summary>
/// Item���쐬����X�N���v�g�ł��B
/// </summary>
public class ItemFactory : MonoBehaviour, ICreatable
{
    [SerializeField] private GameObject _productPrefab;
    public void Create(Vector3 position) {
        GameObject item = Instantiate(_productPrefab, position,Quaternion.identity);
    }
}
