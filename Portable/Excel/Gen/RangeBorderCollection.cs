﻿/*
 * This is a generated file. 
 * If there are content placeholders, only edit content inside content placeholders.
 * If there are no content placeholders, do not edit this file directly.
 */
namespace Microsoft.ExcelServices
{
	using System;
	/* Begin_PlaceHolder_UsingHeader */
	/* End_PlaceHolder_UsingHeader */

	/* Begin_PlaceHolder_Header */
	/* End_PlaceHolder_Header */
	public class RangeBorderCollection: OfficeExtension.ClientObject
	{
		private int m_count;
		private Microsoft.ExcelServices.RangeBorder[] m__items;

		/* Begin_PlaceHolder_RangeBorderCollection_Custom_Members */
		/* End_PlaceHolder_RangeBorderCollection_Custom_Members */
		public RangeBorderCollection(OfficeExtension.ClientRequestContext context, OfficeExtension.ObjectPath objectPath)
			: base(context, objectPath)
		{
		}
		
		
		/* Gets the loaded child items in this collection. */
		public Microsoft.ExcelServices.RangeBorder[] Items
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "items", this.m__items);
				return this.m__items;
			}
		}

		public int Count
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "count", this.m_count);
				return this.m_count;
			}
		}

		public Microsoft.ExcelServices.RangeBorder GetItem(string index)
		{
			/* Begin_PlaceHolder_RangeBorderCollection_GetItem */
			/* End_PlaceHolder_RangeBorderCollection_GetItem */
			return new Microsoft.ExcelServices.RangeBorder(this.Context, OfficeExtension.ObjectPathFactory._CreateIndexerObjectPath(this.Context, this, new object[] {index}));
		}

		public Microsoft.ExcelServices.RangeBorder GetItemAt(int index)
		{
			/* Begin_PlaceHolder_RangeBorderCollection_GetItemAt */
			/* End_PlaceHolder_RangeBorderCollection_GetItemAt */
			return new Microsoft.ExcelServices.RangeBorder(this.Context, OfficeExtension.ObjectPathFactory._CreateMethodObjectPath(this.Context, this, "GetItemAt", OfficeExtension.OperationType.Read, new object[] {index}, false /*isCollection*/, false /*isInvalidAfterRequest*/));
		}

			/** Handle results returned from the document
			 */
		public override void _HandleResult(Newtonsoft.Json.Linq.JToken value)
		{
			if (OfficeExtension.Utility._IsNullOrUndefined(value))
			{
				return;
			}
			Newtonsoft.Json.Linq.JObject obj = value as Newtonsoft.Json.Linq.JObject;
			if (obj == null)
			{
				return;
			}
		
			OfficeExtension.Utility._FixObjectPathIfNecessary(this, obj);
			if (!OfficeExtension.Utility._IsUndefined(obj["Count"]))
			{
				this.LoadedPropertyNames.Add("Count");
				this.m_count = obj["Count"].ToObject<int>();
			}
		
			Newtonsoft.Json.Linq.JArray itemsData = obj[OfficeExtension.Constants.Items] as Newtonsoft.Json.Linq.JArray;
			if (itemsData != null)
			{
				this.LoadedPropertyNames.Add("items");
				this.m__items = new Microsoft.ExcelServices.RangeBorder[itemsData.Count];
				for (var i = 0; i < itemsData.Count; i++)
				{
					var _item = new Microsoft.ExcelServices.RangeBorder(this.Context, OfficeExtension.ObjectPathFactory._CreateChildItemObjectPathUsingIndexerOrGetItemAt(true, this.Context, this, itemsData[i], i));
					_item._HandleResult(itemsData[i]);
					this.m__items[i] = _item;
				}
			}
		}
		
		/*
		 * Queues up a command to load the specified properties of the object. You must call "context.sync()" before reading the properties.
		 */
		public Microsoft.ExcelServices.RangeBorderCollection Load(OfficeExtension.LoadOption option) 
		{
			OfficeExtension.Utility._Load(this, option);
			return this;
		}
	}
}

