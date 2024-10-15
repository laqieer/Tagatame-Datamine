// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.JSON_InspSkillLvUpCostParam_JSON_CostDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200052C")]
  public sealed class JSON_InspSkillLvUpCostParam_JSON_CostDataFormatter : 
    IMessagePackFormatter<JSON_InspSkillLvUpCostParam.JSON_CostData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FB4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FB5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60018D2")]
    [Address(RVA = "0x6A0630", Offset = "0x69F430", VA = "0x106A0630")]
    public JSON_InspSkillLvUpCostParam_JSON_CostDataFormatter()
    {
    }

    [Token(Token = "0x60018D3")]
    [Address(RVA = "0x6A0570", Offset = "0x69F370", VA = "0x106A0570", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_InspSkillLvUpCostParam.JSON_CostData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018D4")]
    [Address(RVA = "0x6A02D0", Offset = "0x69F0D0", VA = "0x106A02D0", Slot = "5")]
    public JSON_InspSkillLvUpCostParam.JSON_CostData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_InspSkillLvUpCostParam.JSON_CostData) null;
    }
  }
}
