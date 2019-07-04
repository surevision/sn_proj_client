﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaFramework_ByteBufferWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.ByteBuffer), typeof(System.Object));
		L.RegFunction("Close", Close);
		L.RegFunction("WriteByte", WriteByte);
		L.RegFunction("WriteInt", WriteInt);
		L.RegFunction("WriteShort", WriteShort);
		L.RegFunction("WriteLong", WriteLong);
		L.RegFunction("WriteFloat", WriteFloat);
		L.RegFunction("WriteDouble", WriteDouble);
		L.RegFunction("WriteString", WriteString);
		L.RegFunction("WriteBytes", WriteBytes);
		L.RegFunction("WriteBuffer", WriteBuffer);
		L.RegFunction("WriteBufferWithoutLength", WriteBufferWithoutLength);
		L.RegFunction("ReadByte", ReadByte);
		L.RegFunction("ReadInt", ReadInt);
		L.RegFunction("ReadShort", ReadShort);
		L.RegFunction("ReadLong", ReadLong);
		L.RegFunction("ReadFloat", ReadFloat);
		L.RegFunction("ReadDouble", ReadDouble);
		L.RegFunction("ReadString", ReadString);
		L.RegFunction("ReadBytes", ReadBytes);
		L.RegFunction("ReadBuffer", ReadBuffer);
		L.RegFunction("ReadStringForMsg", ReadStringForMsg);
		L.RegFunction("ReadBufferWithoutLength", ReadBufferWithoutLength);
		L.RegFunction("ToBytes", ToBytes);
		L.RegFunction("Flush", Flush);
		L.RegFunction("New", _CreateLuaFramework_ByteBuffer);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_ByteBuffer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				LuaFramework.ByteBuffer obj = new LuaFramework.ByteBuffer();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1)
			{
				byte[] arg0 = ToLua.CheckByteBuffer(L, 1);
				LuaFramework.ByteBuffer obj = new LuaFramework.ByteBuffer(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: LuaFramework.ByteBuffer.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Close(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			obj.Close();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteByte(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			byte arg0 = (byte)LuaDLL.luaL_checknumber(L, 2);
			obj.WriteByte(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteInt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.WriteInt(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteShort(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			ushort arg0 = (ushort)LuaDLL.luaL_checknumber(L, 2);
			obj.WriteShort(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteLong(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			long arg0 = LuaDLL.tolua_checkint64(L, 2);
			obj.WriteLong(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteFloat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.WriteFloat(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteDouble(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			double arg0 = (double)LuaDLL.luaL_checknumber(L, 2);
			obj.WriteDouble(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.WriteString(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
			obj.WriteBytes(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteBuffer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			LuaByteBuffer arg0 = new LuaByteBuffer(ToLua.CheckByteBuffer(L, 2));
			obj.WriteBuffer(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteBufferWithoutLength(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			LuaByteBuffer arg0 = new LuaByteBuffer(ToLua.CheckByteBuffer(L, 2));
			obj.WriteBufferWithoutLength(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadByte(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			byte o = obj.ReadByte();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadInt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			int o = obj.ReadInt();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadShort(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			ushort o = obj.ReadShort();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadLong(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			long o = obj.ReadLong();
			LuaDLL.tolua_pushint64(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadFloat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			float o = obj.ReadFloat();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadDouble(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			double o = obj.ReadDouble();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			string o = obj.ReadString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			byte[] o = obj.ReadBytes();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadBuffer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			LuaInterface.LuaByteBuffer o = obj.ReadBuffer();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadStringForMsg(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			string o = obj.ReadStringForMsg();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadBufferWithoutLength(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			LuaInterface.LuaByteBuffer o = obj.ReadBufferWithoutLength();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			byte[] o = obj.ToBytes();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Flush(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 1);
			obj.Flush();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

