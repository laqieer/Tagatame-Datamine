// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaidReportSelf_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200073A")]
  public sealed class FlowNode_ReqGuildRaidReportSelf_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaidReportSelf.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400130C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400130D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EFC")]
    [Address(RVA = "0xC822F0", Offset = "0xC810F0", VA = "0x10C822F0")]
    public FlowNode_ReqGuildRaidReportSelf_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6001EFD")]
    [Address(RVA = "0xC82000", Offset = "0xC80E00", VA = "0x10C82000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaidReportSelf.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EFE")]
    [Address(RVA = "0xC81BD0", Offset = "0xC809D0", VA = "0x10C81BD0", Slot = "5")]
    public FlowNode_ReqGuildRaidReportSelf.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaidReportSelf.MP_Response) null;
    }
  }
}
