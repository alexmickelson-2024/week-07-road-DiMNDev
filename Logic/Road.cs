namespace Logic
{


    public class Road : IRoad
    {
        public int RowCount { get; set; }

        public int ColCount { get; set; }
        private IVehicle[,] vehicles { get; set; }

        public Road(int rows, int cols)
        {
            vehicles = new IVehicle[rows, cols];
            RowCount = rows;
            ColCount = cols;
        }

        public IVehicle? GetVehicle(int row, int column)
        {
            return vehicles[row, column] ?? null;
        }

        public void SetVehicle(int row, int column, IVehicle vehicle)
        {
            vehicles[row, column] = vehicle;
        }
    }
}