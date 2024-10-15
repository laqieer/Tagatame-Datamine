// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqItemSellConvert_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AC5")]
  public sealed class ReqItemSellConvert_ResponseFormatter : 
    IMessagePackFormatter<ReqItemSellConvert.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A1A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A1B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600299D")]
    [Address(RVA = "0xF14F30", Offset = "0xF13D30", VA = "0x10F14F30")]
    public ReqItemSellConvert_ResponseFormatter()
    {
    }

    [Token(Token = "0x600299E")]
    [Address(RVA = "0xF14CB0", Offset = "0xF13AB0", VA = "0x10F14CB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqItemSellConvert.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600299F")]
    [Address(RVA = "0xF148E0", Offset = "0xF136E0", VA = "0x10F148E0", Slot = "5")]
    public ReqItemSellConvert.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqItemSellConvert.Response) null;
    }
  }
}
