using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class TurkishEnglishWLevel : IEntity
    {
        public int UserId { get; set; }
        public int WordId { get; set; }
        public int TurkishWordLevel { get; set; }
        public int EnglishWordLevel { get; set; }
    }
}
