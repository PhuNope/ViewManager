namespace Nope.ViewManager.Runtime {
    using Interfaces;

    internal class NullData : IViewData<NullData> {
        public NullData TypedData {
            get => this;
        }
    }
}