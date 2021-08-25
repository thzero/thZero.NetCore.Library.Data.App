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

namespace thZero.Data
{
    public abstract class BaseData
	{
		public virtual void Map(BaseData data)
		{
			Enforce.AgainstNull(() => data);

			_id = data._id;
			Id = data.Id;
			CreatedTimestamp = data.CreatedTimestamp;
			CreatedUserId = data.CreatedUserId;
			UpdatedTimestamp = data.UpdatedTimestamp;
			UpdatedUserId = data.UpdatedUserId;
		}

		#region Public Properties
#pragma warning disable IDE1006 // Naming Styles
		public string _id { get; set; }
#pragma warning restore IDE1006 // Naming Styles
		public string Id { get; set; }
		public long CreatedTimestamp { get; set; }
		public string CreatedUserId { get; set; }
		public long UpdatedTimestamp { get; set; }
		public string UpdatedUserId { get; set; }
		#endregion
    }
}
