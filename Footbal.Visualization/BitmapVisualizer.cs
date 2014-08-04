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
            var pixPerMeter = GetPixPerMeterScale(field);

            var centerWidth = (int)(_width / 2.0);
            var centerHeight = (int)(_height / 2.0);

            using (var lineBrush = new SolidBrush(Color.White))
            using (var fieldBrush = new SolidBrush(Color.Green))
            using (var linePen = new Pen(lineBrush, GetPixForLengthInMeters(pixPerMeter.Width, field.Line)))
            {
                // Filling all field.
                ctx.FillRectangle(fieldBrush, 0, 0, _width, _height);

                // Field borders.
                ctx.DrawLine(linePen, 0, 0, 0, _height);
                ctx.DrawLine(linePen, 0, _height, _width, _height);
                ctx.DrawLine(linePen, _width, _height, _width, 0);
                ctx.DrawLine(linePen, _width, 0, 0, 0);

                // Middle lain.
                ctx.DrawLine(linePen, centerWidth, 0, centerWidth, _height);

                // Center circle.
                var centerCircleRadiusX = (int)(9.15 * pixPerMeter.Width);
                var centerCircleRadiusY = (int)(9.15 * pixPerMeter.Height);
                ctx.DrawEllipse(linePen, centerWidth - centerCircleRadiusX, centerHeight - centerCircleRadiusY, centerCircleRadiusX * 2, centerCircleRadiusY * 2);

                // Center spot.
                var centerSpotRadiusX = (int)(0.3 * pixPerMeter.Width);
                var centerSpotRadiusY = (int)(0.3 * pixPerMeter.Height);
                ctx.FillEllipse(lineBrush, centerWidth - centerSpotRadiusX, centerHeight - centerSpotRadiusY, centerSpotRadiusX * 2, centerSpotRadiusY * 2);

                // Penalty circles.
                var penaltyCircleWidth = 11 * pixPerMeter.Width;
                ctx.DrawEllipse(linePen, penaltyCircleWidth - centerCircleRadiusX, centerHeight - centerCircleRadiusY, centerCircleRadiusX * 2, centerCircleRadiusY * 2);
                ctx.DrawEllipse(linePen, _width - penaltyCircleWidth - centerCircleRadiusX, centerHeight - centerCircleRadiusY, centerCircleRadiusX * 2, centerCircleRadiusY * 2);

                // Penalty areas.
                var penaltyAreaWidth = (int)(16.5 * pixPerMeter.Width);
                var penaltyAreaHeight = (int)(40.3 * pixPerMeter.Height);
                ctx.FillRectangle(fieldBrush, 0, centerHeight - penaltyAreaHeight / 2, penaltyAreaWidth, penaltyAreaHeight);
                ctx.DrawRectangle(linePen, 0, centerHeight - penaltyAreaHeight / 2, penaltyAreaWidth, penaltyAreaHeight);
                ctx.FillRectangle(fieldBrush, _width - penaltyAreaWidth, centerHeight - penaltyAreaHeight / 2, penaltyAreaWidth, penaltyAreaHeight);
                ctx.DrawRectangle(linePen, _width - penaltyAreaWidth, centerHeight - penaltyAreaHeight / 2, penaltyAreaWidth, penaltyAreaHeight);

                // Penalty points.
                ctx.FillEllipse(lineBrush, penaltyCircleWidth - centerSpotRadiusX, centerHeight - centerSpotRadiusY, centerSpotRadiusX * 2, centerSpotRadiusY * 2);
                ctx.FillEllipse(lineBrush, _width - penaltyCircleWidth - centerSpotRadiusX, centerHeight - centerSpotRadiusY, centerSpotRadiusX * 2, centerSpotRadiusY * 2);

                // Goal areas.
                var goalAreaWidth = (int)(5.5 * pixPerMeter.Width);
                var goalAreaHeight = (int)(16.5 * pixPerMeter.Height);
                ctx.DrawRectangle(linePen, 0, centerHeight - goalAreaHeight / 2, goalAreaWidth, goalAreaHeight);
                ctx.DrawRectangle(linePen, _width - goalAreaWidth, centerHeight - goalAreaHeight / 2, goalAreaWidth, goalAreaHeight);

                // TODO: Goals.
                
                // Corners.
                var cornerCircleWidth = (int)(1 * pixPerMeter.Width);
                var cornerCircleHeight = (int)(1 * pixPerMeter.Height);
                ctx.DrawArc(linePen, -cornerCircleWidth, -cornerCircleHeight, cornerCircleWidth * 2, cornerCircleHeight * 2, 0, 90);
                ctx.DrawArc(linePen, _width - cornerCircleWidth, -cornerCircleHeight, cornerCircleWidth * 2, cornerCircleHeight * 2, 90, 90);
                ctx.DrawArc(linePen, _width - cornerCircleWidth, _height - cornerCircleHeight, cornerCircleWidth * 2, cornerCircleHeight * 2, 180, 90);
                ctx.DrawArc(linePen, -cornerCircleWidth, _height - cornerCircleHeight, cornerCircleWidth * 2, cornerCircleHeight * 2, 270, 90);
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
