// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqCrystalFavorite_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ABA")]
  public sealed class FlowNode_ReqCrystalFavorite_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqCrystalFavorite.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A04")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A05")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600297C")]
    [Address(RVA = "0xF06EA0", Offset = "0xF05CA0", VA = "0x10F06EA0")]
    public FlowNode_ReqCrystalFavorite_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600297D")]
    [Address(RVA = "0xF06BB0", Offset = "0xF059B0", VA = "0x10F06BB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqCrystalFavorite.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600297E")]
    [Address(RVA = "0xF06780", Offset = "0xF05580", VA = "0x10F06780", Slot = "5")]
    public FlowNode_ReqCrystalFavorite.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqCrystalFavorite.MP_Response) null;
    }
  }
}
