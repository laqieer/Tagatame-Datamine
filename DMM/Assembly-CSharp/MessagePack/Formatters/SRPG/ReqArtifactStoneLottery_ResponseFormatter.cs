// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqArtifactStoneLottery_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009B1")]
  public sealed class ReqArtifactStoneLottery_ResponseFormatter : 
    IMessagePackFormatter<ReqArtifactStoneLottery.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017F2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017F3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002661")]
    [Address(RVA = "0xE3F550", Offset = "0xE3E350", VA = "0x10E3F550")]
    public ReqArtifactStoneLottery_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002662")]
    [Address(RVA = "0xE3F380", Offset = "0xE3E180", VA = "0x10E3F380", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqArtifactStoneLottery.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002663")]
    [Address(RVA = "0xE3EFD0", Offset = "0xE3DDD0", VA = "0x10E3EFD0", Slot = "5")]
    public ReqArtifactStoneLottery.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqArtifactStoneLottery.Response) null;
    }
  }
}
