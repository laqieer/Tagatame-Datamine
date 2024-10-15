// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusRankNPCPartyParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A2E")]
  public sealed class JSON_VersusRankNPCPartyParamFormatter : 
    IMessagePackFormatter<JSON_VersusRankNPCPartyParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018EC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018ED")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027D8")]
    [Address(RVA = "0xEB2590", Offset = "0xEB1390", VA = "0x10EB2590")]
    public JSON_VersusRankNPCPartyParamFormatter()
    {
    }

    [Token(Token = "0x60027D9")]
    [Address(RVA = "0xEB2210", Offset = "0xEB1010", VA = "0x10EB2210", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusRankNPCPartyParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027DA")]
    [Address(RVA = "0xEB1CB0", Offset = "0xEB0AB0", VA = "0x10EB1CB0", Slot = "5")]
    public JSON_VersusRankNPCPartyParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusRankNPCPartyParam) null;
    }
  }
}
