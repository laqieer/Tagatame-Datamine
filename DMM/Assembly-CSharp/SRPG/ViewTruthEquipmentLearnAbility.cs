﻿// Decompiled with JetBrains decompiler
// Type: SRPG.ViewTruthEquipmentLearnAbility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DB2")]
  public class ViewTruthEquipmentLearnAbility
  {
    [Token(Token = "0x400764A")]
    [FieldOffset(Offset = "0x8")]
    public AbilityData LearnAbility;
    [Token(Token = "0x400764B")]
    [FieldOffset(Offset = "0xC")]
    public bool IsUnlocked;
    [Token(Token = "0x400764C")]
    [FieldOffset(Offset = "0x10")]
    public int Lv;
    [Token(Token = "0x400764D")]
    [FieldOffset(Offset = "0x14")]
    public eTruthEquipmentLearnType LearnType;

    [Token(Token = "0x6007995")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ViewTruthEquipmentLearnAbility()
    {
    }
  }
}