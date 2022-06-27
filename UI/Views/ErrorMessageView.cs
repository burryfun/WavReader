using System;
using System.Windows.Forms;
using UI.Views.Interfaces;

namespace UI.Views
{
    public partial class ErrorMessageView : Form, IErrorMessageView
    {
        public ErrorMessageView()
        {
            InitializeComponent();

            CloseButton.Click += (sender, args) => Invoke(CloseErrorMessageViewEventRaised);
        }

        public event Action CloseErrorMessageViewEventRaised;

        public void CloseErrorMessageView()
        {
            Close();
        }

        public void ShowErrorMessageView(string errorMessage)
        {
            ErrorMessageTextBox.Text = errorMessage;
            ShowDialog();
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }
    }
}
