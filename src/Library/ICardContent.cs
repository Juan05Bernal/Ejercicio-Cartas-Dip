//------------------------------------------------------------------------------
// <copyright file="ICardContent.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa el contenido de un naipe que se puede imprimir como texto.
    /// </summary>
    public interface ICardContent
    {
        /// <summary>
        /// Obtiene el texto para imprimir.
        /// </summary>
        /// <returns>El texto a imprimir.</returns>
        string GetTextToPrint();
    }
}