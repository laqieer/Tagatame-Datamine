// Decompiled with JetBrains decompiler
// Type: SRPG.DelayedEffectSpawner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C76")]
  [AddComponentMenu("Battle/DelayedEffectSpawner")]
  public class DelayedEffectSpawner : MonoBehaviour
  {
    [Token(Token = "0x40021C1")]
    [FieldOffset(Offset = "0xC")]
    private float mCurrTime;
    [Token(Token = "0x40021C2")]
    [FieldOffset(Offset = "0x10")]
    private List<DelayedEffectSpawner.Cue> mCues;
    [Token(Token = "0x40021C3")]
    [FieldOffset(Offset = "0x14")]
    private Transform mSelfTransform;
    [Token(Token = "0x40021C4")]
    [FieldOffset(Offset = "0x18")]
    private bool mAllSpawned;

    [Token(Token = "0x600311C")]
    [Address(RVA = "0x1021060", Offset = "0x101FE60", VA = "0x11021060")]
    public void Init(SkillEffect.EffectElement[] effects, Vector3 position, Quaternion rotation)
    {
    }

    [Token(Token = "0x600311D")]
    [Address(RVA = "0x1020B90", Offset = "0x101F990", VA = "0x11020B90")]
    public void BuffDebuffEffectInit(
      List<GameObject> effects,
      Vector3 position,
      Quaternion rotation,
      string cue_id)
    {
    }

    [Token(Token = "0x600311E")]
    [Address(RVA = "0x10212F0", Offset = "0x10200F0", VA = "0x110212F0")]
    private void Update()
    {
    }

    [Token(Token = "0x600311F")]
    [Address(RVA = "0x1020DF0", Offset = "0x101FBF0", VA = "0x11020DF0")]
    public ParticleSystem GetLastDurationParticle() => (ParticleSystem) null;

    [Token(Token = "0x6003120")]
    [Address(RVA = "0x1021590", Offset = "0x1020390", VA = "0x11021590")]
    public DelayedEffectSpawner()
    {
    }

    [Token(Token = "0x2000C77")]
    private class Cue
    {
      [Token(Token = "0x40021C5")]
      [FieldOffset(Offset = "0x8")]
      public GameObject particle;
      [Token(Token = "0x40021C6")]
      [FieldOffset(Offset = "0xC")]
      public CustomSound customSound;
      [Token(Token = "0x40021C7")]
      [FieldOffset(Offset = "0x10")]
      public bool spawned;
      [Token(Token = "0x40021C8")]
      [FieldOffset(Offset = "0x14")]
      public float delay;

      [Token(Token = "0x6003121")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Cue()
      {
      }
    }
  }
}
