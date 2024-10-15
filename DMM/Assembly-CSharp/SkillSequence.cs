// Decompiled with JetBrains decompiler
// Type: SkillSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000016")]
public class SkillSequence
{
  [Token(Token = "0x4000054")]
  [FieldOffset(Offset = "0x0")]
  private static List<SkillSequence> mSequences;
  [Token(Token = "0x4000055")]
  [FieldOffset(Offset = "0x8")]
  public string Name;
  [Token(Token = "0x4000056")]
  [FieldOffset(Offset = "0xC")]
  public int NameHash;
  [Token(Token = "0x4000057")]
  [FieldOffset(Offset = "0x10")]
  public SkillSequence.AnimationSettings ChantAnimation;
  [Token(Token = "0x4000058")]
  [FieldOffset(Offset = "0x18")]
  public SkillSequence.AnimationSettings SkillAnimation;
  [Token(Token = "0x4000059")]
  [FieldOffset(Offset = "0x20")]
  public SkillSequence.AnimationSettings EndAnimation;
  [Token(Token = "0x400005A")]
  [FieldOffset(Offset = "0x28")]
  public string ChantCameraClipName;
  [Token(Token = "0x400005B")]
  [FieldOffset(Offset = "0x2C")]
  public string StartAnimation;
  [Token(Token = "0x400005C")]
  [FieldOffset(Offset = "0x30")]
  public bool InterpChantCamera;
  [Token(Token = "0x400005D")]
  [FieldOffset(Offset = "0x34")]
  public string MainCameraClipName;
  [Token(Token = "0x400005E")]
  [FieldOffset(Offset = "0x38")]
  public bool InterpSkillCamera;
  [Token(Token = "0x400005F")]
  [FieldOffset(Offset = "0x3C")]
  public string EndCameraClipName;
  [Token(Token = "0x4000060")]
  [FieldOffset(Offset = "0x40")]
  public float EndLength;
  [Token(Token = "0x4000061")]
  [FieldOffset(Offset = "0x44")]
  public float ProjectileHitDelay;
  [Token(Token = "0x4000062")]
  [FieldOffset(Offset = "0x48")]
  [Description("スキルの種類")]
  public SkillSequence.SkillTypes SkillType;
  [Token(Token = "0x4000063")]
  [FieldOffset(Offset = "0x4C")]
  [Description("スキル使用時の振り向きの種類")]
  public SkillSequence.SkillTurnTypes SkillTurnType;
  [Token(Token = "0x4000064")]
  [FieldOffset(Offset = "0x50")]
  [Description("MAPで行うスキル演出に対するカメラ動作")]
  public SkillSequence.MapCameraTypes MapCameraType;
  [Token(Token = "0x4000065")]
  [FieldOffset(Offset = "0x54")]
  public bool NotMirror;
  [Token(Token = "0x4000066")]
  [FieldOffset(Offset = "0x55")]
  public bool IgnoreComAnim;

  [Token(Token = "0x6000080")]
  [Address(RVA = "0x2CC9D0", Offset = "0x2CB7D0", VA = "0x102CC9D0")]
  private static void OnApplicationQuit()
  {
  }

  [Token(Token = "0x6000081")]
  [Address(RVA = "0x2CCA90", Offset = "0x2CB890", VA = "0x102CCA90")]
  public static void UnloadAll()
  {
  }

  [Token(Token = "0x6000082")]
  [Address(RVA = "0x2CBF10", Offset = "0x2CAD10", VA = "0x102CBF10")]
  private static void LoadSequences(bool is_editor = false)
  {
  }

  [Token(Token = "0x6000083")]
  [Address(RVA = "0x2CCA60", Offset = "0x2CB860", VA = "0x102CCA60")]
  private static float ParseFloat(string s) => new float();

  [Token(Token = "0x6000084")]
  [Address(RVA = "0x2CCA10", Offset = "0x2CB810", VA = "0x102CCA10")]
  private static bool ParseBool(string s) => new bool();

  [Token(Token = "0x6000085")]
  [Address(RVA = "0x2CBDE0", Offset = "0x2CABE0", VA = "0x102CBDE0")]
  public static SkillSequence FindSequence(string name, bool is_editor = false)
  {
    return (SkillSequence) null;
  }

  [Token(Token = "0x6000086")]
  [Address(RVA = "0x2CCAD0", Offset = "0x2CB8D0", VA = "0x102CCAD0")]
  public SkillSequence()
  {
  }

  [Token(Token = "0x2000017")]
  [Serializable]
  public struct AnimationSettings
  {
    [Token(Token = "0x4000067")]
    [FieldOffset(Offset = "0x0")]
    public string Name;
    [Token(Token = "0x4000068")]
    [FieldOffset(Offset = "0x4")]
    public bool UseCamera;
  }

  [Token(Token = "0x2000018")]
  public enum MapCameraTypes
  {
    [Token(Token = "0x400006A")] None,
    [Token(Token = "0x400006B")] FirstTargetCenter,
    [Token(Token = "0x400006C")] FarDistance,
    [Token(Token = "0x400006D")] MoreFarDistance,
    [Token(Token = "0x400006E")] AllTargetsCenter,
    [Token(Token = "0x400006F")] AllTargetsAndSelfCenter,
  }

  [Token(Token = "0x2000019")]
  public enum SkillTypes
  {
    [Token(Token = "0x4000071")] Melee,
    [Token(Token = "0x4000072")] Ranged,
    [Token(Token = "0x4000073")] RangedRayNoMovCmr,
    [Token(Token = "0x4000074")] RangedRayFirstMovCmr,
    [Token(Token = "0x4000075")] RangedRayLastMovCmr,
  }

  [Token(Token = "0x200001A")]
  public enum SkillTurnTypes
  {
    [Token(Token = "0x4000077")] None,
    [Token(Token = "0x4000078")] Target,
    [Token(Token = "0x4000079")] Axis,
  }
}
