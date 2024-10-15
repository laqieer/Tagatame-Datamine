// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdvanceLapBossParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007F8")]
  public sealed class JSON_AdvanceLapBossParamFormatter : 
    IMessagePackFormatter<JSON_AdvanceLapBossParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001480")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001481")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002136")]
    [Address(RVA = "0xD2BBA0", Offset = "0xD2A9A0", VA = "0x10D2BBA0")]
    public JSON_AdvanceLapBossParamFormatter()
    {
    }

    [Token(Token = "0x6002137")]
    [Address(RVA = "0xD2B8D0", Offset = "0xD2A6D0", VA = "0x10D2B8D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdvanceLapBossParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002138")]
    [Address(RVA = "0xD2B4B0", Offset = "0xD2A2B0", VA = "0x10D2B4B0", Slot = "5")]
    public JSON_AdvanceLapBossParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdvanceLapBossParam) null;
    }
  }
}
