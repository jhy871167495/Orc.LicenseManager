using System.Data.Entity;
using Catel.Data.Repositories;
using Catel.Data;
using Catel.IoC;
using Orc.LicenseManager.Server.Repositories;
using Orc.LicenseManager.Server;

namespace Orc.LicenseManager.Server
{
	internal static partial class RepositoryInitializer
	{
		internal static void RegisterRepositories()
		{
            ServiceLocator.Default.RegisterType<ILicenseRepository, LicenseRepository>();
			}
	}
}