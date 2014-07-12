namespace Football.Core
{
    using System;
    using System.Diagnostics.Contracts;

    public sealed class Field
    {
        private readonly float _width;

        private readonly float _height;

        private readonly float _lineWidth;

        float Width
        {
            get { return _width; }
        }

        float Height
        {
            get { return _height; }
        }

        float LineWidth
        {
            get { return _lineWidth; }
        }

        public Field(float width, float height, float lineWidth)
        {
            Contract.Requires<ArgumentException>(width > 0);
            Contract.Requires<ArgumentException>(height > 0);
            Contract.Requires<ArgumentException>(lineWidth > 0);

            _width = width;
            _height = height;
            _lineWidth = lineWidth;
        }
    }
}
