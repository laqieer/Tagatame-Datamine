// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.OldSpecStringFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004D8")]
  public sealed class OldSpecStringFormatter : IMessagePackFormatter<string>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F67")]
    [FieldOffset(Offset = "0x0")]
    public static readonly OldSpecStringFormatter Instance;

    [Token(Token = "0x6001790")]
    [Address(RVA = "0x6A7D30", Offset = "0x6A6B30", VA = "0x106A7D30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      string value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001791")]
    [Address(RVA = "0x6A7CE0", Offset = "0x6A6AE0", VA = "0x106A7CE0", Slot = "5")]
    public string Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (string) null;
    }

    [Token(Token = "0x6001792")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public OldSpecStringFormatter()
    {
    }

    [Token(Token = "0x6001793")]
    [Address(RVA = "0x6A8000", Offset = "0x6A6E00", VA = "0x106A8000")]
    static OldSpecStringFormatter()
    {
    }
  }
}
