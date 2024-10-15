// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGDefenseRanking_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ADC")]
  public sealed class ReqGvGDefenseRanking_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGDefenseRanking.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A48")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A49")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029E2")]
    [Address(RVA = "0xF29AA0", Offset = "0xF288A0", VA = "0x10F29AA0")]
    public ReqGvGDefenseRanking_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029E3")]
    [Address(RVA = "0xF29970", Offset = "0xF28770", VA = "0x10F29970", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGDefenseRanking.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029E4")]
    [Address(RVA = "0xF29660", Offset = "0xF28460", VA = "0x10F29660", Slot = "5")]
    public ReqGvGDefenseRanking.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGDefenseRanking.Response) null;
    }
  }
}
