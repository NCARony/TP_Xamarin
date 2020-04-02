using System;
using System.Collections.Generic;
using System.Text;

namespace xamarin1.models
{
    public class Tweet
    {
        private User user;
        private String text;
        private String createdDate;


        public User User
        {
            get { return user; }
            set { user = value; }
        }
        public String Text
        {
            get { return text; }
            set { text = value; }
        }
        public String CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
    }
}
