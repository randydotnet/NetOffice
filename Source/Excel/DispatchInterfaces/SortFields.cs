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
	/// DispatchInterface SortFields 
	/// SupportByVersion Excel, 12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837614.aspx </remarks>
	[SupportByVersion("Excel", 12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property, "Excel", 12, 14, 15, 16), HasIndexProperty(IndexInvoke.Property, "_Default")]
	[TypeId("000244AA-0000-0000-C000-000000000046")]
	public interface SortFields : ICOMObject, IEnumerableProvider<NetOffice.ExcelApi.SortField>
	{
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff198049.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		NetOffice.ExcelApi.Application Application { get; }

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff841278.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		NetOffice.ExcelApi.Enums.XlCreator Creator { get; }

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822134.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16), ProxyResult]
		object Parent { get; }

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196296.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		Int32 Count { get; }

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Excel", 12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		NetOffice.ExcelApi.SortField this[object index] { get; }

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836827.aspx </remarks>
		/// <param name="key">NetOffice.ExcelApi.Range key</param>
		/// <param name="sortOn">optional object sortOn</param>
		/// <param name="order">optional object order</param>
		/// <param name="customOrder">optional object customOrder</param>
		/// <param name="dataOption">optional object dataOption</param>
		[SupportByVersion("Excel", 12,14,15,16)]
		NetOffice.ExcelApi.SortField Add(NetOffice.ExcelApi.Range key, object sortOn, object order, object customOrder, object dataOption);

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836827.aspx </remarks>
		/// <param name="key">NetOffice.ExcelApi.Range key</param>
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		NetOffice.ExcelApi.SortField Add(NetOffice.ExcelApi.Range key);

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836827.aspx </remarks>
		/// <param name="key">NetOffice.ExcelApi.Range key</param>
		/// <param name="sortOn">optional object sortOn</param>
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		NetOffice.ExcelApi.SortField Add(NetOffice.ExcelApi.Range key, object sortOn);

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836827.aspx </remarks>
		/// <param name="key">NetOffice.ExcelApi.Range key</param>
		/// <param name="sortOn">optional object sortOn</param>
		/// <param name="order">optional object order</param>
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		NetOffice.ExcelApi.SortField Add(NetOffice.ExcelApi.Range key, object sortOn, object order);

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836827.aspx </remarks>
		/// <param name="key">NetOffice.ExcelApi.Range key</param>
		/// <param name="sortOn">optional object sortOn</param>
		/// <param name="order">optional object order</param>
		/// <param name="customOrder">optional object customOrder</param>
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		NetOffice.ExcelApi.SortField Add(NetOffice.ExcelApi.Range key, object sortOn, object order, object customOrder);

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839980.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		void Clear();

        #endregion

        #region IEnumerable<NetOffice.ExcelApi.SortField>

        /// <summary>
        /// SupportByVersion Excel, 12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        new IEnumerator<NetOffice.ExcelApi.SortField> GetEnumerator();

        #endregion
    }
}
