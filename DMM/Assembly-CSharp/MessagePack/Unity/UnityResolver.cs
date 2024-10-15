// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.UnityResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000385")]
  public class UnityResolver : IFormatterResolver
  {
    [Token(Token = "0x4000DE1")]
    [FieldOffset(Offset = "0x0")]
    public static IFormatterResolver Instance;

    [Token(Token = "0x600130F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UnityResolver()
    {
    }

    [Token(Token = "0x6001310")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001311")]
    [Address(RVA = "0x4DE370", Offset = "0x4DD170", VA = "0x104DE370")]
    static UnityResolver()
    {
    }

    [Token(Token = "0x2000386")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000DE2")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x6001312")]
      static FormatterCache()
      {
      }
    }
  }
}
