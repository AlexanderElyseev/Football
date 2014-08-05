namespace Footbal.Visualization
{
    using Football.Core;

    public class CoordinateConverter
    {
        private double _kw;
        private double _kh;

        private double _wp;
        private double _hp;

        private double _w2;
        private double _h2;

        public CoordinateConverter(int width, int height, Field field)
        {
            double indentWidth = 5.0;
            double indentHeight = 5.0;

            _kw = width / (field.Width + 2 * indentWidth);
            _kh = height / (field.Height + 2 * indentHeight);

            _wp = indentWidth * _kw;
            _hp = indentHeight * _kh;

            _w2 = (width - 2 * _wp) / 2;
            _h2 = (height - 2 * _hp) / 2;
        }

        public float ToXpx(double x)
        {
            return (float)(_wp + _w2 + x * _kw);
        }

        public float ToX(double x)
        {
            return (float)(x * _kw);
        }

        public float ToY(double y)
        {
            return (float)(y * _kh);
        }

        public float ToYpx(double y)
        {
            return (float)(_hp + _h2 - y * _kh);
        }
    }
}
