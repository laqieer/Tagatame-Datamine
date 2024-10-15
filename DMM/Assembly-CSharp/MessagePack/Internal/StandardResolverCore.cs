// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.StandardResolverCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x200047F")]
  internal sealed class StandardResolverCore : IFormatterResolver
  {
    [Token(Token = "0x4000F32")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;
    [Token(Token = "0x4000F33")]
    [FieldOffset(Offset = "0x4")]
    private static readonly IFormatterResolver[] resolvers;

    [Token(Token = "0x600164E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private StandardResolverCore()
    {
    }

    [Token(Token = "0x600164F")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001650")]
    [Address(RVA = "0x6AADB0", Offset = "0x6A9BB0", VA = "0x106AADB0")]
    static StandardResolverCore()
    {
    }

    [Token(Token = "0x2000480")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000F34")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x6001651")]
      static FormatterCache()
      {
      }
    }
  }
}
