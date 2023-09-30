//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CreativeMinds.BRRegData.RestApi.Extensions {

//	public static class ServiceCollectionExtensions {

//		public static IServiceCollection AddCVRElasticSearch(this IServiceCollection services, IConfiguration configuration) {
//			services.Configure<BRRegDataSettingsReader>(configuration.GetSection("BRRegData"));
//			services.AddTransient<IBRRegDataSettings, BRRegDataSettingsBridge>();

//			//services.AddScoped<ISearchEngine, RawHttpSearchEngine>();
//			services.AddSingleton<IBRRegSearchEngine, BRRegRestApiSearchEngine>();

//			return services;
//		}
//	}
//}
