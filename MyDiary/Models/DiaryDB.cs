using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace MyDiary.Models
{
    public class DiaryDB:DbContext
    {
        //映射数据库的表
        public DbSet<UserInfo> Users { get; set; }

        public DbSet<Diary> Diaries { get; set; }
    }
}