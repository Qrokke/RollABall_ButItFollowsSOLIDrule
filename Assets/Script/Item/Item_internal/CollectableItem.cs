using UnityEngine;
using Zenject;
using UniRx;

namespace Item
{
    internal class CollectableItem : MonoBehaviour, ICollectable
    {
        public Subject<Unit> CollectedSubject { get; private set; }

        //Zenjectのファクトリで生成時に呼ばれるメソッドインジェクション。行ってることはコンストラクタと同じ
        [Inject]
        public void Construct(Vector3 position)
        {
            transform.position = position;
            CollectedSubject = new Subject<Unit>();
        }
        //集められた時にイベントを発生させる
        public void Collected()
        {
            CollectedSubject.OnNext(Unit.Default);
            Vanish();
        }

        public void Vanish()
        {
            Destroy(this.gameObject);
        }



        //取得済みを示すための

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Collected();
            }
        }
    }

}