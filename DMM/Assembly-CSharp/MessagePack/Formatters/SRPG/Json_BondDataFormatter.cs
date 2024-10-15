// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BondDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005C6")]
  public sealed class Json_BondDataFormatter : 
    IMessagePackFormatter<Json_BondData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001024")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001025")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AA0")]
    [Address(RVA = "0x967430", Offset = "0x966230", VA = "0x10967430")]
    public Json_BondDataFormatter()
    {
    }

    [Token(Token = "0x6001AA1")]
    [Address(RVA = "0x967300", Offset = "0x966100", VA = "0x10967300", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BondData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AA2")]
    [Address(RVA = "0x966FF0", Offset = "0x965DF0", VA = "0x10966FF0", Slot = "5")]
    public Json_BondData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BondData) null;
    }
  }
}
