using Primus.Toolbox.Service;
using PrimusSamples.Init.View;

namespace PrimusSamples.Init.Service
{
    public class YellowPages
    : BaseYellowPagesSingleton<YellowPages, ManagerView, Input>
    {
        public override Input InputActions { get => Init.Service.YellowPages.Instance.InputActions; }

        protected override void Awake()
        {
            base.Awake();

            InputActions = new Input();
        }

    }
}