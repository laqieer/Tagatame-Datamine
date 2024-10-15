// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqPlayerInfo_PlayerInfoResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B19")]
  public sealed class FlowNode_ReqPlayerInfo_PlayerInfoResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqPlayerInfo.PlayerInfoResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AC2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AC3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A99")]
    [Address(RVA = "0xF384F0", Offset = "0xF372F0", VA = "0x10F384F0")]
    public FlowNode_ReqPlayerInfo_PlayerInfoResponseFormatter()
    {
    }

    [Token(Token = "0x6002A9A")]
    [Address(RVA = "0xF38200", Offset = "0xF37000", VA = "0x10F38200", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqPlayerInfo.PlayerInfoResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A9B")]
    [Address(RVA = "0xF37DD0", Offset = "0xF36BD0", VA = "0x10F37DD0", Slot = "5")]
    public FlowNode_ReqPlayerInfo.PlayerInfoResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqPlayerInfo.PlayerInfoResponse) null;
    }
  }
}
