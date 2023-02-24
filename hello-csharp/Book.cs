using System.Text;
using System.Threading.Tasks;

namespace Program
{
  class Book
  {
    public string title;
    public string author;
    public int pages;

    public Book(string atitle, string aauthor, int apages)
    {
      title = atitle;
      author = aauthor;
      pages = apages;
    }
  }
}