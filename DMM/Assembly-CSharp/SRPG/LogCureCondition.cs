// Decompiled with JetBrains decompiler
// Type: SRPG.LogCureCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BF1")]
  public class LogCureCondition : BattleLog
  {
    [Token(Token = "0x4001E89")]
    [FieldOffset(Offset = "0x8")]
    public Unit self;
    [Token(Token = "0x4001E8A")]
    [FieldOffset(Offset = "0x10")]
    public EUnitCondition condition;

    [Token(Token = "0x6002FE7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LogCureCondition()
    {
    }
  }
}
