// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SupportHistoryFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008AC")]
  public sealed class JSON_SupportHistoryFormatter : 
    IMessagePackFormatter<JSON_SupportHistory>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015E8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015E9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002352")]
    [Address(RVA = "0xDB61E0", Offset = "0xDB4FE0", VA = "0x10DB61E0")]
    public JSON_SupportHistoryFormatter()
    {
    }

    [Token(Token = "0x6002353")]
    [Address(RVA = "0xDB6000", Offset = "0xDB4E00", VA = "0x10DB6000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SupportHistory value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002354")]
    [Address(RVA = "0xDB5C20", Offset = "0xDB4A20", VA = "0x10DB5C20", Slot = "5")]
    public JSON_SupportHistory Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SupportHistory) null;
    }
  }
}
