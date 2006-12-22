// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

// This file is automatically generated - any changes will be lost

#pragma warning disable 1591

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public partial class ICorDebugClass2
	{
		
		private Debugger.Interop.CorDebug.ICorDebugClass2 wrappedObject;
		
		internal Debugger.Interop.CorDebug.ICorDebugClass2 WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugClass2(Debugger.Interop.CorDebug.ICorDebugClass2 wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(ICorDebugClass2));
		}
		
		public static ICorDebugClass2 Wrap(Debugger.Interop.CorDebug.ICorDebugClass2 objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new ICorDebugClass2(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~ICorDebugClass2()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(ICorDebugClass2));
		}
		
		public bool Is<T>() where T: class
		{
			try {
				CastTo<T>();
				return true;
			} catch {
				return false;
			}
		}
		
		public T As<T>() where T: class
		{
			try {
				return CastTo<T>();
			} catch {
				return null;
			}
		}
		
		public T CastTo<T>() where T: class
		{
			return (T)Activator.CreateInstance(typeof(T), this.WrappedObject);
		}
		
		public static bool operator ==(ICorDebugClass2 o1, ICorDebugClass2 o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugClass2 o1, ICorDebugClass2 o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugClass2 casted = o as ICorDebugClass2;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public ICorDebugType GetParameterizedType(uint elementType, uint nTypeArgs, ICorDebugType[] ppTypeArgs)
		{
			ICorDebugType ppType;
			Debugger.Interop.CorDebug.ICorDebugType[] array_ppTypeArgs = new Debugger.Interop.CorDebug.ICorDebugType[ppTypeArgs.Length];
			for (int i = 0; (i < ppTypeArgs.Length); i = (i + 1))
			{
				if ((ppTypeArgs[i] != null))
				{
					array_ppTypeArgs[i] = ppTypeArgs[i].WrappedObject;
				}
			}
			Debugger.Interop.CorDebug.ICorDebugType out_ppType;
			this.WrappedObject.GetParameterizedType(elementType, nTypeArgs, array_ppTypeArgs, out out_ppType);
			for (int i = 0; (i < ppTypeArgs.Length); i = (i + 1))
			{
				if ((array_ppTypeArgs[i] != null))
				{
					ppTypeArgs[i] = ICorDebugType.Wrap(array_ppTypeArgs[i]);
				} else
				{
					ppTypeArgs[i] = null;
				}
			}
			ppType = ICorDebugType.Wrap(out_ppType);
			return ppType;
		}
		
		public void SetJMCStatus(int bIsJustMyCode)
		{
			this.WrappedObject.SetJMCStatus(bIsJustMyCode);
		}
	}
}

#pragma warning restore 1591
