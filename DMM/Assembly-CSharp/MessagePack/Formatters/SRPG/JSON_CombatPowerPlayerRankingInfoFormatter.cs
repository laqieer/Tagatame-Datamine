// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CombatPowerPlayerRankingInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007F9")]
  public sealed class JSON_CombatPowerPlayerRankingInfoFormatter : 
    IMessagePackFormatter<JSON_CombatPowerPlayerRankingInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001482")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001483")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002139")]
    [Address(RVA = "0xD2DC70", Offset = "0xD2CA70", VA = "0x10D2DC70")]
    public JSON_CombatPowerPlayerRankingInfoFormatter()
    {
    }

    [Token(Token = "0x600213A")]
    [Address(RVA = "0xD2DAE0", Offset = "0xD2C8E0", VA = "0x10D2DAE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CombatPowerPlayerRankingInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600213B")]
    [Address(RVA = "0xD2D770", Offset = "0xD2C570", VA = "0x10D2D770", Slot = "5")]
    public JSON_CombatPowerPlayerRankingInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CombatPowerPlayerRankingInfo) null;
    }
  }
}
