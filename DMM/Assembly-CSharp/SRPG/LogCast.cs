// Decompiled with JetBrains decompiler
// Type: SRPG.LogCast
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BDE")]
  public class LogCast : BattleLog
  {
    [Token(Token = "0x4001E18")]
    [FieldOffset(Offset = "0x8")]
    public Unit self;
    [Token(Token = "0x4001E19")]
    [FieldOffset(Offset = "0xC")]
    public int dx;
    [Token(Token = "0x4001E1A")]
    [FieldOffset(Offset = "0x10")]
    public int dy;
    [Token(Token = "0x4001E1B")]
    [FieldOffset(Offset = "0x14")]
    public ECastTypes type;

    [Token(Token = "0x6002FAB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LogCast()
    {
    }
  }
}
