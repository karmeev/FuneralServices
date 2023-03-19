namespace Funeral.Domain.Order
{
    public class OtherInformation
    {
        public OtherInformation(
            string obeliskForm,
            string pedestalForm,
            string funeralForm,
            string funeralColor,
            string upPartObelisk,
            string botPartObelisk,
            string otherDesign)
        {
            ObeliskForm = obeliskForm;
            PedestalForm = pedestalForm;
            FuneralForm = funeralForm;
            FuneralColor = funeralColor;
            UpPartObelisk = upPartObelisk;
            BotPartObelisk = botPartObelisk;
            OtherDesign = otherDesign;
        }

        public string ObeliskForm { get; }
        public string PedestalForm { get; }
        public string FuneralForm { get; }
        public string FuneralColor { get; }
        public string UpPartObelisk { get; }
        public string BotPartObelisk { get; }
        public string OtherDesign { get; }
    }
}