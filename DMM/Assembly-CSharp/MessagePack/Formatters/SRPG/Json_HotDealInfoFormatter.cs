// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_HotDealInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007E7")]
  public sealed class Json_HotDealInfoFormatter : 
    IMessagePackFormatter<Json_HotDealInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400145E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400145F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002103")]
    [Address(RVA = "0xD36A10", Offset = "0xD35810", VA = "0x10D36A10")]
    public Json_HotDealInfoFormatter()
    {
    }

    [Token(Token = "0x6002104")]
    [Address(RVA = "0xD36870", Offset = "0xD35670", VA = "0x10D36870", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_HotDealInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002105")]
    [Address(RVA = "0xD364C0", Offset = "0xD352C0", VA = "0x10D364C0", Slot = "5")]
    public Json_HotDealInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_HotDealInfo) null;
    }
  }
}
