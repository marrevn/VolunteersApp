namespace VolunteersApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            bool exitProgram=false;
            while (!exitProgram)
            {
                using (var formLogin = new FormLogin())
                {
                    if (formLogin.ShowDialog() == DialogResult.OK)
                    {
                        using (var formEvents = new FormEvents(formLogin.CurrentUser, formLogin.IsGuest))
                        {
                            if (formEvents.ShowDialog() == DialogResult.Cancel)
                            {
                                continue;
                            }
                            else
                            {
                                exitProgram = true;
                            }
                        }
                    }
                    else
                    {
                        exitProgram = true;
                    }
                }
            }
        }
    }
}