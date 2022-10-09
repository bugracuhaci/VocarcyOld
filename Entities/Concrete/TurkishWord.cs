using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class TurkishWord : IEntity
    {
        public int Id { get; set; }
        public int WordId { get; set; }
        public string Name { get; set; }
    }
}
