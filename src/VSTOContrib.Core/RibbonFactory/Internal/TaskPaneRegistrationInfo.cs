using System;
using System.Windows.Forms;

namespace VSTOContrib.Core.RibbonFactory.Internal
{
    internal class TaskPaneRegistrationInfo
    {
        public Func<UserControl> ControlFactory { get; set; }
        public string Title { get; set; }

        public TaskPaneRegistrationInfo(Func<UserControl> controlFactory, string title)
        {
            ControlFactory = controlFactory;
            Title = title;
        }
    }
}