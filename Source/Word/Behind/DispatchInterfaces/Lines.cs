﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.WordApi;

namespace NetOffice.WordApi.Behind
{
	/// <summary>
	/// DispatchInterface Lines 
	/// SupportByVersion Word, 11,12,14,15,16
	/// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838516.aspx </remarks>
	public class Lines : COMObject, NetOffice.WordApi.Lines
	{
		#pragma warning disable

		#region Type Information

        /// <summary>
        /// Contract Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type ContractType
        {
            get
            {
                if(null == _contractType)
                    _contractType = typeof(NetOffice.WordApi.Lines);
                return _contractType;
            }
        }
        private static Type _contractType;


		/// <summary>
		/// Instance Type
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
		public override Type InstanceType
		{
			get
			{
				return LateBindingApiWrapperType;
			}
		}

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Lines);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public Lines() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839084.aspx </remarks>
		[SupportByVersion("Word", 11,12,14,15,16)]
		public virtual Int32 Count
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837524.aspx </remarks>
		[SupportByVersion("Word", 11,12,14,15,16)]
		public virtual NetOffice.WordApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.Application>(this, "Application", typeof(NetOffice.WordApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195008.aspx </remarks>
		[SupportByVersion("Word", 11,12,14,15,16)]
		public virtual Int32 Creator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197139.aspx </remarks>
		[SupportByVersion("Word", 11,12,14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByVersion("Word", 11,12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public virtual NetOffice.WordApi.Line this[Int32 index]
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.WordApi.Line>(this, "Item", typeof(NetOffice.WordApi.Line), index);
			}
		}

        #endregion

        #region IEnumerableProvider<NetOffice.WordApi.Line>

        ICOMObject IEnumerableProvider<NetOffice.WordApi.Line>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.WordApi.Line>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.WordApi.Line>

        /// <summary>
        /// SupportByVersion Word, 11,12,14,15,16
        /// </summary>
        [SupportByVersion("Word", 11, 12, 14, 15, 16)]
        public virtual IEnumerator<NetOffice.WordApi.Line> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.WordApi.Line item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Word, 11,12,14,15,16
        /// </summary>
        [SupportByVersion("Word", 11,12,14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

