// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.StandardResolverAllowPrivate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x200039C")]
  public sealed class StandardResolverAllowPrivate : IFormatterResolver
  {
    [Token(Token = "0x4000DFD")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;
    [Token(Token = "0x4000DFE")]
    [FieldOffset(Offset = "0x4")]
    public static readonly IMessagePackFormatter<object> ObjectFallbackFormatter;

    [Token(Token = "0x6001343")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private StandardResolverAllowPrivate()
    {
    }

    [Token(Token = "0x6001344")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001345")]
    [Address(RVA = "0x4DDC10", Offset = "0x4DCA10", VA = "0x104DDC10")]
    static StandardResolverAllowPrivate()
    {
    }

    [Token(Token = "0x200039D")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000DFF")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x6001346")]
      static FormatterCache()
      {
      }
    }
  }
}
