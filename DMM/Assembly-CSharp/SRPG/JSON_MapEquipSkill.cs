// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MapEquipSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C14")]
  [Serializable]
  public class JSON_MapEquipSkill
  {
    [Token(Token = "0x4001F54")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4001F55")]
    [FieldOffset(Offset = "0xC")]
    public int rate;
    [Token(Token = "0x4001F56")]
    [FieldOffset(Offset = "0x10")]
    public JSON_SkillLockCondition cond;
    [Token(Token = "0x4001F57")]
    [FieldOffset(Offset = "0x14")]
    public int check_cnt;

    [Token(Token = "0x6003025")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_MapEquipSkill()
    {
    }
  }
}
