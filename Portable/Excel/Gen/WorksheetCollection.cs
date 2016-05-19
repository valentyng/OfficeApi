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
	public class WorksheetCollection: OfficeExtension.ClientObject
	{
		private Microsoft.ExcelServices.Worksheet[] m__items;

		/* Begin_PlaceHolder_WorksheetCollection_Custom_Members */
		/* End_PlaceHolder_WorksheetCollection_Custom_Members */
		public WorksheetCollection(OfficeExtension.ClientRequestContext context, OfficeExtension.ObjectPath objectPath)
			: base(context, objectPath)
		{
		}
		
		
		/* Gets the loaded child items in this collection. */
		public Microsoft.ExcelServices.Worksheet[] Items
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "items", this.m__items);
				return this.m__items;
			}
		}

		public Microsoft.ExcelServices.Worksheet Add(string name)
		{
			/* Begin_PlaceHolder_WorksheetCollection_Add */
			/* End_PlaceHolder_WorksheetCollection_Add */
			return new Microsoft.ExcelServices.Worksheet(this.Context, OfficeExtension.ObjectPathFactory._CreateMethodObjectPath(this.Context, this, "Add", OfficeExtension.OperationType.Default, new object[] {name}, false /*isCollection*/, true /*isInvalidAfterRequest*/));
		}

		public Microsoft.ExcelServices.Worksheet GetActiveWorksheet()
		{
			/* Begin_PlaceHolder_WorksheetCollection_GetActiveWorksheet */
			/* End_PlaceHolder_WorksheetCollection_GetActiveWorksheet */
			return new Microsoft.ExcelServices.Worksheet(this.Context, OfficeExtension.ObjectPathFactory._CreateMethodObjectPath(this.Context, this, "GetActiveWorksheet", OfficeExtension.OperationType.Read, new object[] {}, false /*isCollection*/, false /*isInvalidAfterRequest*/));
		}

		public Microsoft.ExcelServices.Worksheet GetItem(string key)
		{
			/* Begin_PlaceHolder_WorksheetCollection_GetItem */
			/* End_PlaceHolder_WorksheetCollection_GetItem */
			return new Microsoft.ExcelServices.Worksheet(this.Context, OfficeExtension.ObjectPathFactory._CreateIndexerObjectPath(this.Context, this, new object[] {key}));
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
			Newtonsoft.Json.Linq.JArray itemsData = obj[OfficeExtension.Constants.Items] as Newtonsoft.Json.Linq.JArray;
			if (itemsData != null)
			{
				this.LoadedPropertyNames.Add("items");
				this.m__items = new Microsoft.ExcelServices.Worksheet[itemsData.Count];
				for (var i = 0; i < itemsData.Count; i++)
				{
					var _item = new Microsoft.ExcelServices.Worksheet(this.Context, OfficeExtension.ObjectPathFactory._CreateChildItemObjectPathUsingIndexerOrGetItemAt(true, this.Context, this, itemsData[i], i));
					_item._HandleResult(itemsData[i]);
					this.m__items[i] = _item;
				}
			}
		}
		
		/*
		 * Queues up a command to load the specified properties of the object. You must call "context.sync()" before reading the properties.
		 */
		public Microsoft.ExcelServices.WorksheetCollection Load(OfficeExtension.LoadOption option) 
		{
			OfficeExtension.Utility._Load(this, option);
			return this;
		}
	}
}
