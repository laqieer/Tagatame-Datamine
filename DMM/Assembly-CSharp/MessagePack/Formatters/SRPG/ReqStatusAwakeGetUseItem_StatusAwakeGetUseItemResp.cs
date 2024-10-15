// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqStatusAwakeGetUseItem_StatusAwakeGetUseItemResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AFF")]
  public sealed class ReqStatusAwakeGetUseItem_StatusAwakeGetUseItemResponseFormatter : 
    IMessagePackFormatter<ReqStatusAwakeGetUseItem.StatusAwakeGetUseItemResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A8E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A8F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A4B")]
    [Address(RVA = "0xF2BA70", Offset = "0xF2A870", VA = "0x10F2BA70")]
    public ReqStatusAwakeGetUseItem_StatusAwakeGetUseItemResponseFormatter()
    {
    }

    [Token(Token = "0x6002A4C")]
    [Address(RVA = "0xF2B780", Offset = "0xF2A580", VA = "0x10F2B780", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqStatusAwakeGetUseItem.StatusAwakeGetUseItemResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A4D")]
    [Address(RVA = "0xF2B350", Offset = "0xF2A150", VA = "0x10F2B350", Slot = "5")]
    public ReqStatusAwakeGetUseItem.StatusAwakeGetUseItemResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqStatusAwakeGetUseItem.StatusAwakeGetUseItemResponse) null;
    }
  }
}
