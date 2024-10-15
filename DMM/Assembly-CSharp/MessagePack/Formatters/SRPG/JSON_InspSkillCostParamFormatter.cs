// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_InspSkillCostParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200064E")]
  public sealed class JSON_InspSkillCostParamFormatter : 
    IMessagePackFormatter<JSON_InspSkillCostParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001134")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001135")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C38")]
    [Address(RVA = "0xBDA9A0", Offset = "0xBD97A0", VA = "0x10BDA9A0")]
    public JSON_InspSkillCostParamFormatter()
    {
    }

    [Token(Token = "0x6001C39")]
    [Address(RVA = "0xBDA870", Offset = "0xBD9670", VA = "0x10BDA870", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_InspSkillCostParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C3A")]
    [Address(RVA = "0xBDA550", Offset = "0xBD9350", VA = "0x10BDA550", Slot = "5")]
    public JSON_InspSkillCostParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_InspSkillCostParam) null;
    }
  }
}
