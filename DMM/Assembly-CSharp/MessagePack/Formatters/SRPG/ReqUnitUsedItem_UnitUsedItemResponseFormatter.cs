// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqUnitUsedItem_UnitUsedItemResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AF9")]
  public sealed class ReqUnitUsedItem_UnitUsedItemResponseFormatter : 
    IMessagePackFormatter<ReqUnitUsedItem.UnitUsedItemResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A82")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A83")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A39")]
    [Address(RVA = "0xF2EA90", Offset = "0xF2D890", VA = "0x10F2EA90")]
    public ReqUnitUsedItem_UnitUsedItemResponseFormatter()
    {
    }

    [Token(Token = "0x6002A3A")]
    [Address(RVA = "0xF2E7A0", Offset = "0xF2D5A0", VA = "0x10F2E7A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqUnitUsedItem.UnitUsedItemResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A3B")]
    [Address(RVA = "0xF2E370", Offset = "0xF2D170", VA = "0x10F2E370", Slot = "5")]
    public ReqUnitUsedItem.UnitUsedItemResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqUnitUsedItem.UnitUsedItemResponse) null;
    }
  }
}
