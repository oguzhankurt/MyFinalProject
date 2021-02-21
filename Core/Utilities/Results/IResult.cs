using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; } //sadece okunabailir. Get okuma Set Yazma
        string Message { get; } //üst açıklama aynı
    }
}
