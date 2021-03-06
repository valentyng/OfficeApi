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
	public class Worksheet: OfficeExtension.ClientObject
	{
		private Microsoft.ExcelServices.ChartCollection m_charts;
		private string m_id;
		private string m_name;
		private int m_position;
		private Microsoft.ExcelServices.WorksheetProtection m_protection;
		private Microsoft.ExcelServices.TableCollection m_tables;
		private string m_visibility;

		/* Begin_PlaceHolder_Worksheet_Custom_Members */
		/* End_PlaceHolder_Worksheet_Custom_Members */
		public Worksheet(OfficeExtension.ClientRequestContext context, OfficeExtension.ObjectPath objectPath)
			: base(context, objectPath)
		{
		}
		
		
		public Microsoft.ExcelServices.ChartCollection Charts
		{
			get
			{
				if (this.m_charts == null)
				{
					this.m_charts = new Microsoft.ExcelServices.ChartCollection(this.Context, OfficeExtension.ObjectPathFactory._CreatePropertyObjectPath(this.Context, this, "Charts", true /*isCollection*/, false /*isInvalidAfterRequest*/));	
				}
		
				return this.m_charts;
			}
		}
		
		public Microsoft.ExcelServices.WorksheetProtection Protection
		{
			get
			{
				if (this.m_protection == null)
				{
					this.m_protection = new Microsoft.ExcelServices.WorksheetProtection(this.Context, OfficeExtension.ObjectPathFactory._CreatePropertyObjectPath(this.Context, this, "Protection", false /*isCollection*/, false /*isInvalidAfterRequest*/));	
				}
		
				return this.m_protection;
			}
		}
		
		public Microsoft.ExcelServices.TableCollection Tables
		{
			get
			{
				if (this.m_tables == null)
				{
					this.m_tables = new Microsoft.ExcelServices.TableCollection(this.Context, OfficeExtension.ObjectPathFactory._CreatePropertyObjectPath(this.Context, this, "Tables", true /*isCollection*/, false /*isInvalidAfterRequest*/));	
				}
		
				return this.m_tables;
			}
		}

		public string Id
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "id", this.m_id);
				return this.m_id;
			}
		}

		public string Name
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "name", this.m_name);
				return this.m_name;
			}

			set
			{
				this.m_name = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "Name", value);
			}
		}

		public int Position
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "position", this.m_position);
				return this.m_position;
			}

			set
			{
				this.m_position = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "Position", value);
			}
		}

		public string Visibility
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "visibility", this.m_visibility);
				return this.m_visibility;
			}

			set
			{
				this.m_visibility = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "Visibility", value);
			}
		}

		public void Activate()
		{
			/* Begin_PlaceHolder_Worksheet_Activate */
			/* End_PlaceHolder_Worksheet_Activate */
			OfficeExtension.ActionFactory._CreateMethodAction(this.Context, this, "Activate", OfficeExtension.OperationType.Read, new object[] {});
		}

		public void Delete()
		{
			/* Begin_PlaceHolder_Worksheet_Delete */
			/* End_PlaceHolder_Worksheet_Delete */
			OfficeExtension.ActionFactory._CreateMethodAction(this.Context, this, "Delete", OfficeExtension.OperationType.Default, new object[] {});
		}

		public Microsoft.ExcelServices.Range GetCell(int row, int column)
		{
			/* Begin_PlaceHolder_Worksheet_GetCell */
			/* End_PlaceHolder_Worksheet_GetCell */
			return new Microsoft.ExcelServices.Range(this.Context, OfficeExtension.ObjectPathFactory._CreateMethodObjectPath(this.Context, this, "GetCell", OfficeExtension.OperationType.Read, new object[] {row, column}, false /*isCollection*/, true /*isInvalidAfterRequest*/));
		}

		public Microsoft.ExcelServices.Range GetRange(string address)
		{
			/* Begin_PlaceHolder_Worksheet_GetRange */
			/* End_PlaceHolder_Worksheet_GetRange */
			return new Microsoft.ExcelServices.Range(this.Context, OfficeExtension.ObjectPathFactory._CreateMethodObjectPath(this.Context, this, "GetRange", OfficeExtension.OperationType.Read, new object[] {address}, false /*isCollection*/, true /*isInvalidAfterRequest*/));
		}

		public Microsoft.ExcelServices.Range GetUsedRange(bool valuesOnly)
		{
			/* Begin_PlaceHolder_Worksheet_GetUsedRange */
			/* End_PlaceHolder_Worksheet_GetUsedRange */
			return new Microsoft.ExcelServices.Range(this.Context, OfficeExtension.ObjectPathFactory._CreateMethodObjectPath(this.Context, this, "GetUsedRange", OfficeExtension.OperationType.Read, new object[] {valuesOnly}, false /*isCollection*/, true /*isInvalidAfterRequest*/));
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
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Name"]))
			{
				this.LoadedPropertyNames.Add("Name");
				this.m_name = obj["Name"].ToObject<string>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Position"]))
			{
				this.LoadedPropertyNames.Add("Position");
				this.m_position = obj["Position"].ToObject<int>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Visibility"]))
			{
				this.LoadedPropertyNames.Add("Visibility");
				this.m_visibility = obj["Visibility"].ToObject<string>();
			}
		
		    if (!OfficeExtension.Utility._IsUndefined(obj["Charts"]))
			{
		        this.Charts._HandleResult(obj["Charts"]);
			}
		    if (!OfficeExtension.Utility._IsUndefined(obj["Protection"]))
			{
		        this.Protection._HandleResult(obj["Protection"]);
			}
		    if (!OfficeExtension.Utility._IsUndefined(obj["Tables"]))
			{
		        this.Tables._HandleResult(obj["Tables"]);
			}
		}
		
		/*
		 * Queues up a command to load the specified properties of the object. You must call "context.sync()" before reading the properties.
		 */
		public Microsoft.ExcelServices.Worksheet Load(OfficeExtension.LoadOption option) 
		{
			OfficeExtension.Utility._Load(this, option);
			return this;
		}
	}
}

