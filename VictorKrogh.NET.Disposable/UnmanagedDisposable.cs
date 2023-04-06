namespace VictorKrogh.NET.Disposable;

public abstract class UnmanagedDisposable : Disposable
{
    ~UnmanagedDisposable()
    {
        Dispose(false);
    }
}
