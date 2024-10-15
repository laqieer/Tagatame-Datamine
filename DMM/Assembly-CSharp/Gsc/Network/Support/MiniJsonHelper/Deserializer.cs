// Decompiled with JetBrains decompiler
// Type: Gsc.Network.Support.MiniJsonHelper.Deserializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Data;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Network.Support.MiniJsonHelper
{
  [Token(Token = "0x200359E")]
  public class Deserializer
  {
    [Token(Token = "0x400FD80")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Deserializer Instance;
    [Token(Token = "0x400FD81")]
    [FieldOffset(Offset = "0x8")]
    private Stack<Delegate> stack;
    [Token(Token = "0x400FD82")]
    [FieldOffset(Offset = "0xC")]
    private List<Delegate> functions;

    [Token(Token = "0x600EDDC")]
    [Address(RVA = "0xB04880", Offset = "0xB03680", VA = "0x10B04880")]
    static Deserializer()
    {
    }

    [Token(Token = "0x600EDDD")]
    [Address(RVA = "0xB04980", Offset = "0xB03780", VA = "0x10B04980")]
    private Deserializer()
    {
    }

    [Token(Token = "0x600EDDE")]
    public Deserializer WithArray<T>() => (Deserializer) null;

    [Token(Token = "0x600EDDF")]
    public Deserializer WithArray<T>(Func<object, T> func) => (Deserializer) null;

    [Token(Token = "0x600EDE0")]
    public Deserializer WithDict<TKey, TValue>() => (Deserializer) null;

    [Token(Token = "0x600EDE1")]
    public Deserializer WithDict<TKey, TValue>(
      Func<object, TKey> keyFunc,
      Func<object, TValue> valueFunc)
    {
      return (Deserializer) null;
    }

    [Token(Token = "0x600EDE2")]
    public Deserializer Add<T>(Func<object, T> func) => (Deserializer) null;

    [Token(Token = "0x600EDE3")]
    public T Deserialize<T>(object source) => (T) null;

    [Token(Token = "0x600EDE4")]
    private T[] ToArray<T>(object source_) => (T[]) null;

    [Token(Token = "0x600EDE5")]
    private Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(object source_)
    {
      return (Dictionary<TKey, TValue>) null;
    }

    [Token(Token = "0x600EDE6")]
    public static T ToModelObjectCache<T>(object source) where T : Entity<T> => (T) null;

    [Token(Token = "0x600EDE7")]
    public static T ModelObject<T>(object source) where T : Entity<T> => (T) null;

    [Token(Token = "0x600EDE8")]
    public static T ToObject<T>(object source) where T : class, IResponseObject => (T) null;

    [Token(Token = "0x600EDE9")]
    [Address(RVA = "0xB047E0", Offset = "0xB035E0", VA = "0x10B047E0")]
    public static DateTime ToDateTime(object source) => new DateTime();

    [Token(Token = "0x600EDEA")]
    public static T To<T>(object source) => (T) null;

    [Token(Token = "0x200359F")]
    public static class ToIntegerType
    {
      [Token(Token = "0x600EDEB")]
      [Address(RVA = "0xB11AC0", Offset = "0xB108C0", VA = "0x10B11AC0")]
      public static sbyte int8(object source) => new sbyte();

      [Token(Token = "0x600EDEC")]
      [Address(RVA = "0xB119A0", Offset = "0xB107A0", VA = "0x10B119A0")]
      public static short int16(object source) => new short();

      [Token(Token = "0x600EDED")]
      [Address(RVA = "0xB11A00", Offset = "0xB10800", VA = "0x10B11A00")]
      public static int int32(object source) => new int();

      [Token(Token = "0x600EDEE")]
      [Address(RVA = "0xB11A60", Offset = "0xB10860", VA = "0x10B11A60")]
      public static long int64(object source) => new long();

      [Token(Token = "0x600EDEF")]
      [Address(RVA = "0xB11C40", Offset = "0xB10A40", VA = "0x10B11C40")]
      public static byte uint8(object source) => new byte();

      [Token(Token = "0x600EDF0")]
      [Address(RVA = "0xB11B20", Offset = "0xB10920", VA = "0x10B11B20")]
      public static ushort uint16(object source) => new ushort();

      [Token(Token = "0x600EDF1")]
      [Address(RVA = "0xB11B80", Offset = "0xB10980", VA = "0x10B11B80")]
      public static uint uint32(object source) => new uint();

      [Token(Token = "0x600EDF2")]
      [Address(RVA = "0xB11BE0", Offset = "0xB109E0", VA = "0x10B11BE0")]
      public static ulong uint64(object source) => new ulong();
    }

    [Token(Token = "0x20035A0")]
    public static class ToNumberType
    {
      [Token(Token = "0x600EDF3")]
      [Address(RVA = "0xB11CA0", Offset = "0xB10AA0", VA = "0x10B11CA0")]
      public static float float32(object source) => new float();

      [Token(Token = "0x600EDF4")]
      [Address(RVA = "0xB11DC0", Offset = "0xB10BC0", VA = "0x10B11DC0")]
      public static double float64(object source) => new double();
    }

    [Token(Token = "0x20035A1")]
    public static class ToObfuscatedType
    {
      [Token(Token = "0x600EDF5")]
      [Address(RVA = "0xB11F20", Offset = "0xB10D20", VA = "0x10B11F20")]
      public static bool boolean(object source) => new bool();

      [Token(Token = "0x600EDF6")]
      [Address(RVA = "0xB11AC0", Offset = "0xB108C0", VA = "0x10B11AC0")]
      public static sbyte int8(object source) => new sbyte();

      [Token(Token = "0x600EDF7")]
      [Address(RVA = "0xB119A0", Offset = "0xB107A0", VA = "0x10B119A0")]
      public static short int16(object source) => new short();

      [Token(Token = "0x600EDF8")]
      [Address(RVA = "0xB11A00", Offset = "0xB10800", VA = "0x10B11A00")]
      public static int int32(object source) => new int();

      [Token(Token = "0x600EDF9")]
      [Address(RVA = "0xB11A60", Offset = "0xB10860", VA = "0x10B11A60")]
      public static long int64(object source) => new long();

      [Token(Token = "0x600EDFA")]
      [Address(RVA = "0xB11C40", Offset = "0xB10A40", VA = "0x10B11C40")]
      public static byte uint8(object source) => new byte();

      [Token(Token = "0x600EDFB")]
      [Address(RVA = "0xB11B20", Offset = "0xB10920", VA = "0x10B11B20")]
      public static ushort uint16(object source) => new ushort();

      [Token(Token = "0x600EDFC")]
      [Address(RVA = "0xB11B80", Offset = "0xB10980", VA = "0x10B11B80")]
      public static uint uint32(object source) => new uint();

      [Token(Token = "0x600EDFD")]
      [Address(RVA = "0xB11BE0", Offset = "0xB109E0", VA = "0x10B11BE0")]
      public static ulong uint64(object source) => new ulong();

      [Token(Token = "0x600EDFE")]
      [Address(RVA = "0xB11F80", Offset = "0xB10D80", VA = "0x10B11F80")]
      public static float float32(object source) => new float();

      [Token(Token = "0x600EDFF")]
      [Address(RVA = "0xB12010", Offset = "0xB10E10", VA = "0x10B12010")]
      public static double float64(object source) => new double();
    }
  }
}
