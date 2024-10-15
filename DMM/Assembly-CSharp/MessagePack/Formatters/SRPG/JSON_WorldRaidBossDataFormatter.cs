// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidBossDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AF0")]
  public sealed class JSON_WorldRaidBossDataFormatter : 
    IMessagePackFormatter<JSON_WorldRaidBossData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A70")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A71")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A1E")]
    [Address(RVA = "0xF23080", Offset = "0xF21E80", VA = "0x10F23080")]
    public JSON_WorldRaidBossDataFormatter()
    {
    }

    [Token(Token = "0x6002A1F")]
    [Address(RVA = "0xF22F50", Offset = "0xF21D50", VA = "0x10F22F50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidBossData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A20")]
    [Address(RVA = "0xF22C20", Offset = "0xF21A20", VA = "0x10F22C20", Slot = "5")]
    public JSON_WorldRaidBossData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidBossData) null;
    }
  }
}
