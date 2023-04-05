namespace VictorKrogh.NET.Extensions.Disposable;

public abstract class UnmanagedDisposable : Disposable
{
    ~UnmanagedDisposable()
    {
        Dispose(false);
    }
}
