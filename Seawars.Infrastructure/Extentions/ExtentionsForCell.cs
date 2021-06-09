namespace Seawars.Infrastructure.Extentions
{
    public static class ExtentionsForCell
    {
        public static (int, int) ConvertCellToIndexes(this int self)
        {
            return (self / 11, self % 11);
        }
        public static int ConverIndexToCell(this int number, int i, int j)
        {
            return i * 11 + j;
        }
        public static int DetermineCellNumber(this object number)
        {
            string CellsNumber = "";
            int NewCell = 0;

            for (int i = 1; i < number.ToString().Length; i++)
                CellsNumber += number.ToString()[i];

            bool isParsed = int.TryParse(CellsNumber, out NewCell);
            if (isParsed is false) return -1;

            return NewCell;
        }
    }
}
