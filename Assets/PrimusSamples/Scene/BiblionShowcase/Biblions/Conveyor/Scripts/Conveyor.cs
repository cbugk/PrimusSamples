using Primus.Biblion.Conveyor;

namespace PrimusSamples.BiblionShowcase.Conveyor
{
    public class Conveyor : BaseConveyor<ConveyorCatalog>
    {
        private void Awake()
        {
            BiblionTitle = ConveyorCatalog.SAMPLE_CONVEYOR;
        }
    }
}