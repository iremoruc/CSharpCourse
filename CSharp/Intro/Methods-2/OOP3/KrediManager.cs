using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager
    {
        //interface kuralları içerir ve ionu implemente eden classlar bu
        //kuralları doldurrmak zorunda
        //her kredide olması gereken kurallar zorunlu yaorık
        //ve miras alan herkes şablona uymak zorunda
        void Hesapla();
        void Bisey();
            
    }
}
