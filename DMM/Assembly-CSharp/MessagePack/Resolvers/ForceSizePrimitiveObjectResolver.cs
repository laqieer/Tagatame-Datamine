// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.ForceSizePrimitiveObjectResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using System;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x20003A2")]
  internal sealed class ForceSizePrimitiveObjectResolver : IFormatterResolver
  {
    [Token(Token = "0x4000E05")]
    [FieldOffset(Offset = "0x0")]
    public static IFormatterResolver Instance;

    [Token(Token = "0x600134F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceSizePrimitiveObjectResolver()
    {
    }

    [Token(Token = "0x6001350")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001351")]
    [Address(RVA = "0x4B8760", Offset = "0x4B7560", VA = "0x104B8760")]
    static ForceSizePrimitiveObjectResolver()
    {
    }

    [Token(Token = "0x20003A3")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000E06")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x6001352")]
      static FormatterCache()
      {
      }
    }

    [Token(Token = "0x20003A4")]
    private static class Helper
    {
      [Token(Token = "0x4000E07")]
      [FieldOffset(Offset = "0x0")]
      private static readonly Dictionary<Type, object> formatterMap;

      [Token(Token = "0x6001353")]
      [Address(RVA = "0x4DB450", Offset = "0x4DA250", VA = "0x104DB450")]
      public static object GetFormatter(Type type) => (object) null;

      [Token(Token = "0x6001354")]
      [Address(RVA = "0x4DB4D0", Offset = "0x4DA2D0", VA = "0x104DB4D0")]
      static Helper()
      {
      }
    }
  }
}
