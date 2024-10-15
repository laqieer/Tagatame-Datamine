// Decompiled with JetBrains decompiler
// Type: Gsc.Network.Parser.Des
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.DOM;
using Gsc.DOM.Generic;
using Gsc.Network.Data;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Network.Parser
{
  [Token(Token = "0x20035A3")]
  public class Des
  {
    [Token(Token = "0x400FD83")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Des Ins;
    [Token(Token = "0x400FD84")]
    [FieldOffset(Offset = "0x4")]
    private static readonly Dictionary<Type, Delegate> defaultConverters;
    [Token(Token = "0x400FD85")]
    [FieldOffset(Offset = "0x8")]
    private Stack<Delegate> stack;
    [Token(Token = "0x400FD86")]
    [FieldOffset(Offset = "0xC")]
    private List<Delegate> functions;

    [Token(Token = "0x600EE0A")]
    public T Deserialize<T>(IValue source) => (T) null;

    [Token(Token = "0x600EE0B")]
    private T Deserialize<T, TSource>(TSource source) => (T) null;

    [Token(Token = "0x600EE0C")]
    [Address(RVA = "0xB03F80", Offset = "0xB02D80", VA = "0x10B03F80")]
    static Des()
    {
    }

    [Token(Token = "0x600EE0D")]
    [Address(RVA = "0xB04730", Offset = "0xB03530", VA = "0x10B04730")]
    private Des()
    {
    }

    [Token(Token = "0x600EE0E")]
    public Des Add<T>(Func<IValue, T> func) => (Des) null;

    [Token(Token = "0x600EE0F")]
    public Des Arr<T>() => (Des) null;

    [Token(Token = "0x600EE10")]
    public static T To<T>(IValue v) => (T) null;

    [Token(Token = "0x600EE11")]
    public static T ToEntity<T>(IValue v) where T : Entity<T> => (T) null;

    [Token(Token = "0x600EE12")]
    public static T ToEntity<T>(object v) where T : Entity<T> => (T) null;

    [Token(Token = "0x600EE13")]
    public static T ToObject<T>(IValue v) where T : class, IResponseObject => (T) null;

    [Token(Token = "0x600EE14")]
    [Address(RVA = "0xB03520", Offset = "0xB02320", VA = "0x10B03520")]
    public static DateTime ToDateTime(IValue v) => new DateTime();

    [Token(Token = "0x600EE15")]
    [Address(RVA = "0xB036D0", Offset = "0xB024D0", VA = "0x10B036D0")]
    public static sbyte ToSByte(IValue v) => new sbyte();

    [Token(Token = "0x600EE16")]
    [Address(RVA = "0xB034E0", Offset = "0xB022E0", VA = "0x10B034E0")]
    public static byte ToByte(IValue v) => new byte();

    [Token(Token = "0x600EE17")]
    [Address(RVA = "0xB03710", Offset = "0xB02510", VA = "0x10B03710")]
    public static short ToShort(IValue v) => new short();

    [Token(Token = "0x600EE18")]
    [Address(RVA = "0xB03F40", Offset = "0xB02D40", VA = "0x10B03F40")]
    public static ushort ToUShort(IValue v) => new ushort();

    [Token(Token = "0x600EE19")]
    [Address(RVA = "0xB03650", Offset = "0xB02450", VA = "0x10B03650")]
    public static int ToInt(IValue v) => new int();

    [Token(Token = "0x600EE1A")]
    [Address(RVA = "0xB03EC0", Offset = "0xB02CC0", VA = "0x10B03EC0")]
    public static uint ToUInt(IValue v) => new uint();

    [Token(Token = "0x600EE1B")]
    [Address(RVA = "0xB03690", Offset = "0xB02490", VA = "0x10B03690")]
    public static long ToLong(IValue v) => new long();

    [Token(Token = "0x600EE1C")]
    [Address(RVA = "0xB03F00", Offset = "0xB02D00", VA = "0x10B03F00")]
    public static ulong ToULong(IValue v) => new ulong();

    [Token(Token = "0x600EE1D")]
    [Address(RVA = "0xB03610", Offset = "0xB02410", VA = "0x10B03610")]
    public static float ToFloat(IValue v) => new float();

    [Token(Token = "0x600EE1E")]
    [Address(RVA = "0xB035D0", Offset = "0xB023D0", VA = "0x10B035D0")]
    public static double ToDouble(IValue v) => new double();

    [Token(Token = "0x600EE1F")]
    [Address(RVA = "0xB03E80", Offset = "0xB02C80", VA = "0x10B03E80")]
    public static string ToString(IValue v) => (string) null;

    [Token(Token = "0x600EE20")]
    [Address(RVA = "0xB034A0", Offset = "0xB022A0", VA = "0x10B034A0")]
    public static bool ToBool(IValue v) => new bool();

    [Token(Token = "0x600EE21")]
    private T[] ToArray<T>(IValue source) => (T[]) null;

    [Token(Token = "0x600EE22")]
    [Address(RVA = "0xB03D50", Offset = "0xB02B50", VA = "0x10B03D50")]
    public static Value ToStringTree(IValue v) => new Value();

    [Token(Token = "0x600EE23")]
    [Address(RVA = "0xB039D0", Offset = "0xB027D0", VA = "0x10B039D0")]
    private static Value ToStringTree(Gsc.DOM.IObject v) => new Value();

    [Token(Token = "0x600EE24")]
    [Address(RVA = "0xB03760", Offset = "0xB02560", VA = "0x10B03760")]
    private static Value ToStringTree(IArray v) => new Value();

    [Token(Token = "0x20035A4")]
    public static class ToObfuscatedType
    {
      [Token(Token = "0x600EE25")]
      [Address(RVA = "0xB11EE0", Offset = "0xB10CE0", VA = "0x10B11EE0")]
      public static bool boolean(IValue source) => new bool();

      [Token(Token = "0x600EE26")]
      [Address(RVA = "0xB120E0", Offset = "0xB10EE0", VA = "0x10B120E0")]
      public static sbyte int8(IValue source) => new sbyte();

      [Token(Token = "0x600EE27")]
      [Address(RVA = "0xB12020", Offset = "0xB10E20", VA = "0x10B12020")]
      public static short int16(IValue source) => new short();

      [Token(Token = "0x600EE28")]
      [Address(RVA = "0xB12060", Offset = "0xB10E60", VA = "0x10B12060")]
      public static int int32(IValue source) => new int();

      [Token(Token = "0x600EE29")]
      [Address(RVA = "0xB120A0", Offset = "0xB10EA0", VA = "0x10B120A0")]
      public static long int64(IValue source) => new long();

      [Token(Token = "0x600EE2A")]
      [Address(RVA = "0xB121E0", Offset = "0xB10FE0", VA = "0x10B121E0")]
      public static byte uint8(IValue source) => new byte();

      [Token(Token = "0x600EE2B")]
      [Address(RVA = "0xB12120", Offset = "0xB10F20", VA = "0x10B12120")]
      public static ushort uint16(IValue source) => new ushort();

      [Token(Token = "0x600EE2C")]
      [Address(RVA = "0xB12160", Offset = "0xB10F60", VA = "0x10B12160")]
      public static uint uint32(IValue source) => new uint();

      [Token(Token = "0x600EE2D")]
      [Address(RVA = "0xB121A0", Offset = "0xB10FA0", VA = "0x10B121A0")]
      public static ulong uint64(IValue source) => new ulong();

      [Token(Token = "0x600EE2E")]
      [Address(RVA = "0xB11F90", Offset = "0xB10D90", VA = "0x10B11F90")]
      public static float float32(IValue source) => new float();

      [Token(Token = "0x600EE2F")]
      [Address(RVA = "0xB11FD0", Offset = "0xB10DD0", VA = "0x10B11FD0")]
      public static double float64(IValue source) => new double();
    }
  }
}
