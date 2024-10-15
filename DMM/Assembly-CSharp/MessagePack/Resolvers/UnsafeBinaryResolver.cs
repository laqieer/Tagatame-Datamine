// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.UnsafeBinaryResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x20003A7")]
  public sealed class UnsafeBinaryResolver : IFormatterResolver
  {
    [Token(Token = "0x4000E0B")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;

    [Token(Token = "0x6001359")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UnsafeBinaryResolver()
    {
    }

    [Token(Token = "0x600135A")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x600135B")]
    [Address(RVA = "0x4E16B0", Offset = "0x4E04B0", VA = "0x104E16B0")]
    static UnsafeBinaryResolver()
    {
    }

    [Token(Token = "0x20003A8")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000E0C")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x600135C")]
      static FormatterCache()
      {
      }
    }
  }
}
