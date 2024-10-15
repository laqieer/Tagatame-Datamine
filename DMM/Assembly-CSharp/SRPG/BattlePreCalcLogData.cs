// Decompiled with JetBrains decompiler
// Type: SRPG.BattlePreCalcLogData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BFC")]
  public class BattlePreCalcLogData
  {
    [Token(Token = "0x4001E93")]
    [FieldOffset(Offset = "0x8")]
    private Dictionary<int, string> mPreCalcLog;
    [Token(Token = "0x4001E94")]
    [FieldOffset(Offset = "0xC")]
    private Dictionary<int, string> mActionLog;
    [Token(Token = "0x4001E95")]
    [FieldOffset(Offset = "0x10")]
    private int mNowCount;
    [Token(Token = "0x4001E96")]
    [FieldOffset(Offset = "0x14")]
    private bool mIsError;
    [Token(Token = "0x4001E97")]
    [FieldOffset(Offset = "0x15")]
    private bool mIsPreQuest;
    [Token(Token = "0x4001E98")]
    [FieldOffset(Offset = "0x16")]
    private bool mIsTakeLog;
    [Token(Token = "0x4001E99")]
    [FieldOffset(Offset = "0x18")]
    private int mActionLogCount;

    [Token(Token = "0x6002FF2")]
    [Address(RVA = "0xFDCA10", Offset = "0xFDB810", VA = "0x10FDCA10")]
    public void Reset(QuestParam quest)
    {
    }

    [Token(Token = "0x6002FF3")]
    [Address(RVA = "0xFDCC20", Offset = "0xFDBA20", VA = "0x10FDCC20")]
    public void SetCalcLog(string log, bool isPreCalc)
    {
    }

    [Token(Token = "0x6002FF4")]
    [Address(RVA = "0xFDD990", Offset = "0xFDC790", VA = "0x10FDD990")]
    public void SetTakeLog(string log)
    {
    }

    [Token(Token = "0x6002FF5")]
    [Address(RVA = "0xFDC9B0", Offset = "0xFDB7B0", VA = "0x10FDC9B0")]
    public bool IsError() => new bool();

    [Token(Token = "0x6002FF6")]
    [Address(RVA = "0xFDE560", Offset = "0xFDD360", VA = "0x10FDE560")]
    public void SetUnitStartLog(Unit unit, uint seed, bool IsArenaCalc)
    {
    }

    [Token(Token = "0x6002FF7")]
    [Address(RVA = "0xFDCF70", Offset = "0xFDBD70", VA = "0x10FDCF70")]
    public void SetDeadLog(Unit self, Unit target, bool IsArenaCalc)
    {
    }

    [Token(Token = "0x6002FF8")]
    [Address(RVA = "0xFDD3E0", Offset = "0xFDC1E0", VA = "0x10FDD3E0")]
    public void SetSkillLog(
      Unit self,
      SkillData skill,
      int gx,
      int gy,
      uint seed,
      bool IsArenaCalc)
    {
    }

    [Token(Token = "0x6002FF9")]
    [Address(RVA = "0xFDE0B0", Offset = "0xFDCEB0", VA = "0x10FDE0B0")]
    public void SetUnitEndLog(Unit self, bool IsArenaCalc)
    {
    }

    [Token(Token = "0x6002FFA")]
    [Address(RVA = "0xFDD9F0", Offset = "0xFDC7F0", VA = "0x10FDD9F0")]
    public void SetUnitDataLog(Unit _unit, int _index, bool _isEnemy)
    {
    }

    [Token(Token = "0x6002FFB")]
    [Address(RVA = "0xFDE340", Offset = "0xFDD140", VA = "0x10FDE340")]
    public void SetUnitHp(Unit _unit)
    {
    }

    [Token(Token = "0x6002FFC")]
    [Address(RVA = "0xFDCD10", Offset = "0xFDBB10", VA = "0x10FDCD10")]
    public void SetConditionCalcLog(Unit target, int assist, int regist, bool success)
    {
    }

    [Token(Token = "0x6002FFD")]
    [Address(RVA = "0xFDD270", Offset = "0xFDC070", VA = "0x10FDD270")]
    public void SetSkillDamageLog(Unit _self, Unit _target, int _damage)
    {
    }

    [Token(Token = "0x6002FFE")]
    [Address(RVA = "0xFDD1D0", Offset = "0xFDBFD0", VA = "0x10FDD1D0")]
    public void SetQuestResult(BattleCore.QuestResult _result)
    {
    }

    [Token(Token = "0x6002FFF")]
    [Address(RVA = "0xFDC9D0", Offset = "0xFDB7D0", VA = "0x10FDC9D0")]
    private bool IsTakeLog(QuestParam _quest) => new bool();

    [Token(Token = "0x6003000")]
    [Address(RVA = "0xFDC800", Offset = "0xFDB600", VA = "0x10FDC800")]
    public string GetActionLog() => (string) null;

    [Token(Token = "0x6003001")]
    [Address(RVA = "0xFDCAB0", Offset = "0xFDB8B0", VA = "0x10FDCAB0")]
    public void RestoreActionLog(string _text)
    {
    }

    [Token(Token = "0x6003002")]
    [Address(RVA = "0xFDE820", Offset = "0xFDD620", VA = "0x10FDE820")]
    public BattlePreCalcLogData()
    {
    }
  }
}
