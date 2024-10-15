// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BondMissionRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006BA")]
  public sealed class Json_BondMissionRewardParamFormatter : 
    IMessagePackFormatter<Json_BondMissionRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400120C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400120D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D7C")]
    [Address(RVA = "0xC20390", Offset = "0xC1F190", VA = "0x10C20390")]
    public Json_BondMissionRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001D7D")]
    [Address(RVA = "0xC20230", Offset = "0xC1F030", VA = "0x10C20230", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BondMissionRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D7E")]
    [Address(RVA = "0xC1FEE0", Offset = "0xC1ECE0", VA = "0x10C1FEE0", Slot = "5")]
    public Json_BondMissionRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BondMissionRewardParam) null;
    }
  }
}
