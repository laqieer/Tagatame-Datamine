// Decompiled with JetBrains decompiler
// Type: SRPG.LogMapEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BDA")]
  public class LogMapEvent : BattleLog
  {
    [Token(Token = "0x4001E05")]
    [FieldOffset(Offset = "0x8")]
    public Unit self;
    [Token(Token = "0x4001E06")]
    [FieldOffset(Offset = "0xC")]
    public Unit target;
    [Token(Token = "0x4001E07")]
    [FieldOffset(Offset = "0x10")]
    public EEventType type;
    [Token(Token = "0x4001E08")]
    [FieldOffset(Offset = "0x14")]
    public EEventGimmick gimmick;
    [Token(Token = "0x4001E09")]
    [FieldOffset(Offset = "0x18")]
    public int heal;
    [Token(Token = "0x4001E0A")]
    [FieldOffset(Offset = "0x1C")]
    public BuffBit buff;
    [Token(Token = "0x4001E0B")]
    [FieldOffset(Offset = "0x20")]
    public BuffBit debuff;

    [Token(Token = "0x6002FA6")]
    [Address(RVA = "0xFE5DD0", Offset = "0xFE4BD0", VA = "0x10FE5DD0")]
    public bool IsBuffEffect() => new bool();

    [Token(Token = "0x6002FA7")]
    [Address(RVA = "0xFE5E60", Offset = "0xFE4C60", VA = "0x10FE5E60")]
    public LogMapEvent()
    {
    }
  }
}
