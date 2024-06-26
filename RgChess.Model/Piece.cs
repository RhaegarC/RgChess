namespace RgChess.Model;

using RgChess.Model.Common;
using Values = RgChess.Model.Common.Constants.PieceValues;

/// <summary>
/// Piece.
/// </summary>
/// <param name="name">Name</param>
public class Piece
{
    /// <summary>
    /// Gets or sets name of piece.
    /// </summary>
    public PieceName Name { get; private set; }

    /// <summary>
    /// Gets or sets price of piece.
    /// </summary>
    public float Price { get; private set; }

    /// <summary>
    /// Gets or sets side of piece.
    /// </summary>
    public PieceSide Side { get; set; }

    /// <summary>
    /// Gets or sets value of piece file.
    /// </summary>
    public char File { get; set; }

    /// <summary>
    /// Gets or sets value of piece rank.
    /// </summary>
    public char Rank { get; set; }

    public Piece(PieceName name, PieceSide side)
    {
        this.Name = name;
        this.Side = side;
        switch (this.Name)
        {
            case PieceName.Rook:
                this.Price = Values.Rook;
                break;
            case PieceName.Knight:
                this.Price = Values.Knight;
                break;
            case PieceName.Bishop:
                this.Price = Values.Bishop;
                break;
            case PieceName.Queen:
                this.Price = Values.Queen;
                break;
            case PieceName.King:
                this.Price = Values.King;
                break;
            case PieceName.Pawn:
                this.Price = Values.Pawn;
                break;
        }
    }
}
