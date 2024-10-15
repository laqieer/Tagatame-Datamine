// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.OldSpecResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x2000394")]
  public sealed class OldSpecResolver : IFormatterResolver
  {
    [Token(Token = "0x4000DF3")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;

    [Token(Token = "0x6001333")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private OldSpecResolver()
    {
    }

    [Token(Token = "0x6001334")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001335")]
    [Address(RVA = "0x4DCC00", Offset = "0x4DBA00", VA = "0x104DCC00")]
    static OldSpecResolver()
    {
    }

    [Token(Token = "0x2000395")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000DF4")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x6001336")]
      static FormatterCache()
      {
      }
    }
  }
}
