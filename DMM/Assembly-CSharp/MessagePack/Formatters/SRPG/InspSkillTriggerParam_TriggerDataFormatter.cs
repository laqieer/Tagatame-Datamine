// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.InspSkillTriggerParam_TriggerDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200078E")]
  public sealed class InspSkillTriggerParam_TriggerDataFormatter : 
    IMessagePackFormatter<InspSkillTriggerParam.TriggerData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013B4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013B5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FF8")]
    [Address(RVA = "0xCDB700", Offset = "0xCDA500", VA = "0x10CDB700")]
    public InspSkillTriggerParam_TriggerDataFormatter()
    {
    }

    [Token(Token = "0x6001FF9")]
    [Address(RVA = "0xCDB4F0", Offset = "0xCDA2F0", VA = "0x10CDB4F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      InspSkillTriggerParam.TriggerData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FFA")]
    [Address(RVA = "0xCDB130", Offset = "0xCD9F30", VA = "0x10CDB130", Slot = "5")]
    public InspSkillTriggerParam.TriggerData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (InspSkillTriggerParam.TriggerData) null;
    }
  }
}
