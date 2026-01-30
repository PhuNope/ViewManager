namespace Nope.ViewManager.Runtime.Interfaces {
    using ScriptableObjects;

    public interface IViewLoader {
        IView CreateView(ViewInfo viewInfo);
    }
}