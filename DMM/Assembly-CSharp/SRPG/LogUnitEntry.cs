// Decompiled with JetBrains decompiler
// Type: SRPG.LogUnitEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BD2")]
  public class LogUnitEntry : BattleLog
  {
    [Token(Token = "0x4001DF8")]
    [FieldOffset(Offset = "0x8")]
    public Unit self;
    [Token(Token = "0x4001DF9")]
    [FieldOffset(Offset = "0xC")]
    public Unit kill_unit;

    [Token(Token = "0x6002F9E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LogUnitEntry()
    {
    }
  }
}
