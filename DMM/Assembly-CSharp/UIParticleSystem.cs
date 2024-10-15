// Decompiled with JetBrains decompiler
// Type: UIParticleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000172")]
[RequireComponent(typeof (CanvasRenderer))]
[AddComponentMenu("Common/UIParticleSystem")]
public class UIParticleSystem : Graphic
{
  [Token(Token = "0x40006F7")]
  [FieldOffset(Offset = "0x60")]
  public UIParticleSystem.ParticleUpdateMode updateMode;
  [Token(Token = "0x40006F8")]
  [FieldOffset(Offset = "0x64")]
  public UIParticleSystem.EmitterTypes emitterType;
  [Token(Token = "0x40006F9")]
  [FieldOffset(Offset = "0x68")]
  public UIParticleSystem.ConeEmitter coneEmitter;
  [Token(Token = "0x40006FA")]
  [FieldOffset(Offset = "0x7C")]
  public UIParticleSystem.SphereEmitter sphereEmitter;
  [Token(Token = "0x40006FB")]
  [FieldOffset(Offset = "0x88")]
  public UIParticleSystem.BoxEmitter boxEmitter;
  [Token(Token = "0x40006FC")]
  [FieldOffset(Offset = "0x94")]
  private List<UIParticleSystem.Particle> mParticles;
  [Token(Token = "0x40006FD")]
  [FieldOffset(Offset = "0x98")]
  private List<UIParticleSystem.Particle> mDeadParticles;
  [Token(Token = "0x40006FE")]
  [FieldOffset(Offset = "0x9C")]
  private float mPrevTime;
  [Token(Token = "0x40006FF")]
  [FieldOffset(Offset = "0xA0")]
  private float mTime;
  [Token(Token = "0x4000700")]
  [FieldOffset(Offset = "0xA4")]
  public UIParticleSystem.ParticleRenderMode RenderMode;
  [Token(Token = "0x4000701")]
  [FieldOffset(Offset = "0xA8")]
  public UIParticleSystem.StretchBillboard m_StretchBillboard;
  [Token(Token = "0x4000702")]
  [FieldOffset(Offset = "0xB0")]
  [UIParticleSystem.Particle]
  public float duration;
  [Token(Token = "0x4000703")]
  [FieldOffset(Offset = "0xB4")]
  [UIParticleSystem.Particle]
  public float emissionRate;
  [Token(Token = "0x4000704")]
  [FieldOffset(Offset = "0xB8")]
  [UIParticleSystem.Particle]
  public float gravityMultipler;
  [Token(Token = "0x4000705")]
  [FieldOffset(Offset = "0xBC")]
  [UIParticleSystem.Particle]
  public bool loop;
  [Token(Token = "0x4000706")]
  [FieldOffset(Offset = "0xC0")]
  [UIParticleSystem.Particle]
  public int maxParticles;
  [Token(Token = "0x4000707")]
  [FieldOffset(Offset = "0xC4")]
  [UIParticleSystem.Particle]
  public float playbackSpeed;
  [Token(Token = "0x4000708")]
  [FieldOffset(Offset = "0xC8")]
  [UIParticleSystem.Particle]
  public UIParticleSystem.ColorRange startColor;
  [Token(Token = "0x4000709")]
  [FieldOffset(Offset = "0xE8")]
  [UIParticleSystem.Particle]
  public float startDelay;
  [Token(Token = "0x400070A")]
  [FieldOffset(Offset = "0xEC")]
  [UIParticleSystem.Particle]
  public UIParticleSystem.FloatRange startLifetime;
  [Token(Token = "0x400070B")]
  [FieldOffset(Offset = "0xF4")]
  [UIParticleSystem.Particle]
  public UIParticleSystem.FloatRange startRotation;
  [Token(Token = "0x400070C")]
  [FieldOffset(Offset = "0xFC")]
  [UIParticleSystem.Particle]
  public UIParticleSystem.FloatRange startSize;
  [Token(Token = "0x400070D")]
  [FieldOffset(Offset = "0x104")]
  [UIParticleSystem.Particle]
  public UIParticleSystem.FloatRange startSpeed;
  [Token(Token = "0x400070E")]
  [FieldOffset(Offset = "0x10C")]
  [UIParticleSystem.Particle]
  public float emitterRotation;
  [Token(Token = "0x400070F")]
  [FieldOffset(Offset = "0x110")]
  [UIParticleSystem.Particle]
  public UIParticleSystem.FloatRange angularVelocity;
  [Token(Token = "0x4000710")]
  [FieldOffset(Offset = "0x118")]
  public bool angularVelocityEnable;
  [Token(Token = "0x4000711")]
  [FieldOffset(Offset = "0x11C")]
  [UIParticleSystem.Particle]
  public AnimationCurve rotationOverLifetime;
  [Token(Token = "0x4000712")]
  [FieldOffset(Offset = "0x120")]
  public bool rotationOverLifetimeEnable;
  [Token(Token = "0x4000713")]
  [FieldOffset(Offset = "0x124")]
  [UIParticleSystem.Particle]
  public Gradient colorOverLifetime;
  [Token(Token = "0x4000714")]
  [FieldOffset(Offset = "0x128")]
  public bool colorOverLifetimeEnable;
  [Token(Token = "0x4000715")]
  [FieldOffset(Offset = "0x12C")]
  [UIParticleSystem.Particle]
  public AnimationCurve sizeOverLifetime;
  [Token(Token = "0x4000716")]
  [FieldOffset(Offset = "0x130")]
  public bool sizeOverLifetimeEnable;
  [Token(Token = "0x4000717")]
  [FieldOffset(Offset = "0x134")]
  [UIParticleSystem.Particle]
  public UIParticleSystem.TextureSheetAnimation textureSheetAnimation;
  [Token(Token = "0x4000718")]
  [FieldOffset(Offset = "0x148")]
  public bool textureSheetAnimationEnable;
  [Token(Token = "0x4000719")]
  [FieldOffset(Offset = "0x14C")]
  [UIParticleSystem.Particle]
  public UIParticleSystem.ParticleBurst burst;
  [Token(Token = "0x400071A")]
  [FieldOffset(Offset = "0x150")]
  public bool burstEnable;
  [Token(Token = "0x400071B")]
  [FieldOffset(Offset = "0x154")]
  [UIParticleSystem.Particle]
  public UIParticleSystem.VelocityOverLifetime velocityOverLifetime;
  [Token(Token = "0x400071C")]
  [FieldOffset(Offset = "0x164")]
  public bool velocityOverLifetimeEnable;
  [Token(Token = "0x400071D")]
  [FieldOffset(Offset = "0x165")]
  [NonSerialized]
  public bool IsPlaying;
  [Token(Token = "0x400071E")]
  [FieldOffset(Offset = "0x166")]
  [NonSerialized]
  public bool emit;
  [Token(Token = "0x400071F")]
  [FieldOffset(Offset = "0x168")]
  private float mSpawnCount;

  [Token(Token = "0x17000149")]
  public int particleCount
  {
    [Token(Token = "0x600097B"), Address(RVA = "0xF534D0", Offset = "0xF522D0", VA = "0x10F534D0")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x1700014A")]
  public float PlaybackTime
  {
    [Token(Token = "0x600097C"), Address(RVA = "0xF533F0", Offset = "0xF521F0", VA = "0x10F533F0")] get
    {
      return new float();
    }
    [Token(Token = "0x600097D"), Address(RVA = "0xF53510", Offset = "0xF52310", VA = "0x10F53510")] set
    {
    }
  }

  [Token(Token = "0x600097E")]
  [Address(RVA = "0xF51F20", Offset = "0xF50D20", VA = "0x10F51F20")]
  public bool IsAlive() => new bool();

  [Token(Token = "0x600097F")]
  [Address(RVA = "0xF53020", Offset = "0xF51E20", VA = "0x10F53020", Slot = "6")]
  protected override void Start()
  {
  }

  [Token(Token = "0x6000980")]
  [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "46")]
  public override bool Raycast(Vector2 sp, Camera eventCamera) => new bool();

  [Token(Token = "0x1700014B")]
  public override Texture mainTexture
  {
    [Token(Token = "0x6000981"), Address(RVA = "0xF53400", Offset = "0xF52200", VA = "0x10F53400", Slot = "35")] get
    {
      return (Texture) null;
    }
  }

  [Token(Token = "0x6000982")]
  [Address(RVA = "0xF52F30", Offset = "0xF51D30", VA = "0x10F52F30")]
  public void ResetParticleSystem()
  {
  }

  [Token(Token = "0x6000983")]
  [Address(RVA = "0xF52FB0", Offset = "0xF51DB0", VA = "0x10F52FB0")]
  public void ResumeEmitters()
  {
  }

  [Token(Token = "0x6000984")]
  [Address(RVA = "0xF52D90", Offset = "0xF51B90", VA = "0x10F52D90")]
  public void PauseEmitters()
  {
  }

  [Token(Token = "0x6000985")]
  [Address(RVA = "0xF52E00", Offset = "0xF51C00", VA = "0x10F52E00")]
  public void ResetEmitters()
  {
  }

  [Token(Token = "0x6000986")]
  [Address(RVA = "0xF53040", Offset = "0xF51E40", VA = "0x10F53040")]
  public void StopEmitters()
  {
  }

  [Token(Token = "0x6000987")]
  [Address(RVA = "0xF530D0", Offset = "0xF51ED0", VA = "0x10F530D0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000988")]
  [Address(RVA = "0xF51040", Offset = "0xF4FE40", VA = "0x10F51040")]
  public void AdvanceTime(float dt)
  {
  }

  [Token(Token = "0x6000989")]
  [Address(RVA = "0xF51F80", Offset = "0xF50D80", VA = "0x10F51F80", Slot = "44")]
  protected override void OnPopulateMesh(VertexHelper vh)
  {
  }

  [Token(Token = "0x600098A")]
  [Address(RVA = "0xF53140", Offset = "0xF51F40", VA = "0x10F53140")]
  public UIParticleSystem()
  {
  }

  [Token(Token = "0x2000173")]
  public enum ParticleUpdateMode
  {
    [Token(Token = "0x4000721")] UnscaledTime,
    [Token(Token = "0x4000722")] GameTime,
    [Token(Token = "0x4000723")] FixedTime,
  }

  [Token(Token = "0x2000174")]
  public enum EmitterTypes
  {
    [Token(Token = "0x4000725")] Cone,
    [Token(Token = "0x4000726")] Sphere,
    [Token(Token = "0x4000727")] Box,
  }

  [Token(Token = "0x2000175")]
  public enum ParticleRenderMode
  {
    [Token(Token = "0x4000729")] Billboard,
    [Token(Token = "0x400072A")] StretchBillboard,
  }

  [Token(Token = "0x2000176")]
  [Serializable]
  public struct ConeEmitter
  {
    [Token(Token = "0x400072B")]
    [FieldOffset(Offset = "0x0")]
    public UIParticleSystem.FloatRange Angle;
    [Token(Token = "0x400072C")]
    [FieldOffset(Offset = "0x8")]
    public UIParticleSystem.FloatRange Radius;
    [Token(Token = "0x400072D")]
    [FieldOffset(Offset = "0x10")]
    public bool RandomDirection;

    [Token(Token = "0x600098B")]
    [Address(RVA = "0xF46580", Offset = "0xF45380", VA = "0x10F46580")]
    public ConeEmitter(float angleMin, float angleMax)
    {
    }
  }

  [Token(Token = "0x2000177")]
  [Serializable]
  public struct SphereEmitter
  {
    [Token(Token = "0x400072E")]
    [FieldOffset(Offset = "0x0")]
    public UIParticleSystem.FloatRange Radius;
    [Token(Token = "0x400072F")]
    [FieldOffset(Offset = "0x8")]
    public bool Inverse;
    [Token(Token = "0x4000730")]
    [FieldOffset(Offset = "0x9")]
    public bool RandomDirection;

    [Token(Token = "0x600098C")]
    [Address(RVA = "0xF4FF10", Offset = "0xF4ED10", VA = "0x10F4FF10")]
    public SphereEmitter(float radiusMin, float radiusMax)
    {
    }
  }

  [Token(Token = "0x2000178")]
  [Serializable]
  public struct BoxEmitter
  {
    [Token(Token = "0x4000731")]
    [FieldOffset(Offset = "0x0")]
    public float Width;
    [Token(Token = "0x4000732")]
    [FieldOffset(Offset = "0x4")]
    public float Height;
    [Token(Token = "0x4000733")]
    [FieldOffset(Offset = "0x8")]
    public bool RandomDirection;

    [Token(Token = "0x600098D")]
    [Address(RVA = "0xF46430", Offset = "0xF45230", VA = "0x10F46430")]
    public BoxEmitter(float w, float h)
    {
    }
  }

  [Token(Token = "0x2000179")]
  public class Particle
  {
    [Token(Token = "0x4000734")]
    [FieldOffset(Offset = "0x8")]
    public float angularVelocity;
    [Token(Token = "0x4000735")]
    [FieldOffset(Offset = "0xC")]
    public Vector3 axisOfRotation;
    [Token(Token = "0x4000736")]
    [FieldOffset(Offset = "0x18")]
    public Color32 color;
    [Token(Token = "0x4000737")]
    [FieldOffset(Offset = "0x1C")]
    public float lifetime;
    [Token(Token = "0x4000738")]
    [FieldOffset(Offset = "0x20")]
    public Vector3 position;
    [Token(Token = "0x4000739")]
    [FieldOffset(Offset = "0x2C")]
    public int randomSeed;
    [Token(Token = "0x400073A")]
    [FieldOffset(Offset = "0x30")]
    public float rotation;
    [Token(Token = "0x400073B")]
    [FieldOffset(Offset = "0x34")]
    public float size;
    [Token(Token = "0x400073C")]
    [FieldOffset(Offset = "0x38")]
    public float startLifetime;
    [Token(Token = "0x400073D")]
    [FieldOffset(Offset = "0x3C")]
    public float startRotation;
    [Token(Token = "0x400073E")]
    [FieldOffset(Offset = "0x40")]
    public Vector3 velocity;
    [Token(Token = "0x400073F")]
    [FieldOffset(Offset = "0x4C")]
    public Vector2 visualVelocity;

    [Token(Token = "0x600098E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Particle()
    {
    }
  }

  [Token(Token = "0x200017A")]
  [Serializable]
  public struct FloatRange
  {
    [Token(Token = "0x4000740")]
    [FieldOffset(Offset = "0x0")]
    public float Min;
    [Token(Token = "0x4000741")]
    [FieldOffset(Offset = "0x4")]
    public float Max;

    [Token(Token = "0x600098F")]
    [Address(RVA = "0xF473B0", Offset = "0xF461B0", VA = "0x10F473B0")]
    public float Evaluate() => new float();

    [Token(Token = "0x6000990")]
    [Address(RVA = "0x7CCB20", Offset = "0x7CB920", VA = "0x107CCB20")]
    public FloatRange(float min, float max)
    {
    }
  }

  [Token(Token = "0x200017B")]
  [Serializable]
  public struct ColorRange
  {
    [Token(Token = "0x4000742")]
    [FieldOffset(Offset = "0x0")]
    public Color Min;
    [Token(Token = "0x4000743")]
    [FieldOffset(Offset = "0x10")]
    public Color Max;

    [Token(Token = "0x6000991")]
    [Address(RVA = "0xF46450", Offset = "0xF45250", VA = "0x10F46450")]
    public Color Evaluate() => new Color();

    [Token(Token = "0x6000992")]
    [Address(RVA = "0xF46510", Offset = "0xF45310", VA = "0x10F46510")]
    public ColorRange(Color min, Color max)
    {
    }
  }

  [Token(Token = "0x200017C")]
  [Serializable]
  public struct TextureSheetAnimation
  {
    [Token(Token = "0x4000744")]
    [FieldOffset(Offset = "0x0")]
    public int TilesX;
    [Token(Token = "0x4000745")]
    [FieldOffset(Offset = "0x4")]
    public int TilesY;
    [Token(Token = "0x4000746")]
    [FieldOffset(Offset = "0x8")]
    public AnimationCurve FrameOverTime;
    [Token(Token = "0x4000747")]
    [FieldOffset(Offset = "0xC")]
    public UIParticleSystem.TextureSheetAnimation.AnimationRow Animation;
    [Token(Token = "0x4000748")]
    [FieldOffset(Offset = "0x10")]
    public int Cycles;

    [Token(Token = "0x6000993")]
    [Address(RVA = "0xF507F0", Offset = "0xF4F5F0", VA = "0x10F507F0")]
    public TextureSheetAnimation(int tx, int ty)
    {
    }

    [Token(Token = "0x200017D")]
    public enum AnimationRow
    {
      [Token(Token = "0x400074A")] WholeSheet,
      [Token(Token = "0x400074B")] RandomRow,
    }
  }

  [Token(Token = "0x200017E")]
  [Serializable]
  public struct ParticleBurstPoint
  {
    [Token(Token = "0x400074C")]
    [FieldOffset(Offset = "0x0")]
    public float Time;
    [Token(Token = "0x400074D")]
    [FieldOffset(Offset = "0x4")]
    public int Count;
  }

  [Token(Token = "0x200017F")]
  [Serializable]
  public struct ParticleBurst
  {
    [Token(Token = "0x400074E")]
    [FieldOffset(Offset = "0x0")]
    public UIParticleSystem.ParticleBurstPoint[] Points;

    [Token(Token = "0x6000994")]
    [Address(RVA = "0xF4FDE0", Offset = "0xF4EBE0", VA = "0x10F4FDE0")]
    public ParticleBurst(int n)
    {
    }
  }

  [Token(Token = "0x2000180")]
  [Serializable]
  public struct VelocityOverLifetime
  {
    [Token(Token = "0x400074F")]
    [FieldOffset(Offset = "0x0")]
    public AnimationCurve X;
    [Token(Token = "0x4000750")]
    [FieldOffset(Offset = "0x4")]
    public AnimationCurve Y;
    [Token(Token = "0x4000751")]
    [FieldOffset(Offset = "0x8")]
    public float ScaleX;
    [Token(Token = "0x4000752")]
    [FieldOffset(Offset = "0xC")]
    public float ScaleY;

    [Token(Token = "0x6000995")]
    [Address(RVA = "0xF54C50", Offset = "0xF53A50", VA = "0x10F54C50")]
    public VelocityOverLifetime(int n)
    {
    }
  }

  [Token(Token = "0x2000181")]
  [Serializable]
  public struct StretchBillboard
  {
    [Token(Token = "0x4000753")]
    [FieldOffset(Offset = "0x0")]
    public float LengthScale;
    [Token(Token = "0x4000754")]
    [FieldOffset(Offset = "0x4")]
    public float SpeedScale;

    [Token(Token = "0x6000996")]
    [Address(RVA = "0x7CCB20", Offset = "0x7CB920", VA = "0x107CCB20")]
    public StretchBillboard(float lengthScale, float speedScale)
    {
    }
  }

  [Token(Token = "0x2000182")]
  public class ParticleAttribute : PropertyAttribute
  {
    [Token(Token = "0x6000997")]
    [Address(RVA = "0xC7EC20", Offset = "0xC7DA20", VA = "0x10C7EC20")]
    public ParticleAttribute()
    {
    }
  }
}
