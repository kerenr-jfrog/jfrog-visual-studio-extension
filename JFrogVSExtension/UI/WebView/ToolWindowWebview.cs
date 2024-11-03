using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;

namespace JFrogVSExtension.UI.WebView
{
    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("2f502489-d28f-4f13-b3e9-7c27c22edc2d")]
    public class ToolWindowWebview : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolWindowWebview"/> class.
        /// </summary>
        public ToolWindowWebview() : base(null)
        {
            this.Caption = "Jfrog";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = new ToolWindowWebviewControl();
        }
    }
}
