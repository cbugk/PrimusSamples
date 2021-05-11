using Primus.Toolbox.Service;
using PrimusSamples.BiblionShowcase.View;

namespace PrimusSamples.BiblionShowcase.Service
{
    /// <summary>Registry for intra-scenary components.</summary>
    public class YellowPages : BaseYellowPagesSingleton<YellowPages, ManagerView, Input>
    {
        public override Input InputActions { get => Init.Service.YellowPages.Instance.InputActions; }
    }
}