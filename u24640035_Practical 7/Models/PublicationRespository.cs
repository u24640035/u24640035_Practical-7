using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u24640035_Practical_7.Models
{
	public class PublicationRespository
	{
        public List<Publication> GetPublications()
        {
            return new List<Publication>
        {
            // Koffi
            new Article
            {
                Title = "Improving the foundation of our failing sand simulator",
                Author = new Author { Name = "Koffi Umukoro" },
                Summary = "Addison is a detective from Sale who falls in love with his best friend. The two are separated when the best friend falls for somebody else. However, Addison manages to rescue the situation by buying a magnificent t-shirt.",
                MainStoryURL = "https://bait.example.net/bag.aspx",
                LeadingImage = "https://cdn.pixabay.com/photo/2018/03/02/20/22/sktop-3194194__340.jpg",
                PublicationDate = new DateTime(2018, 7, 24)
            },
            // Octavia
             new Book
            {
                Title = "NASA fed some Apollo 11 lunar samples to cockroaches and mice",
                Author = new Author { Name = "Octavia Barret" },
                Summary = "A farmer from Markham is delighted when she gets the chance to take part in the trial of X Factor. However, her chances are scuppered when her son goes missing. Unexpectedly, the farmer is bitten by a zombie and therefore is disqualified from competing.",
                MainStoryURL = "https://www.example.com/bite.aspx",
                LeadingImage = "https://cdn.pixabay.com/photo/2016/08/18/08/31/lemur-1602313__340.jpg",
                PublicationDate = new DateTime(2006, 5, 15),
                Editions = 2
            },
             // Gunnhild
            new Article
            {
                Title = "When Your Smart ID Card Reader Comes with Malware",
                Author = new Author { Name = "Gunnhild Aric" },
                Summary = "A caretaker from Leith is delighted when she gets the chance to take part in the trial of X Factor. However, her chances are scuppered by an angry carrot. After the end, the caretaker realises there is more to lift than winning X-Factor and goes on a picture with her great aunt instead.",
                MainStoryURL = "https://example.com/bone/basin.php?bed=bedroom&boat=amusement#boundary",
                LeadingImage = "https://cdn.pixabay.com/photo/2017/06/14/11/34/meadow-2401931__340.jpg",
                PublicationDate = new DateTime(2023, 3, 21)
            },
            // Jakob
            new Book
            {
                Title = "Jailer: A truly relational database tool",
                Author = new Author { Name = "Jakob Ayanda" },
                Summary = "In a world where robots are wealthy, one golfer has no choice but to assainties an honorable man by killing his own ex-wife. Eventually, the golfer forms an army and teaches the robots a little respect.",
                MainStoryURL = "https://www.example.com/baseball/basin.php?attraction=anger&bead=amusement",
                LeadingImage = "https://cdn.pixabay.com/photo/2016/08/20/05/44/clock-1606919__340.jpg",
                PublicationDate = new DateTime(1989, 6, 6),
                Editions = 3
            },
            // Shyam
            new Article
            {
                Title = "Everything you ever wanted to know about terminal",
                Author = new Author { Name = "Shyam Benson" },
                Summary = "In a world where robots are miraculously transformed into angels, one pop star has no choice but to bring down the goverment by killing her own step-sister. It turns out all the robots were a manifestations of the pop star's multiple personality disorder and her real fight is one to regain sanity.",
                MainStoryURL = "https://www.example.com/bait/bath.php",
                LeadingImage = "https://cdn.pixabay.com/photo/2016/09/01/10/33/witchs-house-1635770_960_720.jpg",
                PublicationDate = new DateTime(2020, 1, 23)
            },
            // Lucas
            new Article
            {
                Title = "NaturalSpeech: End-to-end text to speech synthesis with human-level quality",
                Author = new Author { Name = "Lucas Asim" },
                Summary = "When a movie star from West Des Moines learns to sing, not everybody is supportive. However, her fortunes improve when her step-sister buys a deralict castle. Eventually, the movie star realises that she has always been a worthwhile person and does not need to change.",
                MainStoryURL = "http://www.example.com/bear",
                LeadingImage = "https://cdn.pixabay.com/photo/2016/04/25/07/15/man-1351317__340.png",
                PublicationDate = new DateTime(2022, 10, 28)
            },
            // Harmon
            new Article
            {
                Title = "Husky, Datadog's Third-Generation Event Store",
                Author = new Author { Name = "Harmon Deeann" },
                Summary = "A WW2 veteran Brisbane who recieves an invitation to a modern battle. It turns out the invitations is spam and is from a scammer who is famous for making up stories.",
                MainStoryURL = "https://www.example.com/bells",
                LeadingImage = "https://cdn.pixabay.com/photo/2020/03/13/08/19/ornaments-4927258__340.jpg",
                PublicationDate = new DateTime(2022, 3, 4)
            },

            // Gargi
          
            new Book
            {
                Title = "Singers and Vampires",
                Author = new Author { Name = "Gargi Sudheer" },
                Summary = "In a world where vampires run large corporations, one singer has no choice but to protect mankind using a magic ring. It turns out the vampires are all sheep.",
                MainStoryURL = "https://example.com/baseball/adjustment.aspx?airplane=border&advertisement=argument",
                LeadingImage = "https://cdn.pixabay.com/photo/2016/08/07/18/22/back-to-school-1576791__340.jpg",
                PublicationDate = new DateTime(1972, 4, 24),
                Editions = 2
            }
        };
        }
    }
}