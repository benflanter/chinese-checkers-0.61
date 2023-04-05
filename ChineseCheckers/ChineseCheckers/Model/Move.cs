namespace ChineseCheckers.Model
{
    public class Move
    {
        private Piece originPiece;
        private int rowDest, colDest;
        /// <summary>
        /// the constructor method of class move.
        /// </summary>
        /// <param name="origin">the original piece</param>
        /// <param name="rowDest">the destination row</param>
        /// <param name="colDest">the destination col</param>
        public Move(Piece origin, int rowDest, int colDest)
        {
            this.originPiece = new Piece(origin.row, origin.col, origin.side);
            this.rowDest = rowDest;
            this.colDest = colDest;
        }
        /// <summary>
        /// the function returns the piece that the move belongs to.
        /// </summary>
        /// <returns> The original piece of the move</returns>
        public Piece GetOrigin()
        {
            return originPiece;
        }

        public int GetRow()
        {
            return rowDest;
        }

        public int GetCol()
        {
            return colDest;
        }
    }

}