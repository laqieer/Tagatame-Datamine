// Decompiled with JetBrains decompiler
// Type: UnitAbilitySkillListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000302")]
[AddComponentMenu("UI/UnitAbilitySkillListItem")]
public class UnitAbilitySkillListItem : MonoBehaviour
{
  [Token(Token = "0x4000C59")]
  [FieldOffset(Offset = "0xC")]
  public GameObject MaxObject;
  [Token(Token = "0x4000C5A")]
  [FieldOffset(Offset = "0x10")]
  public GameObject RemainObject;
  [Token(Token = "0x4000C5B")]
  [FieldOffset(Offset = "0x14")]
  public GameObject LimitObject;
  [Token(Token = "0x4000C5C")]
  [FieldOffset(Offset = "0x18")]
  public GameObject NoLimitObject;
  [Token(Token = "0x4000C5D")]
  [FieldOffset(Offset = "0x1C")]
  public GameObject CastSpeedObject;
  [Token(Token = "0x4000C5E")]
  [FieldOffset(Offset = "0x20")]
  public GameObject SpeedObject;

  [Token(Token = "0x6000FA1")]
  [Address(RVA = "0x12AED90", Offset = "0x12ADB90", VA = "0x112AED90")]
  public void SetSkillCount(int Remaining, int Limit, bool noLimit)
  {
  }

  [Token(Token = "0x6000FA2")]
  [Address(RVA = "0x12AECD0", Offset = "0x12ADAD0", VA = "0x112AECD0")]
  public void SetCastSpeed(OInt Speed)
  {
  }

  [Token(Token = "0x6000FA3")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public UnitAbilitySkillListItem()
  {
  }
}
