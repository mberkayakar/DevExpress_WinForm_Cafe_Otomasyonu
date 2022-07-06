using AKARCAFE.Business.Abstract;
using AKARCAFE.Business.Concrete;
using Autofac;

namespace AKARCAFE.DesktopUI.Ortak.IOC
{
    public static class MicrosoftIOC
    {



        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<GirisF>().As<IGiris>();
            builder.RegisterType<GelismeF>().As<IGelisme>();
            builder.RegisterType<SonucF>().As<ISonuc>();


            builder.RegisterType<Sonuc>();
            builder.RegisterType<Giris>();
            builder.RegisterType<Gelisme>();


            return builder.Build();

        }
    }
}
