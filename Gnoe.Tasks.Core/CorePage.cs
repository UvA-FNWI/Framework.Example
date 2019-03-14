using Gnoe.Tasks.Core.Sections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UvA.Web;

namespace Gnoe.Tasks.Core
{
    public class CorePage : Page
    {
        public CorePage()
        {
            Title = "Tasks";

            Node = MainSection.GetNode();
        }

        protected override SectionContainer CreateContainer(Node node, PositionInfo pos = null)
        {
            return new CoreContainer(node, this, pos);
        }
    }
}
