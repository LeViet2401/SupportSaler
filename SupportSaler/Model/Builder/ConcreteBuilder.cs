using SupportSaler.Model.Abstractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportSaler.Model.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private WebAction _webAction = new WebAction();
        private MyAccount _account = new MyAccount();

        public ConcreteBuilder(MyAccount account)
        {
            this.Reset();
            _account = account;
        }

        public void Reset()
        {
            this._webAction = new WebAction();
        }


        public void BuildLoginAccount()
        {
            LoginAccount login = new LoginAccount(_account);
            this._webAction.Add(login);
        }

        public void BuildLike()
        {
            Like like = new Like();
            this._webAction.Add(like);
        }

        public void BuildComment()
        {
            Comment comment = new Comment();
            this._webAction.Add(comment);
        }

        public void BuildShare()
        {
            Share share = new Share();
            this._webAction.Add(share);
        }

        public void BuildPost()
        {
            Post post = new Post();
            this._webAction.Add(post);
        }

        public void BuildNewFeed()
        {
            NewFeed newFeed = new NewFeed();
            this._webAction.Add(newFeed);
        }

        public void BuildFindPage()
        {
            FindPage findPage = new FindPage();
            this._webAction.Add(findPage);
        }

        public void BuildFindGroup()
        {
            FindGroup findGroup = new FindGroup();
            this._webAction.Add(findGroup);
        }

        public void BuildLogoutAccount()
        {
            LogoutAccount logoutAccount = new LogoutAccount();
            this._webAction.Add(logoutAccount);
        }


        public WebAction GetProduct()
        {
            WebAction result = this._webAction;

            this.Reset();

            return result;
        }
    }
}
