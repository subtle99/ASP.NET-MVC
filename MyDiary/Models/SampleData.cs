using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyDiary.Models
{
    public class SampleData:DropCreateDatabaseAlways<DiaryDB>
    {
        protected override void Seed(DiaryDB context)
        {
            context.Users.Add(new UserInfo
            {
                UserName = "user1",
                PassWord="admin",
                Diaries=new List<Diary>
                {
                    new Diary{Title="user1-title01",Content="user1-content01",PubDate=DateTime.Now},
                    new Diary{Title="user1-title02",Content="user1-content02",PubDate=DateTime.Now},
                    new Diary{Title="user1-title03",Content="user1-content03",PubDate=DateTime.Now},
                    new Diary{Title="user1-title04",Content="user1-content04",PubDate=DateTime.Now},
                }
            });
            context.Users.Add(new UserInfo
            {
                UserName = "user2",
                PassWord = "admin",
                Diaries = new List<Diary>
                {
                    new Diary{Title="user2-title01",Content="user2-content01",PubDate=DateTime.Now},
                    new Diary{Title="user2-title02",Content="user2-content02",PubDate=DateTime.Now},
                    new Diary{Title="user2-title03",Content="user2-content03",PubDate=DateTime.Now},
                    new Diary{Title="user2-title04",Content="user2-content04",PubDate=DateTime.Now},
                }
            });
            base.Seed(context);
        }
    }
}