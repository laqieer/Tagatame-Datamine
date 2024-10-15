// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.StandardResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x2000398")]
  public sealed class StandardResolver : IFormatterResolver
  {
    [Token(Token = "0x4000DF7")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;
    [Token(Token = "0x4000DF8")]
    [FieldOffset(Offset = "0x4")]
    public static readonly IMessagePackFormatter<object> ObjectFallbackFormatter;

    [Token(Token = "0x600133B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private StandardResolver()
    {
    }

    [Token(Token = "0x600133C")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x600133D")]
    [Address(RVA = "0x4DDD40", Offset = "0x4DCB40", VA = "0x104DDD40")]
    static StandardResolver()
    {
    }

    [Token(Token = "0x2000399")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000DF9")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x600133E")]
      static FormatterCache()
      {
      }
    }
  }
}
