using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tweetcool.Pages
{
    public class AllTweetsModel : PageModel
    {
        public static Dictionary<string, List<Tweet>> TweetDictionary { get; set; } = new Dictionary<string, List<Tweet>>();
        public void OnGet()
        {

        }
    }
}