namespace Footbal.Visualization
{
    using System.Collections.Generic;
    using System.Drawing;

    using Football.Core;

    public sealed class BitmapVisualizer
    {
        private readonly int _width;

        private readonly int _height;

        public BitmapVisualizer(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public Bitmap Draw(GamePosition position)
        {
            var bitmap = new Bitmap(_width, _height);

            using (Graphics ctx = Graphics.FromImage(bitmap))
            using (Pen firstTeamPen = new Pen(Color.Red))
            using (Pen secondTeamPen = new Pen(Color.Green))
            {
                DrawField(ctx, position.Field);
                DrawCommands(ctx, firstTeamPen, position.FirstTeamPosition);
                DrawCommands(ctx, secondTeamPen, position.FirstTeamPosition);
            }

            return bitmap;
        }

        private PixelsPerMeter GetPixPerMeterScale(Field field)
        {
            return new PixelsPerMeter(_width / field.Width, _height / field.Height);
        }

        private static int GetPixForLengthInMeters(float pixPerMeter, float lengthInMeters)
        {
            var pixs = pixPerMeter * lengthInMeters;
            return pixs < 1 ? 1 : (int)pixs;
        }

        private void DrawField(Graphics ctx, Field field)
        {
            var converter = new CoordinateConverter(_width, _height, field);

            using (var lineBrush = new SolidBrush(Color.White))
            using (var fieldBrush = new SolidBrush(Color.Green))
            using (var linePen = new Pen(lineBrush, 2))
            {
                // Field.
                ctx.FillRectangle(fieldBrush, 0, 0, _width, _height);
                ctx.DrawRectangle(
                    linePen,
                    converter.ToXpx(-field.Width / 2),
                    converter.ToYpx(field.Height / 2),
                    converter.ToX(field.Width),
                    converter.ToY(field.Height));

                // Middle lain.
                ctx.DrawLine(
                    linePen,
                    converter.ToXpx(0),
                    converter.ToYpx(field.Height / 2),
                    converter.ToXpx(0),
                    converter.ToYpx(-field.Height / 2));

                // Center circle.
                ctx.DrawEllipse(
                    linePen,
                    converter.ToXpx(-9.15),
                    converter.ToYpx(9.15),
                    converter.ToX(18.3),
                    converter.ToY(18.3));

                // Center spot.
                ctx.FillEllipse(lineBrush,
                    converter.ToXpx(-0.3),
                    converter.ToYpx(0.3),
                    converter.ToX(0.6),
                    converter.ToY(0.6));

                // Penalty circles.
                ctx.DrawEllipse(linePen,
                    converter.ToXpx(-field.Width / 2 + 11 - 9.15),
                    converter.ToYpx(9.15),
                    converter.ToX(18.3),
                    converter.ToY(18.3));
                ctx.DrawEllipse(linePen,
                    converter.ToXpx(field.Width / 2 - 11 - 9.15),
                    converter.ToYpx(9.15),
                    converter.ToX(18.3),
                    converter.ToY(18.3));

                // Penalty areas.
                ctx.FillRectangle(
                    fieldBrush,
                    converter.ToXpx(-field.Width / 2),
                    converter.ToYpx(20.15),
                    converter.ToX(16.5),
                    converter.ToY(40.3));
                ctx.DrawRectangle(
                    linePen,
                    converter.ToXpx(-field.Width / 2),
                    converter.ToYpx(20.15),
                    converter.ToX(16.5),
                    converter.ToY(40.3));
                ctx.FillRectangle(
                    fieldBrush,
                    converter.ToXpx(field.Width / 2 - 16.5),
                    converter.ToYpx(20.15),
                    converter.ToX(16.5),
                    converter.ToY(40.3));
                ctx.DrawRectangle(
                    linePen,
                    converter.ToXpx(field.Width / 2 - 16.5),
                    converter.ToYpx(20.15),
                    converter.ToX(16.5),
                    converter.ToY(40.3));

                // Penalty points.
                ctx.FillEllipse(lineBrush,
                    converter.ToXpx(-field.Width / 2 + 11),
                    converter.ToYpx(0.3),
                    converter.ToX(0.6),
                    converter.ToY(0.6));
                ctx.FillEllipse(lineBrush,
                    converter.ToXpx(field.Width / 2 - 11),
                    converter.ToYpx(0.3),
                    converter.ToX(0.6),
                    converter.ToY(0.6));

                // Goal areas.
                ctx.DrawRectangle(
                    linePen,
                    converter.ToXpx(-field.Width / 2),
                    converter.ToYpx(8.25),
                    converter.ToX(5.5),
                    converter.ToY(16.5));
                ctx.DrawRectangle(
                    linePen,
                    converter.ToXpx(field.Width / 2 - 5.5),
                    converter.ToYpx(8.25),
                    converter.ToX(5.5),
                    converter.ToY(16.5));

                // Goals.
                ctx.DrawRectangle(
                    linePen,
                    converter.ToXpx(-field.Width / 2 - field.GoalWidth),
                    converter.ToYpx(field.GoalHeight / 2),
                    converter.ToX(field.GoalWidth),
                    converter.ToY(field.GoalHeight));
                ctx.DrawRectangle(
                    linePen,
                    converter.ToXpx(field.Width / 2),
                    converter.ToYpx(field.GoalHeight / 2),
                    converter.ToX(field.GoalWidth),
                    converter.ToY(field.GoalHeight));

                // Corners.
                ctx.DrawArc(linePen,
                    converter.ToXpx(-field.Width / 2 - 1),
                    converter.ToYpx(field.Height / 2 + 1),
                    converter.ToX(2),
                    converter.ToY(2),
                    0,
                    90);
                ctx.DrawArc(linePen,
                    converter.ToXpx(field.Width / 2 - 1),
                    converter.ToYpx(field.Height / 2 + 1),
                    converter.ToX(2),
                    converter.ToY(2),
                    90,
                    90);
                ctx.DrawArc(linePen,
                    converter.ToXpx(field.Width / 2 - 1),
                    converter.ToYpx(-field.Height / 2 + 1),
                    converter.ToX(2),
                    converter.ToY(2),
                    180,
                    90);
                ctx.DrawArc(linePen,
                    converter.ToXpx(-field.Width / 2 - 1),
                    converter.ToYpx(-field.Height / 2 + 1),
                    converter.ToX(2),
                    converter.ToY(2),
                    270,
                    90);
            }
        }

        private void DrawCommands(Graphics ctx, Pen pen, TeamPosition teamPosition)
        {
            foreach (KeyValuePair<Player, PlayerPosition> position in teamPosition)
            {
                PlayerPosition playerPosition = position.Value;
                ctx.DrawEllipse(pen, playerPosition.x - 10, playerPosition.y - 10, playerPosition.x + 10, playerPosition.y + 10);
            }
        }
    }
}
