// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGRankingGroup_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A31")]
  public sealed class ReqGvGRankingGroup_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGRankingGroup.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018F2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018F3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027E1")]
    [Address(RVA = "0xEB8AE0", Offset = "0xEB78E0", VA = "0x10EB8AE0")]
    public ReqGvGRankingGroup_ResponseFormatter()
    {
    }

    [Token(Token = "0x60027E2")]
    [Address(RVA = "0xEB8940", Offset = "0xEB7740", VA = "0x10EB8940", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGRankingGroup.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027E3")]
    [Address(RVA = "0xEB8610", Offset = "0xEB7410", VA = "0x10EB8610", Slot = "5")]
    public ReqGvGRankingGroup.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGRankingGroup.Response) null;
    }
  }
}
