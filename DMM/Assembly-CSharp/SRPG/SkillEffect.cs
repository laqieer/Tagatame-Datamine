// Decompiled with JetBrains decompiler
// Type: SRPG.SkillEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000DB2")]
  public class SkillEffect : ScriptableObject
  {
    [Token(Token = "0x40027AA")]
    [FieldOffset(Offset = "0xC")]
    [HideInInspector]
    public SkillEffect.SFX StartSound;
    [Token(Token = "0x40027AB")]
    [FieldOffset(Offset = "0x10")]
    [HideInInspector]
    public GameObject ChantEffect;
    [Token(Token = "0x40027AC")]
    [FieldOffset(Offset = "0x14")]
    [HideInInspector]
    public SkillEffect.SFX ChantSound;
    [Token(Token = "0x40027AD")]
    [FieldOffset(Offset = "0x18")]
    [HeaderBar("オーラ")]
    public GameObject AuraEffect;
    [Token(Token = "0x40027AE")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public SkillEffect.SFX AuraSound;
    [Token(Token = "0x40027AF")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public SkillEffect.AuraStopTimings StopAura;
    [Token(Token = "0x40027B0")]
    [FieldOffset(Offset = "0x24")]
    [HeaderBar("弾")]
    public GameObject ProjectileEffect;
    [Token(Token = "0x40027B1")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    public SkillEffect.SFX ProjectileSound;
    [Token(Token = "0x40027B2")]
    [FieldOffset(Offset = "0x2C")]
    public HitReactionTypes RangedHitReactionType;
    [Token(Token = "0x40027B3")]
    [FieldOffset(Offset = "0x30")]
    public GameObject[] ExplosionEffects;
    [Token(Token = "0x40027B4")]
    [FieldOffset(Offset = "0x34")]
    [HeaderBar("ヒット")]
    public SkillEffect.Effect HitEffects;
    [Token(Token = "0x40027B5")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    public SkillEffect.SFX[] ExplosionSounds;
    [Token(Token = "0x40027B6")]
    [FieldOffset(Offset = "0x3C")]
    public bool AlwaysExplode;
    [Token(Token = "0x40027B7")]
    [FieldOffset(Offset = "0x40")]
    public GameObject TargetHitEffect;
    [Token(Token = "0x40027B8")]
    [FieldOffset(Offset = "0x44")]
    public SkillEffect.Effect AreaEffects;
    [Token(Token = "0x40027B9")]
    [FieldOffset(Offset = "0x48")]
    public float CharacterHitDelay;
    [Token(Token = "0x40027BA")]
    [FieldOffset(Offset = "0x4C")]
    public Color HitColor;
    [Token(Token = "0x40027BB")]
    [FieldOffset(Offset = "0x5C")]
    public float HitColorBlendTime;
    [Token(Token = "0x40027BC")]
    [FieldOffset(Offset = "0x60")]
    [HideInInspector]
    public AnimationClip ProjectileStart;
    [Token(Token = "0x40027BD")]
    [FieldOffset(Offset = "0x64")]
    [HideInInspector]
    public float ProjectileStartTime;
    [Token(Token = "0x40027BE")]
    [FieldOffset(Offset = "0x68")]
    [HideInInspector]
    public AnimationClip ProjectileEnd;
    [Token(Token = "0x40027BF")]
    [FieldOffset(Offset = "0x6C")]
    [HideInInspector]
    public float ProjectileEndTime;
    [Token(Token = "0x40027C0")]
    [FieldOffset(Offset = "0x70")]
    [HeaderBar("弾道 (マップ)")]
    public SkillEffect.TrajectoryTypes MapTrajectoryType;
    [Token(Token = "0x40027C1")]
    [FieldOffset(Offset = "0x74")]
    public float MapProjectileSpeed;
    [Token(Token = "0x40027C2")]
    [FieldOffset(Offset = "0x78")]
    public float MapProjectileHitDelay;
    [Token(Token = "0x40027C3")]
    [FieldOffset(Offset = "0x7C")]
    public float MapTrajectoryTimeScale;
    [Token(Token = "0x40027C4")]
    [FieldOffset(Offset = "0x80")]
    public SkillEffect.MapHitEffectTypes MapHitEffectType;
    [Token(Token = "0x40027C5")]
    [FieldOffset(Offset = "0x84")]
    public float MapHitEffectIntervals;
    [Token(Token = "0x40027C6")]
    [FieldOffset(Offset = "0x88")]
    [Tooltip("瞬間移動用として、ProjectileFrameを\n固定時間＆HitEffectなしで動作させるモード")]
    [Space(10f)]
    public bool IsTeleportMode;
    [Token(Token = "0x40027C7")]
    [FieldOffset(Offset = "0x89")]
    [Space(10f)]
    [Tooltip("チェンジング処理を通常スキル演出と同様に動作させるモード")]
    public bool IsChangingMode;
    [Token(Token = "0x40027C8")]
    [FieldOffset(Offset = "0x8C")]
    [Tooltip("レーザー系の際、ProjectileFrameの\nターゲット位置を指定")]
    [Space(10f)]
    public SkillEffect.eTargetTypeForLaser TargetTypeForLaser;
    [Token(Token = "0x40027C9")]
    [FieldOffset(Offset = "0x90")]
    [Tooltip("TargetTypeForLaser=StepFrontの際、\n前方のグリッド数を指定")]
    public int StepFrontTypeForLaser;
    [Token(Token = "0x40027CA")]
    [FieldOffset(Offset = "0x94")]
    [HideInInspector]
    public AnimationCurve PointDistribution;
    [Token(Token = "0x40027CB")]
    [FieldOffset(Offset = "0x98")]
    [HideInInspector]
    public AnimationCurve PointRandomness;
    [Token(Token = "0x40027CC")]
    [FieldOffset(Offset = "0x0")]
    private static SkillEffect mDefaultEmptySkillEffect;

    [Token(Token = "0x6003767")]
    [Address(RVA = "0x10A4D90", Offset = "0x10A3B90", VA = "0x110A4D90")]
    public void SpawnExplosionEffect(
      int index,
      Vector3 position,
      Quaternion rotation,
      float rotationY = 0.0f,
      List<GameObject> _buff_effect_list = null,
      string _cue_id = null)
    {
    }

    [Token(Token = "0x170003C7")]
    public static SkillEffect DefaultEmptySkillEffect
    {
      [Token(Token = "0x6003768"), Address(RVA = "0x10A5380", Offset = "0x10A4180", VA = "0x110A5380")] get
      {
        return (SkillEffect) null;
      }
    }

    [Token(Token = "0x6003769")]
    [Address(RVA = "0x10A50D0", Offset = "0x10A3ED0", VA = "0x110A50D0")]
    public SkillEffect()
    {
    }

    [Token(Token = "0x2000DB3")]
    [Serializable]
    public class SFX
    {
      [Token(Token = "0x40027CD")]
      [FieldOffset(Offset = "0x8")]
      public string cueID;

      [Token(Token = "0x170003C8")]
      public bool IsCritical
      {
        [Token(Token = "0x600376A"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
        {
          return new bool();
        }
        [Token(Token = "0x600376B"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] set
        {
        }
      }

      [Token(Token = "0x600376C")]
      [Address(RVA = "0x10A4170", Offset = "0x10A2F70", VA = "0x110A4170")]
      public void Play()
      {
      }

      [Token(Token = "0x600376D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public SFX()
      {
      }
    }

    [Token(Token = "0x2000DB4")]
    [Serializable]
    public class Effect
    {
      [Token(Token = "0x40027CF")]
      [FieldOffset(Offset = "0x8")]
      [SerializeField]
      public bool SyncDirection;
      [Token(Token = "0x40027D0")]
      [FieldOffset(Offset = "0xC")]
      [SerializeField]
      public SkillEffect.EffectElement[] Effects;

      [Token(Token = "0x600376E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Effect()
      {
      }
    }

    [Token(Token = "0x2000DB5")]
    [Serializable]
    public class EffectElement
    {
      [Token(Token = "0x40027D1")]
      [FieldOffset(Offset = "0x8")]
      [SerializeField]
      public GameObject Effect;
      [Token(Token = "0x40027D2")]
      [FieldOffset(Offset = "0xC")]
      [SerializeField]
      public string CueID;
      [Token(Token = "0x40027D3")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      public CustomSound.EType SoundType;
      [Token(Token = "0x40027D4")]
      [FieldOffset(Offset = "0x14")]
      [SerializeField]
      public float Delay;

      [Token(Token = "0x600376F")]
      [Address(RVA = "0x10A1730", Offset = "0x10A0530", VA = "0x110A1730")]
      public EffectElement()
      {
      }
    }

    [Token(Token = "0x2000DB6")]
    public enum AuraStopTimings
    {
      [Token(Token = "0x40027D6")] AfterChant,
      [Token(Token = "0x40027D7")] BeforeHit,
      [Token(Token = "0x40027D8")] AfterHit,
    }

    [Token(Token = "0x2000DB7")]
    public enum TrajectoryTypes
    {
      [Token(Token = "0x40027DA")] Straight,
      [Token(Token = "0x40027DB")] Arrow,
    }

    [Token(Token = "0x2000DB8")]
    public enum MapHitEffectTypes
    {
      [Token(Token = "0x40027DD")] TargetRadial,
      [Token(Token = "0x40027DE")] EachTargets,
      [Token(Token = "0x40027DF")] EachGrids,
      [Token(Token = "0x40027E0")] Directional,
      [Token(Token = "0x40027E1")] EachHits,
      [Token(Token = "0x40027E2")] InstigatorRadial,
    }

    [Token(Token = "0x2000DB9")]
    public enum eTargetTypeForLaser
    {
      [Token(Token = "0x40027E4")] Default,
      [Token(Token = "0x40027E5")] StepFront,
      [Token(Token = "0x40027E6")] FrontCenter,
    }
  }
}
