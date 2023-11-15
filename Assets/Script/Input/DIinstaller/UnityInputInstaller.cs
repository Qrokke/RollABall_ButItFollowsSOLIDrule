using UnityEngine;
using Zenject;

/// <summary>
/// UnityInputの依存性の注入を行うクラス
/// SOLID原則のDependency Inversionを疎結合で実現するため
/// </summary>
public class UnityInputInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //IInputReceivableが要求されたときにUnityInputProviderを注入する。
        Container
            .Bind<IInputReceivable>()
            .To<UnityInputReceiver>()
            .AsSingle();
        //キャッシュされた時同一オブジェクトかどうかをチェックしたい
    }
}