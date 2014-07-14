namespace Footbal.View
{
    using System.Drawing;

    using Football.Core;

    public sealed class BitmapVizualizer
    {
        private struct Scale
        {
            public readonly float Width;

            public readonly float Height;

            public Scale(float width, float height)
            {
                Width = width;
                Height = height;
            }
        }

        private readonly int _width;

        private readonly int _height;

        public BitmapVizualizer(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public Bitmap Draw(GamePosition position)
        {
            var bitmap = new Bitmap(_width, _height);

            using (var ctx = Graphics.FromImage(bitmap))
            {
                DrawField(ctx, position.Field);
                DrawCommands(ctx, position.FirstTeamPosition);
                DrawCommands(ctx, position.FirstTeamPosition);
            }
            
            return bitmap;
        }

        private Scale GetPixPerMeterScale(Field field)
        {
            return new Scale(_width / field.Width, _height / field.Height);
        }

        private static int GetPixForLengthInMeters(float pixPerMeter, float lengthInMeters)
        {
            var pixs = pixPerMeter * lengthInMeters;
            return pixs < 1 ? 1 : (int)pixs;
        }

        private void DrawField(Graphics ctx, Field field)
        {
            var pixPerMeter = GetPixPerMeterScale(field);

            var centerWidth = (int)(_width / 2.0);

            using (var lineBrush = new SolidBrush(Color.White))
            using (var fieldBrush = new SolidBrush(Color.Green))
            using (var lineYPen = new Pen(lineBrush, GetPixForLengthInMeters(pixPerMeter.Width, field.Line)))
            using (var lineXPen = new Pen(lineBrush, GetPixForLengthInMeters(pixPerMeter.Height, field.Line)))
            {
                ctx.FillRectangle(fieldBrush, 0, 0, _width, _height);

                ctx.DrawLine(lineYPen, 0, 0, 0, _height);
                ctx.DrawLine(lineXPen, 0, _height, _width, _height);
                ctx.DrawLine(lineYPen, _width, _height, _width, 0);
                ctx.DrawLine(lineXPen, _width, 0, 0, 0);

                ctx.DrawLine(lineYPen, centerWidth, 0, centerWidth, _height);
            }
        }
        
        private void DrawCommands(Graphics ctx, TeamPosition position)
        {
        }
    }
}
