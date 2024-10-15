// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqWorldRaidRanking_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000895")]
  public sealed class ReqWorldRaidRanking_ResponseFormatter : 
    IMessagePackFormatter<ReqWorldRaidRanking.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015BA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015BB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600230D")]
    [Address(RVA = "0xDADD70", Offset = "0xDACB70", VA = "0x10DADD70")]
    public ReqWorldRaidRanking_ResponseFormatter()
    {
    }

    [Token(Token = "0x600230E")]
    [Address(RVA = "0xDADB00", Offset = "0xDAC900", VA = "0x10DADB00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqWorldRaidRanking.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600230F")]
    [Address(RVA = "0xDAD780", Offset = "0xDAC580", VA = "0x10DAD780", Slot = "5")]
    public ReqWorldRaidRanking.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqWorldRaidRanking.Response) null;
    }
  }
}
