﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.PrimitiveObjectResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x2000396")]
  public sealed class PrimitiveObjectResolver : IFormatterResolver
  {
    [Token(Token = "0x4000DF5")]
    [FieldOffset(Offset = "0x0")]
    public static IFormatterResolver Instance;

    [Token(Token = "0x6001337")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private PrimitiveObjectResolver()
    {
    }

    [Token(Token = "0x6001338")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001339")]
    [Address(RVA = "0x4DCC60", Offset = "0x4DBA60", VA = "0x104DCC60")]
    static PrimitiveObjectResolver()
    {
    }

    [Token(Token = "0x2000397")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000DF6")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x600133A")]
      static FormatterCache()
      {
      }
    }
  }
}