// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGReward_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009ED")]
  public sealed class ReqGvGReward_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGReward.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400186A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400186B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002715")]
    [Address(RVA = "0xE90A20", Offset = "0xE8F820", VA = "0x10E90A20")]
    public ReqGvGReward_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002716")]
    [Address(RVA = "0xE908C0", Offset = "0xE8F6C0", VA = "0x10E908C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGReward.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002717")]
    [Address(RVA = "0xE90570", Offset = "0xE8F370", VA = "0x10E90570", Slot = "5")]
    public ReqGvGReward.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGReward.Response) null;
    }
  }
}
