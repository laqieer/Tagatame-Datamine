// Decompiled with JetBrains decompiler
// Type: GemParticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200000F")]
[AddComponentMenu("Battle/GemParticle")]
public class GemParticle : MonoBehaviour
{
  [Token(Token = "0x4000038")]
  [FieldOffset(Offset = "0xC")]
  public GemParticle Prefab;
  [Token(Token = "0x4000039")]
  [FieldOffset(Offset = "0x10")]
  [NonSerialized]
  public Transform TargetObject;
  [Token(Token = "0x400003A")]
  [FieldOffset(Offset = "0x14")]
  [NonSerialized]
  public Vector3 TargetOffset;
  [Token(Token = "0x400003B")]
  [FieldOffset(Offset = "0x20")]
  public float Speed;
  [Token(Token = "0x400003C")]
  [FieldOffset(Offset = "0x24")]
  public float Damping;
  [Token(Token = "0x400003D")]
  [FieldOffset(Offset = "0x28")]
  public float Delay;
  [Token(Token = "0x400003E")]
  [FieldOffset(Offset = "0x2C")]
  public float Accel;
  [Token(Token = "0x400003F")]
  [FieldOffset(Offset = "0x30")]
  private float mSpeed;
  [Token(Token = "0x4000040")]
  [FieldOffset(Offset = "0x34")]
  private float mDamping;
  [Token(Token = "0x4000041")]
  [FieldOffset(Offset = "0x38")]
  private float mDelay;
  [Token(Token = "0x4000042")]
  [FieldOffset(Offset = "0x3C")]
  private float mAccel;
  [Token(Token = "0x4000043")]
  [FieldOffset(Offset = "0x40")]
  private GemParticle.UpdateEvent mOnUpdate;

  [Token(Token = "0x6000059")]
  [Address(RVA = "0x2C5400", Offset = "0x2C4200", VA = "0x102C5400")]
  private void Start()
  {
  }

  [Token(Token = "0x600005A")]
  [Address(RVA = "0x2C5160", Offset = "0x2C3F60", VA = "0x102C5160")]
  public void Reset()
  {
  }

  [Token(Token = "0x600005B")]
  [Address(RVA = "0x2C5410", Offset = "0x2C4210", VA = "0x102C5410")]
  private void StopPartical()
  {
  }

  [Token(Token = "0x600005C")]
  [Address(RVA = "0x2C5090", Offset = "0x2C3E90", VA = "0x102C5090")]
  private void MoveToMidPoint()
  {
  }

  [Token(Token = "0x600005D")]
  [Address(RVA = "0x2C4E90", Offset = "0x2C3C90", VA = "0x102C4E90")]
  private void MoveToGoal()
  {
  }

  [Token(Token = "0x600005E")]
  [Address(RVA = "0x2C4DE0", Offset = "0x2C3BE0", VA = "0x102C4DE0")]
  private void DelayedDeactivate()
  {
  }

  [Token(Token = "0x600005F")]
  [Address(RVA = "0x2C54C0", Offset = "0x2C42C0", VA = "0x102C54C0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000060")]
  [Address(RVA = "0x2C55E0", Offset = "0x2C43E0", VA = "0x102C55E0")]
  public GemParticle()
  {
  }

  [Token(Token = "0x2000010")]
  private delegate void UpdateEvent();
}
