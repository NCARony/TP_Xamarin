using System;
using System.Collections.Generic;
using System.Text;
using xamarin1.models;

namespace xamarin1.services
{
    public interface ITwitterServices
    {
        String authenticate(User user);
        List<Tweet> Tweets { get; }
    }
}
