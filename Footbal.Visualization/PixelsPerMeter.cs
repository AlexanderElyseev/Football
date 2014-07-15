namespace Footbal.Visualization
{
    internal class PixelsPerMeter
    {
        public float Width { get; private set; }

        public float Height { get; private set; }

        public PixelsPerMeter(float width, float height)
        {
            Width = width;
            Height = height;
        }
    }
}