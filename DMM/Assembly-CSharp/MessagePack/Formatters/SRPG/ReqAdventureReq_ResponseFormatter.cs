// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAdventureReq_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009EB")]
  public sealed class ReqAdventureReq_ResponseFormatter : 
    IMessagePackFormatter<ReqAdventureReq.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001866")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001867")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600270F")]
    [Address(RVA = "0xE89DF0", Offset = "0xE88BF0", VA = "0x10E89DF0")]
    public ReqAdventureReq_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002710")]
    [Address(RVA = "0xE89A70", Offset = "0xE88870", VA = "0x10E89A70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAdventureReq.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002711")]
    [Address(RVA = "0xE895C0", Offset = "0xE883C0", VA = "0x10E895C0", Slot = "5")]
    public ReqAdventureReq.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAdventureReq.Response) null;
    }
  }
}
