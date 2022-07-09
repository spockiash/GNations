namespace GNations.Models
{
    public class ContinentDisplayModel
    {
        public int EnumNo { get; set; }
        public string? SvgMarkup { get; set ; }
        public string? StyleAttribute { get; set; }
        //Relative top is initialized as range 0-300, program calculations can exceed that range
        public int RelativeTop { get; set; }
        //Relative left is initialized as range 0-400, program calculations can exceed that range
        public int RelativeLeft { get; set; }
        //Value is not initialized, only for display calculations
        public int PositionTop { get; set; }
        //Value is not initialized, only for display calculations
        public int PositionLeft { get; set; }
        public float ScaleTop { get; set; }
        public float ScaleLeft { get; set; }
        public int BaseWidth { get; set; }
        public int BaseHeight { get; set; }
        public float BaseScale { get; set; }
    }
}