// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AIAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C1D")]
  [Serializable]
  public class JSON_AIAction
  {
    [Token(Token = "0x4001F6D")]
    [FieldOffset(Offset = "0x8")]
    public string skill;
    [Token(Token = "0x4001F6E")]
    [FieldOffset(Offset = "0xC")]
    public int type;
    [Token(Token = "0x4001F6F")]
    [FieldOffset(Offset = "0x10")]
    public int turn;
    [Token(Token = "0x4001F70")]
    [FieldOffset(Offset = "0x14")]
    public int notBlock;
    [Token(Token = "0x4001F71")]
    [FieldOffset(Offset = "0x18")]
    public int noExecAct;
    [Token(Token = "0x4001F72")]
    [FieldOffset(Offset = "0x1C")]
    public int nextActIdx;
    [Token(Token = "0x4001F73")]
    [FieldOffset(Offset = "0x20")]
    public int nextTurnAct;
    [Token(Token = "0x4001F74")]
    [FieldOffset(Offset = "0x24")]
    public int turnActIdx;
    [Token(Token = "0x4001F75")]
    [FieldOffset(Offset = "0x28")]
    public JSON_SkillLockCondition cond;

    [Token(Token = "0x600302E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AIAction()
    {
    }
  }
}
