using CreativeMinds.BRRegData.RestApi.Dtos;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreativeMinds.BRRegData.RestApi {

	public interface IBRRegSearchEngine {
		Task<SearchResponse> SearchForCompanyByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken);
	}
}
