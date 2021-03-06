/* ------------------------------------------------------------------------- *
thZero.NetCore.Library.Data.App
Copyright (C) 2021-2021 thZero.com

<development [at] thzero [dot] com>

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

	http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
 * ------------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace thZero.Data
{
    public abstract class BaseUserData<TSettings> : BaseData
	{
		#region Public Properties
		public ExternalUserData External { get; set; }
		public string PlanId { get; set; }
		[JsonIgnore]
		public BasePlanData Plan { get; set; }
		public ICollection<string> Roles { get; set; } = new List<string>();
		public TSettings Settings { get; set; }
		#endregion
	}

	public class ExternalUserData
	{
		public ExternalUserData()
        {
		}
		public ExternalUserData(string id)
		{
			Id = id;
		}

		#region Public Properties
		public string Email { get; set; }
		public string Id { get; set; }
		public string Name { get; set; }
		public string Picture { get; set; }
		#endregion
	}
}
