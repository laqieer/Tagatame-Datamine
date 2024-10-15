// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePrideBonusDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006E5")]
  public sealed class JSON_RunePrideBonusDataFormatter : 
    IMessagePackFormatter<JSON_RunePrideBonusData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001262")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001263")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DFD")]
    [Address(RVA = "0xC2ECF0", Offset = "0xC2DAF0", VA = "0x10C2ECF0")]
    public JSON_RunePrideBonusDataFormatter()
    {
    }

    [Token(Token = "0x6001DFE")]
    [Address(RVA = "0xC2EAC0", Offset = "0xC2D8C0", VA = "0x10C2EAC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePrideBonusData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DFF")]
    [Address(RVA = "0xC2E6B0", Offset = "0xC2D4B0", VA = "0x10C2E6B0", Slot = "5")]
    public JSON_RunePrideBonusData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePrideBonusData) null;
    }
  }
}
