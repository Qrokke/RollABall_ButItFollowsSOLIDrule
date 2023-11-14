using UnityEngine;
using Zenject;
using UniRx;

public class Item : MonoBehaviour, ICollectable
{
    
    public Subject<Unit> CollectedSubject { get; private set; }

    //Zenject�̃t�@�N�g���Ő������ɌĂ΂�郁�\�b�h�C���W�F�N�V�����B�s���Ă邱�Ƃ̓R���X�g���N�^�Ɠ���
    [Inject]
    public void Construct(Vector3 position)
    {
        transform.position = position;
        CollectedSubject = new Subject<Unit>();
    }
    //�W�߂�ꂽ���ɃC�x���g�𔭐�������
    public void Collected()
    {
        CollectedSubject.OnNext(Unit.Default);
        Destroy(this.gameObject);
    }

    //�擾�ς݂��������߂�

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Collected();
        }
    }
}
