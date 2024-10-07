using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelBloom.Models;

internal class Novel
{
    public string Title { get; set; }
    public AppUser User { get; set; }
    public string ShortDescription { get; set; }
    public NovelStory NovelStory { get; set; }
}
