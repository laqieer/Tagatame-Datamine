// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.GeneratedResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x20003A9")]
  public class GeneratedResolver : IFormatterResolver
  {
    [Token(Token = "0x4000E0D")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;

    [Token(Token = "0x600135D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private GeneratedResolver()
    {
    }

    [Token(Token = "0x600135E")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x600135F")]
    [Address(RVA = "0x4DA900", Offset = "0x4D9700", VA = "0x104DA900")]
    static GeneratedResolver()
    {
    }

    [Token(Token = "0x20003AA")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000E0E")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x6001360")]
      static FormatterCache()
      {
      }
    }
  }
}
