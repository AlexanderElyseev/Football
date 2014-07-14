namespace Football.Core
{
    using System;
    using System.Diagnostics.Contracts;

    public sealed class Field
    {
        private readonly float _width;

        private readonly float _height;

        private readonly float _line;

        private readonly float _centerDiametr;

        private readonly float _centerCircleDiametr;

        public float Width
        {
            get { return _width; }
        }

        public float Height
        {
            get { return _height; }
        }

        public float Line
        {
            get { return _line; }
        }

        public Field(float width, float height, float line)
        {
            Contract.Requires<ArgumentException>(width > 0);
            Contract.Requires<ArgumentException>(height > 0);
            Contract.Requires<ArgumentException>(line > 0);

            _width = width;
            _height = height;
            _line = line;
        }
    }
}
