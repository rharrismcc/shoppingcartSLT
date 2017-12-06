using StructureMap;
using shoppingcart.Models;

namespace shoppingcart {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            //                x.For<IExample>().Use<Example>();

                            //  this is for SQLITE
                            //x.For<ICartDbContext>().Use<CartDbContext>();

                            //  this is for MS SQL SERVER
                            x.For<ICartDbContext>().Use<MSCartDbContext>();
                        });
            return ObjectFactory.Container;
        }
    }
}