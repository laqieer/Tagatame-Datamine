// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidBossReqDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AF1")]
  public sealed class JSON_WorldRaidBossReqDataFormatter : 
    IMessagePackFormatter<JSON_WorldRaidBossReqData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A72")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A73")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A21")]
    [Address(RVA = "0xF23770", Offset = "0xF22570", VA = "0x10F23770")]
    public JSON_WorldRaidBossReqDataFormatter()
    {
    }

    [Token(Token = "0x6002A22")]
    [Address(RVA = "0xF235B0", Offset = "0xF223B0", VA = "0x10F235B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidBossReqData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A23")]
    [Address(RVA = "0xF23200", Offset = "0xF22000", VA = "0x10F23200", Slot = "5")]
    public JSON_WorldRaidBossReqData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidBossReqData) null;
    }
  }
}
