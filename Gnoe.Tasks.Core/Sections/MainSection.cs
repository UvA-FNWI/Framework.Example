using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UvA.Web;

namespace Gnoe.Tasks.Core.Sections
{
    class MainSection : CoreSection
    {
        public static Node GetNode()
        {
            var node = new Node("", typeof(MainSection));
            return node;
        }

        public MainSection(CoreContainer container)
        {
            Container = container;

            Children.Add("Hello world!");
        }
    }
}
