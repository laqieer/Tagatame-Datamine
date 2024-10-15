// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GenesisLapBossParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008CD")]
  public sealed class JSON_GenesisLapBossParamFormatter : 
    IMessagePackFormatter<JSON_GenesisLapBossParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400162A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400162B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023B5")]
    [Address(RVA = "0xDD0230", Offset = "0xDCF030", VA = "0x10DD0230")]
    public JSON_GenesisLapBossParamFormatter()
    {
    }

    [Token(Token = "0x60023B6")]
    [Address(RVA = "0xDCFF60", Offset = "0xDCED60", VA = "0x10DCFF60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GenesisLapBossParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023B7")]
    [Address(RVA = "0xDCFB40", Offset = "0xDCE940", VA = "0x10DCFB40", Slot = "5")]
    public JSON_GenesisLapBossParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GenesisLapBossParam) null;
    }
  }
}
