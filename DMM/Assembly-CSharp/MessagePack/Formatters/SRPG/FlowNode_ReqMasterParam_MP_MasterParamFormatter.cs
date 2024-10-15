// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqMasterParam_MP_MasterParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000708")]
  public sealed class FlowNode_ReqMasterParam_MP_MasterParamFormatter : 
    IMessagePackFormatter<FlowNode_ReqMasterParam.MP_MasterParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012A8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012A9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E66")]
    [Address(RVA = "0xC52670", Offset = "0xC51470", VA = "0x10C52670")]
    public FlowNode_ReqMasterParam_MP_MasterParamFormatter()
    {
    }

    [Token(Token = "0x6001E67")]
    [Address(RVA = "0xC52380", Offset = "0xC51180", VA = "0x10C52380", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqMasterParam.MP_MasterParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E68")]
    [Address(RVA = "0xC51F50", Offset = "0xC50D50", VA = "0x10C51F50", Slot = "5")]
    public FlowNode_ReqMasterParam.MP_MasterParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqMasterParam.MP_MasterParam) null;
    }
  }
}
