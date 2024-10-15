// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.NativeDateTimeResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x2000392")]
  public sealed class NativeDateTimeResolver : IFormatterResolver
  {
    [Token(Token = "0x4000DF1")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;

    [Token(Token = "0x600132F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NativeDateTimeResolver()
    {
    }

    [Token(Token = "0x6001330")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001331")]
    [Address(RVA = "0x4DCB30", Offset = "0x4DB930", VA = "0x104DCB30")]
    static NativeDateTimeResolver()
    {
    }

    [Token(Token = "0x2000393")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000DF2")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x6001332")]
      static FormatterCache()
      {
      }
    }
  }
}
