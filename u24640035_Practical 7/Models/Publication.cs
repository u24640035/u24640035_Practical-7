using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u24640035_Practical_7.Models
{
	public abstract class Publication
	{
        public string Title { get; set; }
        public Author Author { get; set; }
        public string Summary { get; set; }
        public string MainStoryURL { get; set; }
        public string LeadingImage { get; set; }
        public DateTime PublicationDate { get; set; }

        public abstract string GetPublicationInfo();
        public virtual string GetFormattedDate()
        {
            return $"The date of publication is {PublicationDate.ToString("dddd, dd MMMM yyyy")}";
        }
    }
}