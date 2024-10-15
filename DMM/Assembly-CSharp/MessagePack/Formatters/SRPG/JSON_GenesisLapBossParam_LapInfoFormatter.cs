// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GenesisLapBossParam_LapInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008CC")]
  public sealed class JSON_GenesisLapBossParam_LapInfoFormatter : 
    IMessagePackFormatter<JSON_GenesisLapBossParam.LapInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001628")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001629")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023B2")]
    [Address(RVA = "0xDD0940", Offset = "0xDCF740", VA = "0x10DD0940")]
    public JSON_GenesisLapBossParam_LapInfoFormatter()
    {
    }

    [Token(Token = "0x60023B3")]
    [Address(RVA = "0xDD0810", Offset = "0xDCF610", VA = "0x10DD0810", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GenesisLapBossParam.LapInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023B4")]
    [Address(RVA = "0xDD0500", Offset = "0xDCF300", VA = "0x10DD0500", Slot = "5")]
    public JSON_GenesisLapBossParam.LapInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GenesisLapBossParam.LapInfo) null;
    }
  }
}
