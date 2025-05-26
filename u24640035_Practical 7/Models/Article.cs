using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u24640035_Practical_7.Models
{
        public class Article : Publication
        {
            public override string GetPublicationInfo()
            {
                return "Article";
            }
        }
    }