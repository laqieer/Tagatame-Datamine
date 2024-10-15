// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqUnitUsedItem_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AF8")]
  public sealed class ReqUnitUsedItem_ResponseFormatter : 
    IMessagePackFormatter<ReqUnitUsedItem.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A80")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A81")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A36")]
    [Address(RVA = "0xF2E250", Offset = "0xF2D050", VA = "0x10F2E250")]
    public ReqUnitUsedItem_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A37")]
    [Address(RVA = "0xF2E150", Offset = "0xF2CF50", VA = "0x10F2E150", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqUnitUsedItem.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A38")]
    [Address(RVA = "0xF2DE80", Offset = "0xF2CC80", VA = "0x10F2DE80", Slot = "5")]
    public ReqUnitUsedItem.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqUnitUsedItem.Response) null;
    }
  }
}
