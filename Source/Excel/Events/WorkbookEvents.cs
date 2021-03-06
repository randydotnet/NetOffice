﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;
using NetOffice.Attributes;

namespace NetOffice.ExcelApi.EventContracts
{
    /// <summary>
    /// WorkbookEvents
    /// </summary>
    [SupportByVersion("Excel", 9,10,11,12,14,15,16)]
    [InternalEntity(InternalEntityKind.ComEventInterface)]
    [ComImport, Guid("00024412-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface WorkbookEvents
	{
        /// <summary>
        /// Open
        /// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(682)]
		void Open();

        /// <summary>
        /// Activate
        /// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(304)]
		void Activate();

        /// <summary>
        /// Deactivate
        /// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1530)]
		void Deactivate();

        /// <summary>
        /// BeforeClose
        /// </summary>
        /// <param name="cancel"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("cancel", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1546)]
		void BeforeClose([In] [Out] ref object cancel);

        /// <summary>
        /// BeforeSave
        /// </summary>
        /// <param name="saveAsUI"></param>
        /// <param name="cancel"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("saveAsUI", SinkArgumentType.Bool)]
        [SinkArgument("cancel", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1547)]
		void BeforeSave([In] object saveAsUI, [In] [Out] ref object cancel);

        /// <summary>
        /// BeforePrint
        /// </summary>
        /// <param name="cancel"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("cancel", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1549)]
		void BeforePrint([In] [Out] ref object cancel);

        /// <summary>
        /// NewSheet
        /// </summary>
        /// <param name="sh"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1550)]
		void NewSheet([In, MarshalAs(UnmanagedType.IDispatch)] object sh);

        /// <summary>
        /// AddinInstall
        /// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1552)]
		void AddinInstall();

        /// <summary>
        /// AddinUninstall
        /// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1553)]
		void AddinUninstall();

        /// <summary>
        /// WindowResize
        /// </summary>
        /// <param name="wn"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("wn", typeof(ExcelApi.Window))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1554)]
		void WindowResize([In, MarshalAs(UnmanagedType.IDispatch)] object wn);

        /// <summary>
        /// WindowActivate
        /// </summary>
        /// <param name="wn"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("wn", typeof(ExcelApi.Window))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1556)]
		void WindowActivate([In, MarshalAs(UnmanagedType.IDispatch)] object wn);

        /// <summary>
        /// WindowDeactivate
        /// </summary>
        /// <param name="wn"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("wn", typeof(ExcelApi.Window))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1557)]
		void WindowDeactivate([In, MarshalAs(UnmanagedType.IDispatch)] object wn);

        /// <summary>
        /// SheetSelectionChange
        /// </summary>
        /// <param name="sh"></param>
        /// <param name="target"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [SinkArgument("target", typeof(ExcelApi.Range))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1558)]
		void SheetSelectionChange([In, MarshalAs(UnmanagedType.IDispatch)] object sh, [In, MarshalAs(UnmanagedType.IDispatch)] object target);

        /// <summary>
        /// SheetBeforeDoubleClick
        /// </summary>
        /// <param name="sh"></param>
        /// <param name="target"></param>
        /// <param name="cancel"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [SinkArgument("target", typeof(ExcelApi.Range))]
        [SinkArgument("cancel", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1559)]
		void SheetBeforeDoubleClick([In, MarshalAs(UnmanagedType.IDispatch)] object sh, [In, MarshalAs(UnmanagedType.IDispatch)] object target, [In] [Out] ref object cancel);

        /// <summary>
        /// SheetBeforeRightClick
        /// </summary>
        /// <param name="sh"></param>
        /// <param name="target"></param>
        /// <param name="cancel"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [SinkArgument("target", typeof(ExcelApi.Range))]
        [SinkArgument("cancel", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1560)]
		void SheetBeforeRightClick([In, MarshalAs(UnmanagedType.IDispatch)] object sh, [In, MarshalAs(UnmanagedType.IDispatch)] object target, [In] [Out] ref object cancel);

        /// <summary>
        /// SheetActivate
        /// </summary>
        /// <param name="sh"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1561)]
		void SheetActivate([In, MarshalAs(UnmanagedType.IDispatch)] object sh);

        /// <summary>
        /// SheetDeactivate
        /// </summary>
        /// <param name="sh"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1562)]
		void SheetDeactivate([In, MarshalAs(UnmanagedType.IDispatch)] object sh);

        /// <summary>
        /// SheetCalculate
        /// </summary>
        /// <param name="sh"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1563)]
		void SheetCalculate([In, MarshalAs(UnmanagedType.IDispatch)] object sh);

        /// <summary>
        /// SheetChange
        /// </summary>
        /// <param name="sh"></param>
        /// <param name="target"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [SinkArgument("target", typeof(ExcelApi.Range))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1564)]
		void SheetChange([In, MarshalAs(UnmanagedType.IDispatch)] object sh, [In, MarshalAs(UnmanagedType.IDispatch)] object target);

        /// <summary>
        /// SheetFollowHyperlink
        /// </summary>
        /// <param name="sh"></param>
        /// <param name="target"></param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [SinkArgument("target", typeof(ExcelApi.Hyperlink))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1854)]
		void SheetFollowHyperlink([In, MarshalAs(UnmanagedType.IDispatch)] object sh, [In, MarshalAs(UnmanagedType.IDispatch)] object target);

        /// <summary>
        /// SheetPivotTableUpdate
        /// </summary>
        /// <param name="sh"></param>
        /// <param name="target"></param>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [SinkArgument("target", typeof(ExcelApi.PivotTable))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2157)]
		void SheetPivotTableUpdate([In, MarshalAs(UnmanagedType.IDispatch)] object sh, [In, MarshalAs(UnmanagedType.IDispatch)] object target);

        /// <summary>
        /// PivotTableCloseConnection
        /// </summary>
        /// <param name="target"></param>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
        [SinkArgument("target", typeof(ExcelApi.PivotTable))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2158)]
		void PivotTableCloseConnection([In, MarshalAs(UnmanagedType.IDispatch)] object target);

        /// <summary>
        /// PivotTableOpenConnection
        /// </summary>
        /// <param name="target"></param>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
        [SinkArgument("target", typeof(ExcelApi.PivotTable))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2159)]
		void PivotTableOpenConnection([In, MarshalAs(UnmanagedType.IDispatch)] object target);

        /// <summary>
        /// Sync
        /// </summary>
        /// <param name="syncEventType"></param>
        [SupportByVersion("Excel", 11,12,14,15,16)]
        [SinkArgument("syncEventType", SinkArgumentType.Enum, typeof(OfficeApi.Enums.MsoSyncEventType))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2266)]
		void Sync([In] object syncEventType);

        /// <summary>
        /// BeforeXmlImport
        /// </summary>
        /// <param name="map"></param>
        /// <param name="url"></param>
        /// <param name="isRefresh"></param>
        /// <param name="cancel"></param>
        [SupportByVersion("Excel", 11,12,14,15,16)]
        [SinkArgument("map", typeof(ExcelApi.XmlMap))]
        [SinkArgument("url", SinkArgumentType.String)]
        [SinkArgument("isRefresh", SinkArgumentType.Bool)]
        [SinkArgument("cancel", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2283)]
		void BeforeXmlImport([In, MarshalAs(UnmanagedType.IDispatch)] object map, [In] object url, [In] object isRefresh, [In] [Out] ref object cancel);

        /// <summary>
        /// AfterXmlImport
        /// </summary>
        /// <param name="map"></param>
        /// <param name="isRefresh"></param>
        /// <param name="result"></param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
        [SinkArgument("map", typeof(ExcelApi.XmlMap))]
        [SinkArgument("isRefresh", SinkArgumentType.Bool)]
        [SinkArgument("result", SinkArgumentType.Enum, typeof(ExcelApi.Enums.XlXmlImportResult))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2285)]
		void AfterXmlImport([In, MarshalAs(UnmanagedType.IDispatch)] object map, [In] object isRefresh, [In] object result);

        /// <summary>
        /// BeforeXmlExport
        /// </summary>
        /// <param name="map"></param>
        /// <param name="url"></param>
        /// <param name="cancel"></param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
        [SinkArgument("map", typeof(ExcelApi.XmlMap))]
        [SinkArgument("url", SinkArgumentType.String)]
        [SinkArgument("cancel", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2287)]
		void BeforeXmlExport([In, MarshalAs(UnmanagedType.IDispatch)] object map, [In] object url, [In] [Out] ref object cancel);

        /// <summary>
        /// AfterXmlExport
        /// </summary>
        /// <param name="map"></param>
        /// <param name="url"></param>
        /// <param name="result"></param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
        [SinkArgument("map", typeof(ExcelApi.XmlMap))]
        [SinkArgument("url", SinkArgumentType.String)]
        [SinkArgument("cancel", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2288)]
		void AfterXmlExport([In, MarshalAs(UnmanagedType.IDispatch)] object map, [In] object url, [In] object result);

        /// <summary>
        /// RowsetComplete
        /// </summary>
        /// <param name="description"></param>
        /// <param name="sheet"></param>
        /// <param name="success"></param>
		[SupportByVersion("Excel", 12,14,15,16)]
        [SinkArgument("description", SinkArgumentType.String)]
        [SinkArgument("sheet", SinkArgumentType.String)]
        [SinkArgument("success", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2610)]
		void RowsetComplete([In] object description, [In] object sheet, [In] object success);

        /// <summary>
        /// SheetPivotTableAfterValueChange
        /// </summary>
        /// <param name="sh"></param>
        /// <param name="targetPivotTable"></param>
        /// <param name="targetRange"></param>
		[SupportByVersion("Excel", 14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [SinkArgument("targetPivotTable", typeof(ExcelApi.PivotTable))]
        [SinkArgument("targetRange", typeof(ExcelApi.Range))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2895)]
		void SheetPivotTableAfterValueChange([In, MarshalAs(UnmanagedType.IDispatch)] object sh, [In, MarshalAs(UnmanagedType.IDispatch)] object targetPivotTable, [In, MarshalAs(UnmanagedType.IDispatch)] object targetRange);

        /// <summary>
        /// SheetPivotTableBeforeAllocateChanges
        /// </summary>
        /// <param name="sh"></param>
        /// <param name="targetPivotTable"></param>
        /// <param name="valueChangeStart"></param>
        /// <param name="valueChangeEnd"></param>
        /// <param name="cancel"></param>
		[SupportByVersion("Excel", 14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [SinkArgument("targetPivotTable", typeof(ExcelApi.Range))]
        [SinkArgument("valueChangeStart", SinkArgumentType.Int32)]
        [SinkArgument("valueChangeEnd", SinkArgumentType.Int32)]
        [SinkArgument("cancel", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2896)]
		void SheetPivotTableBeforeAllocateChanges([In, MarshalAs(UnmanagedType.IDispatch)] object sh, [In, MarshalAs(UnmanagedType.IDispatch)] object targetPivotTable, [In] object valueChangeStart, [In] object valueChangeEnd, [In] [Out] ref object cancel);

        /// <summary>
        /// SheetPivotTableBeforeCommitChanges
        /// </summary>
        /// <param name="sh"></param>
        /// <param name="targetPivotTable"></param>
        /// <param name="valueChangeStart"></param>
        /// <param name="valueChangeEnd"></param>
        /// <param name="cancel"></param>
		[SupportByVersion("Excel", 14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [SinkArgument("targetPivotTable", typeof(ExcelApi.Range))]
        [SinkArgument("valueChangeStart", SinkArgumentType.Int32)]
        [SinkArgument("valueChangeEnd", SinkArgumentType.Int32)]
        [SinkArgument("cancel", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2897)]
		void SheetPivotTableBeforeCommitChanges([In, MarshalAs(UnmanagedType.IDispatch)] object sh, [In, MarshalAs(UnmanagedType.IDispatch)] object targetPivotTable, [In] object valueChangeStart, [In] object valueChangeEnd, [In] [Out] ref object cancel);

        /// <summary>
        /// SheetPivotTableBeforeDiscardChanges
        /// </summary>
        /// <param name="sh"></param>
        /// <param name="targetPivotTable"></param>
        /// <param name="valueChangeStart"></param>
        /// <param name="valueChangeEnd"></param>
		[SupportByVersion("Excel", 14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [SinkArgument("targetPivotTable", typeof(ExcelApi.Range))]
        [SinkArgument("valueChangeStart", SinkArgumentType.Int32)]
        [SinkArgument("valueChangeEnd", SinkArgumentType.Int32)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2898)]
		void SheetPivotTableBeforeDiscardChanges([In, MarshalAs(UnmanagedType.IDispatch)] object sh, [In, MarshalAs(UnmanagedType.IDispatch)] object targetPivotTable, [In] object valueChangeStart, [In] object valueChangeEnd);

        /// <summary>
        /// SheetPivotTableChangeSync
        /// </summary>
        /// <param name="sh"></param>
        /// <param name="target"></param>
		[SupportByVersion("Excel", 14,15,16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [SinkArgument("target", typeof(ExcelApi.PivotTable))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2899)]
		void SheetPivotTableChangeSync([In, MarshalAs(UnmanagedType.IDispatch)] object sh, [In, MarshalAs(UnmanagedType.IDispatch)] object target);

        /// <summary>
        /// AfterSave
        /// </summary>
        /// <param name="success"></param>
		[SupportByVersion("Excel", 14,15,16)]
        [SinkArgument("success", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2900)]
		void AfterSave([In] object success);

        /// <summary>
        /// NewChart
        /// </summary>
        /// <param name="ch"></param>
		[SupportByVersion("Excel", 14,15,16)]
        [SinkArgument("ch", typeof(ExcelApi.Chart))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2901)]
		void NewChart([In, MarshalAs(UnmanagedType.IDispatch)] object ch);

        /// <summary>
        /// SheetLensGalleryRenderComplete
        /// </summary>
        /// <param name="sh"></param>
		[SupportByVersion("Excel", 15, 16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(3073)]
		void SheetLensGalleryRenderComplete([In, MarshalAs(UnmanagedType.IDispatch)] object sh);

        /// <summary>
        /// SheetTableUpdate
        /// </summary>
        /// <param name="sh"></param>
        /// <param name="target"></param>
		[SupportByVersion("Excel", 15, 16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [SinkArgument("target", typeof(ExcelApi.TableObject))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(3074)]
		void SheetTableUpdate([In, MarshalAs(UnmanagedType.IDispatch)] object sh, [In, MarshalAs(UnmanagedType.IDispatch)] object target);

        /// <summary>
        /// ModelChange
        /// </summary>
        /// <param name="changes"></param>
		[SupportByVersion("Excel", 15, 16)]
        [SinkArgument("changes", typeof(ExcelApi.ModelChanges))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(3075)]
		void ModelChange([In, MarshalAs(UnmanagedType.IDispatch)] object changes);

        /// <summary>
        /// SheetBeforeDelete
        /// </summary>
        /// <param name="sh"></param>
		[SupportByVersion("Excel", 15, 16)]
        [SinkArgument("sh", SinkArgumentType.UnknownProxy)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(3077)]
		void SheetBeforeDelete([In, MarshalAs(UnmanagedType.IDispatch)] object sh);
	}
}