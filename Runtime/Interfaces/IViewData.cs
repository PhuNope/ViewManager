namespace Nope.ViewManager.Runtime.Interfaces {
    public interface IViewData<out T> {
        T TypedData { get; }
    }
}