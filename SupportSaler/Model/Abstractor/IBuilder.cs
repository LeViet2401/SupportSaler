using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportSaler.Model.Abstractor
{
    public interface IBuilder
    {
        void BuildLoginAccount();
        void BuildLike();
        void BuildComment();
        void BuildShare();
        void BuildPost();
        void BuildNewFeed();
        void BuildFindPage();
        void BuildFindGroup();
        void BuildLogoutAccount();

    }
}
