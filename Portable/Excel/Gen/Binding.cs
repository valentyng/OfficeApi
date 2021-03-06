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
	public class Binding: OfficeExtension.ClientObject
	{
		private string m_id;
		private string m_type;

		/* Begin_PlaceHolder_Binding_Custom_Members */
		/* End_PlaceHolder_Binding_Custom_Members */
		public Binding(OfficeExtension.ClientRequestContext context, OfficeExtension.ObjectPath objectPath)
			: base(context, objectPath)
		{
		}
		

		public string Id
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "id", this.m_id);
				return this.m_id;
			}
		}

		public string Type
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "type", this.m_type);
				return this.m_type;
			}
		}

		public Microsoft.ExcelServices.Range GetRange()
		{
			/* Begin_PlaceHolder_Binding_GetRange */
			/* End_PlaceHolder_Binding_GetRange */
			return new Microsoft.ExcelServices.Range(this.Context, OfficeExtension.ObjectPathFactory._CreateMethodObjectPath(this.Context, this, "GetRange", OfficeExtension.OperationType.Read, new object[] {}, false /*isCollection*/, false /*isInvalidAfterRequest*/));
		}

		public Microsoft.ExcelServices.Table GetTable()
		{
			/* Begin_PlaceHolder_Binding_GetTable */
			/* End_PlaceHolder_Binding_GetTable */
			return new Microsoft.ExcelServices.Table(this.Context, OfficeExtension.ObjectPathFactory._CreateMethodObjectPath(this.Context, this, "GetTable", OfficeExtension.OperationType.Read, new object[] {}, false /*isCollection*/, false /*isInvalidAfterRequest*/));
		}

		public OfficeExtension.ClientResult< string > GetText()
		{
			/* Begin_PlaceHolder_Binding_GetText */
			/* End_PlaceHolder_Binding_GetText */
			var action = OfficeExtension.ActionFactory._CreateMethodAction(this.Context, this, "GetText", OfficeExtension.OperationType.Read, new object[] {});
			var ret = new OfficeExtension.ClientResult< string >();
			OfficeExtension.Utility._AddActionResultHandler(this, action, ret);
			return ret;
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
			if (!OfficeExtension.Utility._IsUndefined(obj["Id"]))
			{
				this.LoadedPropertyNames.Add("Id");
				this.m_id = obj["Id"].ToObject<string>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Type"]))
			{
				this.LoadedPropertyNames.Add("Type");
				this.m_type = obj["Type"].ToObject<string>();
			}
		
		}
		
		/*
		 * Queues up a command to load the specified properties of the object. You must call "context.sync()" before reading the properties.
		 */
		public Microsoft.ExcelServices.Binding Load(OfficeExtension.LoadOption option) 
		{
			OfficeExtension.Utility._Load(this, option);
			return this;
		}
	}
}

