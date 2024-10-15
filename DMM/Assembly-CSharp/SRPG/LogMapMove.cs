// Decompiled with JetBrains decompiler
// Type: SRPG.LogMapMove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BD9")]
  public class LogMapMove : BattleLog
  {
    [Token(Token = "0x4001E00")]
    [FieldOffset(Offset = "0x8")]
    public Unit self;
    [Token(Token = "0x4001E01")]
    [FieldOffset(Offset = "0xC")]
    public int ex;
    [Token(Token = "0x4001E02")]
    [FieldOffset(Offset = "0x10")]
    public int ey;
    [Token(Token = "0x4001E03")]
    [FieldOffset(Offset = "0x14")]
    public EUnitDirection dir;
    [Token(Token = "0x4001E04")]
    [FieldOffset(Offset = "0x18")]
    public bool auto;

    [Token(Token = "0x6002FA5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LogMapMove()
    {
    }
  }
}
