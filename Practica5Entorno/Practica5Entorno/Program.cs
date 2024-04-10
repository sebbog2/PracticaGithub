using Microsoft.VisualBasic;

namespace Practica5Entorno
{
    internal class Program
    {
        public enum CardType
        {
            DIAMANTE,
            TREBOL,
            PICAS,
            CORAZON
        }
        public enum ColorType
        {
            BLUE,
            BLACK
        }
        public enum FigureType
        {
            AS = 1,
            KING = 13,
            QUEEN = 12,
            JACK = 11,
            JOKER = 14,
            NONE
        }
        static void Main(string[] args)
        {
            
        }
        public class Card
        {
            private int _number;
            private CardType _CardType;

            public Card(int number, CardType type)
            {
                _number = number;
                _CardType = type;
            }

            public bool IsValid()
            {
                return _number > 1 && _number <= 14;
            }
            public int GetNumber()
            {
                return _number;
            }
            public CardType GetCardType()
            {
                return _CardType;
            }
            public ColorType GetColor()
            {
                if (GetCardType() == CardType.DIAMANTE || GetCardType() == CardType.CORAZON)
                    return ColorType.BLUE;
                else
                    return ColorType.BLACK;
            }
            public FigureType GetFigureType()
            {
                if (_number == 1)
                    return FigureType.AS;
                if (_number == 11)
                    return FigureType.JACK;
                if (_number == 12)
                    return FigureType.QUEEN;
                if (_number == 13)
                    return FigureType.KING;
                if (_number == 14)
                    return FigureType.JOKER;
                else
                    return FigureType.NONE;
            }
            public bool IsFigure()
            {
                return (_number == 1 || _number <= 14);
            }
        }
    }
}