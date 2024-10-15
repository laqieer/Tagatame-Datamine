// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_InspSkillTriggerParam_JSON_TriggerDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200064C")]
  public sealed class JSON_InspSkillTriggerParam_JSON_TriggerDataFormatter : 
    IMessagePackFormatter<JSON_InspSkillTriggerParam.JSON_TriggerData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001130")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001131")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C32")]
    [Address(RVA = "0xBDC8A0", Offset = "0xBDB6A0", VA = "0x10BDC8A0")]
    public JSON_InspSkillTriggerParam_JSON_TriggerDataFormatter()
    {
    }

    [Token(Token = "0x6001C33")]
    [Address(RVA = "0xBDC770", Offset = "0xBDB570", VA = "0x10BDC770", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_InspSkillTriggerParam.JSON_TriggerData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C34")]
    [Address(RVA = "0xBDC460", Offset = "0xBDB260", VA = "0x10BDC460", Slot = "5")]
    public JSON_InspSkillTriggerParam.JSON_TriggerData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_InspSkillTriggerParam.JSON_TriggerData) null;
    }
  }
}
