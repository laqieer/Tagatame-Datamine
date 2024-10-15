// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqMultiSupportSet_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AD0")]
  public sealed class ReqMultiSupportSet_ResponseFormatter : 
    IMessagePackFormatter<ReqMultiSupportSet.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A30")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A31")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029BE")]
    [Address(RVA = "0xF15B60", Offset = "0xF14960", VA = "0x10F15B60")]
    public ReqMultiSupportSet_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029BF")]
    [Address(RVA = "0xF15AF0", Offset = "0xF148F0", VA = "0x10F15AF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqMultiSupportSet.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029C0")]
    [Address(RVA = "0xF15880", Offset = "0xF14680", VA = "0x10F15880", Slot = "5")]
    public ReqMultiSupportSet.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqMultiSupportSet.Response) null;
    }
  }
}
