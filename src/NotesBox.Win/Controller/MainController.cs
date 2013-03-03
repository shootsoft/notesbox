using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotesBox.Win.Controller
{
    public class MainController
    {
        FormMain main;

        public MainController(FormMain main)
        {
            this.main = main;
        }

        public void CreateNewDocument()
        { 
            TabPage tab = new TabPage("New *");
            tab.BackColor = SystemColors.Control;
            this.main.tabControlDocument.TabPages.Add(tab);

            ScintillaNET.Scintilla editor = new ScintillaNET.Scintilla();
            editor.Dock = DockStyle.Fill;
            editor.TextChanged += main.Editor_TextChanged;
            editor.Margins[0].Width = 20;
            editor.LineWrapping.Mode = ScintillaNET.LineWrappingMode.Word;
            tab.Controls.Add(editor);
            
        }



        public void Initialize()
        {
            this.CreateNewDocument();            
        }

        public void HideNavigation()
        {
            this.main.splitContainerMain.Panel1Collapsed = true;
        }
    }
}
