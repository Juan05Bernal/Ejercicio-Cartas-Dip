//------------------------------------------------------------------------------
// <copyright file="SymbolCard.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Presenta un naipe con símbolos, por ejemplo A♠ o 10♥.
    /// </summary>
    public class SymbolCard : ICardContent
    {
        private readonly Card card;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="SymbolCard"/>.
        /// </summary>
        /// <param name="card">El naipe a presentar con símbolos.</param>
        public SymbolCard(Card card)
        {
            ArgumentNullException.ThrowIfNull(card);
            this.card = card;
        }

        /// <summary>
        /// Obtiene el texto para imprimir el naipe con símbolos.
        /// </summary>
        /// <returns>El texto del naipe, por ejemplo <c>A♠</c>.</returns>
        public string GetTextToPrint()
        {
            return this.GetRankSymbol() + this.GetSuitSymbol();
        }

        private string GetRankSymbol()
        {
            switch (this.card.Rank)
            {
                case Rank.Ace:
                    return "A";
                case Rank.King:
                    return "K";
                case Rank.Queen:
                    return "Q";
                case Rank.Jack:
                    return "J";
                default:
                    // Two vale 0 en el enumerado, por eso se suma 2.
                    return ((int)this.card.Rank + 2).ToString();
            }
        }

        private string GetSuitSymbol()
        {
            string symbol;
            switch (this.card.Suit)
            {
                case Suit.Hearts:
                    symbol = "♥";
                    break;
                case Suit.Diamonds:
                    symbol = "♦";
                    break;
                case Suit.Clubs:
                    symbol = "♣";
                    break;
                default:
                    symbol = "♠";
                    break;
            }

            return symbol;
        }
    }
}