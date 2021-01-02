using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public interface ILieutenantGeneral : IPrivate
    {
        public List<IPrivate> Privates { get; }

        void Add(IPrivate myPrivate);
    }
}
