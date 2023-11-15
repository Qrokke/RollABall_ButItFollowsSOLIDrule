using UniRx;

namespace Item {
    /// <summary>
    /// プレイヤーによって取得されるアイテム
    /// </summary>
    internal interface ICollectable {
        public Subject<Unit> CollectedSubject { get; }
        public void Collected();
    }
}
