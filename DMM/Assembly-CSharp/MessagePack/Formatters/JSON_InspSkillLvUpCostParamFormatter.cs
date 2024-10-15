// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.JSON_InspSkillLvUpCostParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200052D")]
  public sealed class JSON_InspSkillLvUpCostParamFormatter : 
    IMessagePackFormatter<JSON_InspSkillLvUpCostParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FB6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FB7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60018D5")]
    [Address(RVA = "0x6A0150", Offset = "0x69EF50", VA = "0x106A0150")]
    public JSON_InspSkillLvUpCostParamFormatter()
    {
    }

    [Token(Token = "0x60018D6")]
    [Address(RVA = "0x69FFB0", Offset = "0x69EDB0", VA = "0x1069FFB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_InspSkillLvUpCostParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018D7")]
    [Address(RVA = "0x69FCA0", Offset = "0x69EAA0", VA = "0x1069FCA0", Slot = "5")]
    public JSON_InspSkillLvUpCostParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_InspSkillLvUpCostParam) null;
    }
  }
}
