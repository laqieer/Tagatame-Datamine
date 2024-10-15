// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqTobiraFullMaster_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000940")]
  public sealed class ReqTobiraFullMaster_ResponseFormatter : 
    IMessagePackFormatter<ReqTobiraFullMaster.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001710")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001711")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600250E")]
    [Address(RVA = "0xE1F0C0", Offset = "0xE1DEC0", VA = "0x10E1F0C0")]
    public ReqTobiraFullMaster_ResponseFormatter()
    {
    }

    [Token(Token = "0x600250F")]
    [Address(RVA = "0xE1EB80", Offset = "0xE1D980", VA = "0x10E1EB80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqTobiraFullMaster.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002510")]
    [Address(RVA = "0xE1E610", Offset = "0xE1D410", VA = "0x10E1E610", Slot = "5")]
    public ReqTobiraFullMaster.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqTobiraFullMaster.Response) null;
    }
  }
}
