// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.BuiltinResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x200038A")]
  public sealed class BuiltinResolver : IFormatterResolver
  {
    [Token(Token = "0x4000DE6")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;

    [Token(Token = "0x6001319")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private BuiltinResolver()
    {
    }

    [Token(Token = "0x600131A")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x600131B")]
    [Address(RVA = "0x4B7850", Offset = "0x4B6650", VA = "0x104B7850")]
    static BuiltinResolver()
    {
    }

    [Token(Token = "0x200038B")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000DE7")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x600131C")]
      static FormatterCache()
      {
      }
    }
  }
}
