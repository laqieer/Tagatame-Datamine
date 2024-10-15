// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqCrystalReleaseAllParty_MP_Response_BaseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005C1")]
  public sealed class FlowNode_ReqCrystalReleaseAllParty_MP_Response_BaseFormatter : 
    IMessagePackFormatter<FlowNode_ReqCrystalReleaseAllParty.MP_Response_Base>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400101A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400101B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A91")]
    [Address(RVA = "0x78E5E0", Offset = "0x78D3E0", VA = "0x1078E5E0")]
    public FlowNode_ReqCrystalReleaseAllParty_MP_Response_BaseFormatter()
    {
    }

    [Token(Token = "0x6001A92")]
    [Address(RVA = "0x78E2F0", Offset = "0x78D0F0", VA = "0x1078E2F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqCrystalReleaseAllParty.MP_Response_Base value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A93")]
    [Address(RVA = "0x78DEC0", Offset = "0x78CCC0", VA = "0x1078DEC0", Slot = "5")]
    public FlowNode_ReqCrystalReleaseAllParty.MP_Response_Base Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqCrystalReleaseAllParty.MP_Response_Base) null;
    }
  }
}
