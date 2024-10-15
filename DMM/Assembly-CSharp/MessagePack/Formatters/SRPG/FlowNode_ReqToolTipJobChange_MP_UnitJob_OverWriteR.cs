// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqToolTipJobChange_MP_UnitJob_OverWriteResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A29")]
  public sealed class FlowNode_ReqToolTipJobChange_MP_UnitJob_OverWriteResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqToolTipJobChange.MP_UnitJob_OverWriteResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018E2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018E3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027C9")]
    [Address(RVA = "0xE9CFB0", Offset = "0xE9BDB0", VA = "0x10E9CFB0")]
    public FlowNode_ReqToolTipJobChange_MP_UnitJob_OverWriteResponseFormatter()
    {
    }

    [Token(Token = "0x60027CA")]
    [Address(RVA = "0xE9CCB0", Offset = "0xE9BAB0", VA = "0x10E9CCB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqToolTipJobChange.MP_UnitJob_OverWriteResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027CB")]
    [Address(RVA = "0xE9C880", Offset = "0xE9B680", VA = "0x10E9C880", Slot = "5")]
    public FlowNode_ReqToolTipJobChange.MP_UnitJob_OverWriteResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqToolTipJobChange.MP_UnitJob_OverWriteResponse) null;
    }
  }
}
