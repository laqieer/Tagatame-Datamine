// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.StandardResolverAllowPrivateCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x2000483")]
  internal sealed class StandardResolverAllowPrivateCore : IFormatterResolver
  {
    [Token(Token = "0x4000F38")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;
    [Token(Token = "0x4000F39")]
    [FieldOffset(Offset = "0x4")]
    private static readonly IFormatterResolver[] resolvers;

    [Token(Token = "0x6001656")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private StandardResolverAllowPrivateCore()
    {
    }

    [Token(Token = "0x6001657")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001658")]
    [Address(RVA = "0x6AACC0", Offset = "0x6A9AC0", VA = "0x106AACC0")]
    static StandardResolverAllowPrivateCore()
    {
    }

    [Token(Token = "0x2000484")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000F3A")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x6001659")]
      static FormatterCache()
      {
      }
    }
  }
}
