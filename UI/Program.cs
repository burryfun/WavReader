using System;
using System.Windows.Forms;
using UI.Presenters.Interfaces;
using UI.Presenters;
using UI.Views.Interfaces;
using UI.Views;
using Unity;
using Unity.Lifetime;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = new UnityContainer()
            .RegisterType<IMainPresenter, MainPresenter>(new ContainerControlledLifetimeManager())
            .RegisterType<IMainView, MainView>(new ContainerControlledLifetimeManager())
            .RegisterType<IRightChannelView, RightChannelView>(new ContainerControlledLifetimeManager())
            .RegisterType<IMetadataPresenter, MetadataPresenter>(new ContainerControlledLifetimeManager())
            .RegisterType<IMetadataView, MetadataView>(new ContainerControlledLifetimeManager());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainPresenter mainPresenter = container.Resolve<MainPresenter>();
            IMainView mainView = mainPresenter.GetMainView();
            Application.Run((MainView)mainView);
        }
    }
}
