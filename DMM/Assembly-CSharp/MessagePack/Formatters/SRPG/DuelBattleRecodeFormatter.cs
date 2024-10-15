// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.DuelBattleRecodeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A06")]
  public sealed class DuelBattleRecodeFormatter : 
    IMessagePackFormatter<DuelBattleRecode>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400189C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400189D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002760")]
    [Address(RVA = "0xE927D0", Offset = "0xE915D0", VA = "0x10E927D0")]
    public DuelBattleRecodeFormatter()
    {
    }

    [Token(Token = "0x6002761")]
    [Address(RVA = "0xE926A0", Offset = "0xE914A0", VA = "0x10E926A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DuelBattleRecode value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002762")]
    [Address(RVA = "0xE92400", Offset = "0xE91200", VA = "0x10E92400", Slot = "5")]
    public DuelBattleRecode Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (DuelBattleRecode) null;
    }
  }
}
