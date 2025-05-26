using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u24640035_Practical_7.Models
{
	public class Book : Publication
	{
        public int Editions { get; set; }

        public override string GetPublicationInfo()
        {
            return "Book";
        }

        public override string GetFormattedDate()
        {
            return $"First publication date is {PublicationDate.ToString("dddd, dd MMMM yyyy")} and the number of editions is {Editions}";
        }
    }
}