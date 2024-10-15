// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.TypelessFormatterFallbackResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x20003A5")]
  internal sealed class TypelessFormatterFallbackResolver : IFormatterResolver
  {
    [Token(Token = "0x4000E08")]
    [FieldOffset(Offset = "0x0")]
    public static IFormatterResolver Instance;
    [Token(Token = "0x4000E09")]
    [FieldOffset(Offset = "0x4")]
    private static IMessagePackFormatter<object> fallbackFormatter;

    [Token(Token = "0x6001355")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private TypelessFormatterFallbackResolver()
    {
    }

    [Token(Token = "0x6001356")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001357")]
    [Address(RVA = "0x4DDEE0", Offset = "0x4DCCE0", VA = "0x104DDEE0")]
    static TypelessFormatterFallbackResolver()
    {
    }

    [Token(Token = "0x20003A6")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000E0A")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x6001358")]
      static FormatterCache()
      {
      }
    }
  }
}
