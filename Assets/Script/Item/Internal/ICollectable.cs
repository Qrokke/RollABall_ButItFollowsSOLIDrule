using UniRx;
public interface ICollectable{
    public Subject<Unit> CollectedSubject { get; }
    public void Collected();
    
}
