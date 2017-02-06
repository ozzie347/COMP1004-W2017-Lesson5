using System.Windows.Forms;

namespace COMP1004_W2017_Lesson5
{
    class Program
    {
        //declared public static Form - Application GLOBAL
        public static SplashForm MySplashForm;

        public static Calculator MyCalculatorForm

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //initialize splash form
            Program.MySplashForm = new SplashForm();
            Program.MyCalculatorForm = new Calculator();

            //
            Application.Run(Program.MySplashForm);
        }
    }
}
