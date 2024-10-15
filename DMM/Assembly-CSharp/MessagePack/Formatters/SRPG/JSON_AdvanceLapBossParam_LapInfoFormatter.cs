// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdvanceLapBossParam_LapInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007F7")]
  public sealed class JSON_AdvanceLapBossParam_LapInfoFormatter : 
    IMessagePackFormatter<JSON_AdvanceLapBossParam.LapInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400147E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400147F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002133")]
    [Address(RVA = "0xD2C2B0", Offset = "0xD2B0B0", VA = "0x10D2C2B0")]
    public JSON_AdvanceLapBossParam_LapInfoFormatter()
    {
    }

    [Token(Token = "0x6002134")]
    [Address(RVA = "0xD2C180", Offset = "0xD2AF80", VA = "0x10D2C180", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdvanceLapBossParam.LapInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002135")]
    [Address(RVA = "0xD2BE70", Offset = "0xD2AC70", VA = "0x10D2BE70", Slot = "5")]
    public JSON_AdvanceLapBossParam.LapInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdvanceLapBossParam.LapInfo) null;
    }
  }
}
