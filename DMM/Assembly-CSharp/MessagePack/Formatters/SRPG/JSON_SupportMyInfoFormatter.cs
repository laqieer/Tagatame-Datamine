// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SupportMyInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008AD")]
  public sealed class JSON_SupportMyInfoFormatter : 
    IMessagePackFormatter<JSON_SupportMyInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015EA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015EB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002355")]
    [Address(RVA = "0xDB69C0", Offset = "0xDB57C0", VA = "0x10DB69C0")]
    public JSON_SupportMyInfoFormatter()
    {
    }

    [Token(Token = "0x6002356")]
    [Address(RVA = "0xDB6860", Offset = "0xDB5660", VA = "0x10DB6860", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SupportMyInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002357")]
    [Address(RVA = "0xDB6510", Offset = "0xDB5310", VA = "0x10DB6510", Slot = "5")]
    public JSON_SupportMyInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SupportMyInfo) null;
    }
  }
}
