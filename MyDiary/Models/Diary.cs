using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyDiary.Models
{
    public class Diary
    {
        [DisplayName("编号")]
        public int Id { get; set; }
        [DisplayName("Title"),Required]
        public string Title { get; set; }
        [DisplayName("Content"),Required]
        public string Content { set; get; }
        [DisplayName("PubDate"),DataType(DataType.Date)]
        public DateTime? PubDate { get; set; }
        [DisplayName("UserId")]
        public int UserId { get; set; }

        //创建外键类
        [DisplayName("User")]
        public virtual UserInfo User { get; set; } 
    }
}