namespace VictorKrogh.NET.Disposable;

public abstract class UnmanagedDisposable : DisposableObject
{
    ~UnmanagedDisposable()
    {
        Dispose(false);
    }
}
