// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.AttributeFormatterResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x2000388")]
  public sealed class AttributeFormatterResolver : IFormatterResolver
  {
    [Token(Token = "0x4000DE4")]
    [FieldOffset(Offset = "0x0")]
    public static IFormatterResolver Instance;

    [Token(Token = "0x6001315")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private AttributeFormatterResolver()
    {
    }

    [Token(Token = "0x6001316")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001317")]
    [Address(RVA = "0x4B70F0", Offset = "0x4B5EF0", VA = "0x104B70F0")]
    static AttributeFormatterResolver()
    {
    }

    [Token(Token = "0x2000389")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000DE5")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x6001318")]
      static FormatterCache()
      {
      }
    }
  }
}
