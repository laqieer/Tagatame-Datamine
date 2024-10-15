// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_InspSkillTriggerParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200064D")]
  public sealed class JSON_InspSkillTriggerParamFormatter : 
    IMessagePackFormatter<JSON_InspSkillTriggerParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001132")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001133")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C35")]
    [Address(RVA = "0xBDC2E0", Offset = "0xBDB0E0", VA = "0x10BDC2E0")]
    public JSON_InspSkillTriggerParamFormatter()
    {
    }

    [Token(Token = "0x6001C36")]
    [Address(RVA = "0xBDC100", Offset = "0xBDAF00", VA = "0x10BDC100", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_InspSkillTriggerParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C37")]
    [Address(RVA = "0xBDBDC0", Offset = "0xBDABC0", VA = "0x10BDBDC0", Slot = "5")]
    public JSON_InspSkillTriggerParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_InspSkillTriggerParam) null;
    }
  }
}
