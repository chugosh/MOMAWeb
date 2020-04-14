using System;

namespace MoMaWeb.Models
{
    public class UserInfo
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public string Password{get;set;}
        public int AuthorityId {get;set;}
    }
}
