using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelBloom.Models;

internal class Novel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public AppUser User { get; set; }
    public string ShortDescription { get; set; }

    public NovelSection NovelStory { get; set; }
}
