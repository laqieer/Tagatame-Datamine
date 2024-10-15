// Decompiled with JetBrains decompiler
// Type: SRPG.LogAutoHeal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BEE")]
  public class LogAutoHeal : BattleLog
  {
    [Token(Token = "0x4001E7E")]
    [FieldOffset(Offset = "0x8")]
    public Unit self;
    [Token(Token = "0x4001E7F")]
    [FieldOffset(Offset = "0xC")]
    public LogAutoHeal.HealType type;
    [Token(Token = "0x4001E80")]
    [FieldOffset(Offset = "0x10")]
    public int value;
    [Token(Token = "0x4001E81")]
    [FieldOffset(Offset = "0x14")]
    public int beforeHp;
    [Token(Token = "0x4001E82")]
    [FieldOffset(Offset = "0x18")]
    public int beforeMp;

    [Token(Token = "0x6002FE5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LogAutoHeal()
    {
    }

    [Token(Token = "0x2000BEF")]
    public enum HealType
    {
      [Token(Token = "0x4001E84")] Hp,
      [Token(Token = "0x4001E85")] Jewel,
    }
  }
}
