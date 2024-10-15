// Decompiled with JetBrains decompiler
// Type: SkillNamePlate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000160")]
[AddComponentMenu("Common/SkillNamePlate")]
public class SkillNamePlate : MonoBehaviour
{
  [Token(Token = "0x40006A9")]
  [FieldOffset(Offset = "0xC")]
  public string EndStateTrigger;
  [Token(Token = "0x40006AA")]
  [FieldOffset(Offset = "0x10")]
  public string HideStateTrigger;
  [Token(Token = "0x40006AB")]
  [FieldOffset(Offset = "0x14")]
  public string EndStateName;
  [Token(Token = "0x40006AC")]
  [FieldOffset(Offset = "0x18")]
  public Text SkillName;
  [Token(Token = "0x40006AD")]
  [FieldOffset(Offset = "0x1C")]
  public ImageArray SkillBgHead;
  [Token(Token = "0x40006AE")]
  [FieldOffset(Offset = "0x20")]
  public ImageArray SkillBgBody;
  [Token(Token = "0x40006AF")]
  [FieldOffset(Offset = "0x24")]
  public ImageArray SkillAttackType;
  [Token(Token = "0x40006B0")]
  [FieldOffset(Offset = "0x28")]
  public ImageArray SkillElement;
  [Token(Token = "0x40006B1")]
  [FieldOffset(Offset = "0x2C")]
  public ImageArray SkillAttackDetail;
  [Token(Token = "0x40006B2")]
  [FieldOffset(Offset = "0x30")]
  private Animator mAnimator;
  [Token(Token = "0x40006B3")]
  [FieldOffset(Offset = "0x34")]
  private float mSpeed;
  [Token(Token = "0x40006B4")]
  [FieldOffset(Offset = "0x38")]
  private float mDispTime;
  [Token(Token = "0x40006B5")]
  [FieldOffset(Offset = "0x3C")]
  public bool mClose;

  [Token(Token = "0x6000932")]
  [Address(RVA = "0xE60EE0", Offset = "0xE5FCE0", VA = "0x10E60EE0")]
  public void SetSkillName(
    string Name,
    EUnitSide side,
    EElement element = EElement.None,
    AttackDetailTypes ad_type = AttackDetailTypes.None,
    AttackTypes atk_type = AttackTypes.None)
  {
  }

  [Token(Token = "0x6000933")]
  [Address(RVA = "0xE60E20", Offset = "0xE5FC20", VA = "0x10E60E20")]
  public void Open(float speed = 1f, float disp_time = 0.0f)
  {
  }

  [Token(Token = "0x6000934")]
  [Address(RVA = "0xE60CF0", Offset = "0xE5FAF0", VA = "0x10E60CF0")]
  public void Close()
  {
  }

  [Token(Token = "0x6000935")]
  [Address(RVA = "0xE611A0", Offset = "0xE5FFA0", VA = "0x10E611A0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000936")]
  [Address(RVA = "0xE612A0", Offset = "0xE600A0", VA = "0x10E612A0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000937")]
  [Address(RVA = "0xE60D00", Offset = "0xE5FB00", VA = "0x10E60D00")]
  public bool IsClosed() => new bool();

  [Token(Token = "0x6000938")]
  [Address(RVA = "0xE61470", Offset = "0xE60270", VA = "0x10E61470")]
  public SkillNamePlate()
  {
  }
}
