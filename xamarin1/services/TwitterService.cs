using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xamarin1.models;

namespace xamarin1.services
{
    public class TwitterService : ITwitterServices
    {

        public List<Tweet> Tweets
        {
            get
            {
                User user = new User() { Login = "bart", Password = "password" };
                return new List<Tweet>()
                {
                new Tweet() {
                CreatedDate = "" + DateTime.Now + "",
                Text = "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression.",
                User = user, },

                new Tweet() {
                CreatedDate = "" + DateTime.Now + "",
                Text = " Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500",
                User = user, },

                new Tweet() {
                CreatedDate = "" + DateTime.Now + "",
                Text = "quand un imprimeur anonyme assembla ensemble des morceaux de texte pour réaliser un livre spécimen de polices de texte.",
                User = user, },

                new Tweet() {
                CreatedDate = "" + DateTime.Now + "",
                Text = "Il n'a pas fait que survivre cinq siècles, mais s'est aussi adapté à la bureautique informatique.",
                User = user, }
                };
            }
        }

        public String authenticate(User user)
        {
            bool showError = false;
            StringBuilder stringBuilder = new StringBuilder();

            if (String.IsNullOrEmpty(user.Login) || user.Login.Length < 3)
            {
                showError = true;
                stringBuilder.Append("L'identifiant ne peut pas être null et doit posséder au moins 3 caractères.");
            }

            if (String.IsNullOrEmpty(user.Password) || user.Password.Length < 6)
            {
                if (showError)
                {
                    stringBuilder.Append("\n");
                }
                showError = true;
                stringBuilder.Append("Le mot de passe ne peut pas être null et doit posséder au moins 6 caractères.");
            }

            if (!Tweets.Select(x => x.User).Any(x => x.Login == user.Login && x.Password == user.Password))
            {
                if (showError)
                {
                    stringBuilder.Append("\n");
                }
                showError = true;
                stringBuilder.Append("L'utilisateur n'existe pas.");
            }

            return stringBuilder.ToString();
        }
    }
}
