// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.ContractlessStandardResolverAllowPrivate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x200039E")]
  public sealed class ContractlessStandardResolverAllowPrivate : IFormatterResolver
  {
    [Token(Token = "0x4000E00")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;
    [Token(Token = "0x4000E01")]
    [FieldOffset(Offset = "0x4")]
    public static readonly IMessagePackFormatter<object> ObjectFallbackFormatter;

    [Token(Token = "0x6001347")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ContractlessStandardResolverAllowPrivate()
    {
    }

    [Token(Token = "0x6001348")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001349")]
    [Address(RVA = "0x4B8440", Offset = "0x4B7240", VA = "0x104B8440")]
    static ContractlessStandardResolverAllowPrivate()
    {
    }

    [Token(Token = "0x200039F")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000E02")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x600134A")]
      static FormatterCache()
      {
      }
    }
  }
}
