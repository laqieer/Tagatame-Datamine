// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_ExpansionPurchaseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008AA")]
  public sealed class Json_ExpansionPurchaseFormatter : 
    IMessagePackFormatter<Json_ExpansionPurchase>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015E4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015E5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600234C")]
    [Address(RVA = "0xDB9690", Offset = "0xDB8490", VA = "0x10DB9690")]
    public Json_ExpansionPurchaseFormatter()
    {
    }

    [Token(Token = "0x600234D")]
    [Address(RVA = "0xDB9560", Offset = "0xDB8360", VA = "0x10DB9560", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_ExpansionPurchase value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600234E")]
    [Address(RVA = "0xDB9230", Offset = "0xDB8030", VA = "0x10DB9230", Slot = "5")]
    public Json_ExpansionPurchase Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_ExpansionPurchase) null;
    }
  }
}
