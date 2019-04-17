using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyDiary.Models
{
    public class UserInfo
    {
        //追加显示和验证注解
        [DisplayName("Id")]
        public int Id { set; get; }
        [DisplayName("UserName"),Required]
        //required ：用户名不能为空
        public string UserName { set; get; }
        [DisplayName("PassWord"),Required,DataType(DataType.Password)]
        //DataType(DataType.Password)  密码不会以明文的形式显示
        public string PassWord { set; get; }

        [DisplayName("Diaries")]
        //日志集合
        public virtual List<Diary> Diaries { get; set; }
    }
}