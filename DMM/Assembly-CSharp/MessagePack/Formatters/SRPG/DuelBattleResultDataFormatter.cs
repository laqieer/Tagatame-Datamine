// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.DuelBattleResultDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A08")]
  public sealed class DuelBattleResultDataFormatter : 
    IMessagePackFormatter<DuelBattleResultData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018A0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018A1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002766")]
    [Address(RVA = "0xE93540", Offset = "0xE92340", VA = "0x10E93540")]
    public DuelBattleResultDataFormatter()
    {
    }

    [Token(Token = "0x6002767")]
    [Address(RVA = "0xE92EA0", Offset = "0xE91CA0", VA = "0x10E92EA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DuelBattleResultData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002768")]
    [Address(RVA = "0xE929C0", Offset = "0xE917C0", VA = "0x10E929C0", Slot = "5")]
    public DuelBattleResultData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (DuelBattleResultData) null;
    }
  }
}
