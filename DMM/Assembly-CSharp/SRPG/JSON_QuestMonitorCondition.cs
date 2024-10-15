// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_QuestMonitorCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C0A")]
  [Serializable]
  public class JSON_QuestMonitorCondition
  {
    [Token(Token = "0x4001F0B")]
    [FieldOffset(Offset = "0x8")]
    public UnitMonitorCondition[] actions;
    [Token(Token = "0x4001F0C")]
    [FieldOffset(Offset = "0xC")]
    public UnitMonitorCondition[] goals;
    [Token(Token = "0x4001F0D")]
    [FieldOffset(Offset = "0x10")]
    public UnitMonitorCondition[] withdraw;

    [Token(Token = "0x600301C")]
    [Address(RVA = "0xFE53C0", Offset = "0xFE41C0", VA = "0x10FE53C0")]
    public void CopyTo(QuestMonitorCondition dst)
    {
    }

    [Token(Token = "0x600301D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_QuestMonitorCondition()
    {
    }
  }
}
