namespace Tool.Compet.Json {
	using System.Text.Json;

	/// Json helper for converter Json vs Object.
	/// See https://www.jacksondunstan.com/articles/3303 to choose best approach on each serialize/deserialize.
	/// For eg,.
	/// - Serialize an object to json => Lit is optimal
	/// - Deserialize small string => Unity is optimal
	/// - Deserialize large string => Newton is optimal
	public class DkJsons {
		public static string Obj2Json(object serializableObj) {
			return JsonSerializer.Serialize(serializableObj);
		}
	
		/// Caller should add `where T : class` to its function to allow return nullable value.
		public static T? Json2Obj<T>(string json) where T : class {
			return JsonSerializer.Deserialize<T>(json);
		}
	}
}
