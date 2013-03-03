using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NotesBox.Win
{
    static class Program
    {
        //icon file http://www.iconfinder.com/icondetails/37604/128/classroom_language_school_student_teacher_icon

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
