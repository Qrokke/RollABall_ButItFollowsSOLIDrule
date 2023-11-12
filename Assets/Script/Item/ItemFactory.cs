using UnityEngine;

/// <summary>
/// Itemを作成するスクリプトです。
/// </summary>
public class ItemFactory : MonoBehaviour, ICreatable
{
    [SerializeField] private GameObject _productPrefab;
    public void Create(Vector3 position) {
        GameObject item = Instantiate(_productPrefab, position,Quaternion.identity);
    }
}
