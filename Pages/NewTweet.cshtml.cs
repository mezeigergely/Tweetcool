using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tweetcool.Pages
{
    public class NewTweetModel : PageModel
    {
        public static Tweet Tweet { get; set; }
        public void OnGet()
        {
            List<Tweet> tweetList;
            if (AllTweetsModel.TweetDictionary.ContainsKey(Tweet.UserName))
            {
                tweetList = AllTweetsModel.TweetDictionary[Tweet.UserName];
            }

            else
            {
                tweetList = new List<Tweet>();
                AllTweetsModel.TweetDictionary[Tweet.UserName] = tweetList;
            }
            tweetList.Add(Tweet);
            

        }
    }
}