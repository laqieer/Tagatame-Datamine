// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_MultiSupportFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008D3")]
  public sealed class JSON_MultiSupportFormatter : 
    IMessagePackFormatter<JSON_MultiSupport>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001636")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001637")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023C7")]
    [Address(RVA = "0xDD3F20", Offset = "0xDD2D20", VA = "0x10DD3F20")]
    public JSON_MultiSupportFormatter()
    {
    }

    [Token(Token = "0x60023C8")]
    [Address(RVA = "0xDD3A10", Offset = "0xDD2810", VA = "0x10DD3A10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_MultiSupport value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023C9")]
    [Address(RVA = "0xDD34B0", Offset = "0xDD22B0", VA = "0x10DD34B0", Slot = "5")]
    public JSON_MultiSupport Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_MultiSupport) null;
    }
  }
}
