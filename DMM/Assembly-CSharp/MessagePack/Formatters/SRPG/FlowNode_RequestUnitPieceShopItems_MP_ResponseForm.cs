// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_RequestUnitPieceShopItems_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AE6")]
  public sealed class FlowNode_RequestUnitPieceShopItems_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_RequestUnitPieceShopItems.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A5C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A5D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A00")]
    [Address(RVA = "0xF22250", Offset = "0xF21050", VA = "0x10F22250")]
    public FlowNode_RequestUnitPieceShopItems_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A01")]
    [Address(RVA = "0xF21F60", Offset = "0xF20D60", VA = "0x10F21F60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_RequestUnitPieceShopItems.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A02")]
    [Address(RVA = "0xF21B30", Offset = "0xF20930", VA = "0x10F21B30", Slot = "5")]
    public FlowNode_RequestUnitPieceShopItems.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_RequestUnitPieceShopItems.MP_Response) null;
    }
  }
}
