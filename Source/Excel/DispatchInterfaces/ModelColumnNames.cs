﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;

namespace NetOffice.ExcelApi
{
	/// <summary>
	/// DispatchInterface ModelColumnNames 
	/// SupportByVersion Excel, 15, 16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj228628.aspx </remarks>
	[SupportByVersion("Excel", 15, 16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property, "Excel", 15, 16), HasIndexProperty(IndexInvoke.Property, "_Default")]
	[TypeId("000244E6-0000-0000-C000-000000000046")]
	public interface ModelColumnNames : ICOMObject, IEnumerableProvider<NetOffice.ExcelApi.ModelColumnName>
	{
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj227432.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		NetOffice.ExcelApi.Application Application { get; }

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj227816.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		NetOffice.ExcelApi.Enums.XlCreator Creator { get; }

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj229521.aspx </remarks>
		[SupportByVersion("Excel", 15, 16), ProxyResult]
		object Parent { get; }

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj227341.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		Int32 Count { get; }

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Excel", 15, 16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		NetOffice.ExcelApi.ModelColumnName this[object index] { get; }

        #endregion

        #region IEnumerable<NetOffice.ExcelApi.ModelColumnName>

        /// <summary>
        /// SupportByVersion Excel, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        new IEnumerator<NetOffice.ExcelApi.ModelColumnName> GetEnumerator();

        #endregion
    }
}
