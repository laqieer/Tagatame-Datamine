// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqHotDealConfirm_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008F0")]
  public sealed class ReqHotDealConfirm_ResponseFormatter : 
    IMessagePackFormatter<ReqHotDealConfirm.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001670")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001671")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600241E")]
    [Address(RVA = "0xDEC580", Offset = "0xDEB380", VA = "0x10DEC580")]
    public ReqHotDealConfirm_ResponseFormatter()
    {
    }

    [Token(Token = "0x600241F")]
    [Address(RVA = "0xDEC480", Offset = "0xDEB280", VA = "0x10DEC480", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqHotDealConfirm.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002420")]
    [Address(RVA = "0xDEC1B0", Offset = "0xDEAFB0", VA = "0x10DEC1B0", Slot = "5")]
    public ReqHotDealConfirm.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqHotDealConfirm.Response) null;
    }
  }
}
