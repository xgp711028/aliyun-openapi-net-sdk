/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.ROS.Model.V20190910
{
	public class GetStackResourceResponse : AcsResponse
	{

		private string createTime;

		private string description;

		private string logicalResourceId;

		private string metadata;

		private string physicalResourceId;

		private string requestId;

		private string resourceType;

		private string stackId;

		private string stackName;

		private string status;

		private string statusReason;

		private string updateTime;

		private List<Dictionary<string, string>> resourceAttributes;

		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		public string LogicalResourceId
		{
			get
			{
				return logicalResourceId;
			}
			set	
			{
				logicalResourceId = value;
			}
		}

		public string Metadata
		{
			get
			{
				return metadata;
			}
			set	
			{
				metadata = value;
			}
		}

		public string PhysicalResourceId
		{
			get
			{
				return physicalResourceId;
			}
			set	
			{
				physicalResourceId = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
			}
		}

		public string StackId
		{
			get
			{
				return stackId;
			}
			set	
			{
				stackId = value;
			}
		}

		public string StackName
		{
			get
			{
				return stackName;
			}
			set	
			{
				stackName = value;
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string StatusReason
		{
			get
			{
				return statusReason;
			}
			set	
			{
				statusReason = value;
			}
		}

		public string UpdateTime
		{
			get
			{
				return updateTime;
			}
			set	
			{
				updateTime = value;
			}
		}

		public List<Dictionary<string, string>> ResourceAttributes
		{
			get
			{
				return resourceAttributes;
			}
			set	
			{
				resourceAttributes = value;
			}
		}
	}
}
