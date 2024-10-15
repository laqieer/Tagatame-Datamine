// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqToolTipSetAbility_MP_JobAbilityt_OverWriteResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000725")]
  public sealed class FlowNode_ReqToolTipSetAbility_MP_JobAbilityt_OverWriteResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqToolTipSetAbility.MP_JobAbilityt_OverWriteResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012E2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012E3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EBD")]
    [Address(RVA = "0xC530C0", Offset = "0xC51EC0", VA = "0x10C530C0")]
    public FlowNode_ReqToolTipSetAbility_MP_JobAbilityt_OverWriteResponseFormatter()
    {
    }

    [Token(Token = "0x6001EBE")]
    [Address(RVA = "0xC52DD0", Offset = "0xC51BD0", VA = "0x10C52DD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqToolTipSetAbility.MP_JobAbilityt_OverWriteResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EBF")]
    [Address(RVA = "0xC529A0", Offset = "0xC517A0", VA = "0x10C529A0", Slot = "5")]
    public FlowNode_ReqToolTipSetAbility.MP_JobAbilityt_OverWriteResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqToolTipSetAbility.MP_JobAbilityt_OverWriteResponse) null;
    }
  }
}
