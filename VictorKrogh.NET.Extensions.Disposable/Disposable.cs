namespace VictorKrogh.NET.Extensions.Disposable;

public abstract class Disposable : IDisposable, IAsyncDisposable
{
    private bool _disposed;

    protected void Dispose(bool disposing)
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(GetType().FullName);
        }

        if (disposing)
        {
            DisposeManagedState();
        }

        FreeUnmanagedResources();

        ClearLargeFields();

        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public async ValueTask DisposeAsync()
    {
        Dispose();

        await ValueTask.CompletedTask;
    }

    protected virtual void DisposeManagedState()
    {
    }

    protected virtual void FreeUnmanagedResources()
    {
    }

    protected virtual void ClearLargeFields()
    {
    }
}
