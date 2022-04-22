namespace MAT.ControleEstoque.App.Extensions
{
    public static class FormUtils
    {
        public static bool CloseMain { get; set; } = false;

        public static F GetForm<F>() where F : Form
        {
            return (F)Program.ServiceProvider.GetService(typeof(F));
        }

        public static void AlertError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void AlertWarning(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void OpenTab(Form form, string title)
        {
            if (OpenTabEvent != null)
                OpenTabEvent(form, title);
        }

        public delegate void OpenTabDelegate(Form form, string title);

        public static event OpenTabDelegate OpenTabEvent;

    }
}
