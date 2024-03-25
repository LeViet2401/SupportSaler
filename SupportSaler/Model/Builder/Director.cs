using SupportSaler.Model.Abstractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportSaler.Model.Builder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalViableProduct()
        {
            this._builder.BuildLoginAccount();
            this._builder.BuildLogoutAccount();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildLoginAccount();
            this._builder.BuildLike();
            this._builder.BuildComment();
            this._builder.BuildShare();
            this._builder.BuildPost();
            this._builder.BuildNewFeed();
            this._builder.BuildFindPage();
            this._builder.BuildFindGroup();
            this._builder.BuildLogoutAccount();
        }
    }
}
