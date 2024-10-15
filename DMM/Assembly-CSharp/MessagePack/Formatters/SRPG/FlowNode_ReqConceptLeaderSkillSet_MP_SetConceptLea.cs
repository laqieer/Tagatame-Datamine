// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqConceptLeaderSkillSet_MP_SetConceptLeaderSkill_OverWriteResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AB8")]
  public sealed class FlowNode_ReqConceptLeaderSkillSet_MP_SetConceptLeaderSkill_OverWriteResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqConceptLeaderSkillSet.MP_SetConceptLeaderSkill_OverWriteResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A00")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A01")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002976")]
    [Address(RVA = "0xF05A00", Offset = "0xF04800", VA = "0x10F05A00")]
    public FlowNode_ReqConceptLeaderSkillSet_MP_SetConceptLeaderSkill_OverWriteResponseFormatter()
    {
    }

    [Token(Token = "0x6002977")]
    [Address(RVA = "0xF05710", Offset = "0xF04510", VA = "0x10F05710", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqConceptLeaderSkillSet.MP_SetConceptLeaderSkill_OverWriteResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002978")]
    [Address(RVA = "0xF052E0", Offset = "0xF040E0", VA = "0x10F052E0", Slot = "5")]
    public FlowNode_ReqConceptLeaderSkillSet.MP_SetConceptLeaderSkill_OverWriteResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqConceptLeaderSkillSet.MP_SetConceptLeaderSkill_OverWriteResponse) null;
    }
  }
}
