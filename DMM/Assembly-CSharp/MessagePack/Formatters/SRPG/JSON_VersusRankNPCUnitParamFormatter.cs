// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusRankNPCUnitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200096E")]
  public sealed class JSON_VersusRankNPCUnitParamFormatter : 
    IMessagePackFormatter<JSON_VersusRankNPCUnitParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400176C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400176D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002598")]
    [Address(RVA = "0xE2D220", Offset = "0xE2C020", VA = "0x10E2D220")]
    public JSON_VersusRankNPCUnitParamFormatter()
    {
    }

    [Token(Token = "0x6002599")]
    [Address(RVA = "0xE2C2E0", Offset = "0xE2B0E0", VA = "0x10E2C2E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusRankNPCUnitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600259A")]
    [Address(RVA = "0xE2B1A0", Offset = "0xE29FA0", VA = "0x10E2B1A0", Slot = "5")]
    public JSON_VersusRankNPCUnitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusRankNPCUnitParam) null;
    }
  }
}
