using UniRx;

namespace Item {
    /// <summary>
    /// �v���C���[�ɂ���Ď擾�����A�C�e��
    /// </summary>
    internal interface ICollectable {
        public Subject<Unit> CollectedSubject { get; }
        public void Collected();
    }
}
