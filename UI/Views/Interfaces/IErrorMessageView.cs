using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Views.Interfaces
{
    public interface IErrorMessageView
    {
        void ShowErrorMessageView(string errorMessage);
        void CloseErrorMessageView();
        
        event Action CloseErrorMessageViewEventRaised;
    }
}
