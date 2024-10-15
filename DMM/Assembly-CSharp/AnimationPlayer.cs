// Decompiled with JetBrains decompiler
// Type: AnimationPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using SRPG.AnimEvents;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000034")]
[AddComponentMenu("Common/AnimationPlayer")]
public class AnimationPlayer : MonoBehaviour
{
  [Token(Token = "0x40000F9")]
  [FieldOffset(Offset = "0xC")]
  private List<AnimationPlayer.AnimationStateSource> mAnimationStates;
  [Token(Token = "0x40000FA")]
  [FieldOffset(Offset = "0x10")]
  private Animation mAnimation;
  [Token(Token = "0x40000FB")]
  [FieldOffset(Offset = "0x14")]
  public EUnitSide UnitSide;
  [Token(Token = "0x40000FC")]
  [FieldOffset(Offset = "0x18")]
  private AnimationPlayer.RootMotionModes mRootMotionMode;
  [Token(Token = "0x40000FD")]
  [FieldOffset(Offset = "0x1C")]
  private Stopwatch mSW;
  [Token(Token = "0x40000FE")]
  [FieldOffset(Offset = "0x20")]
  private bool mCheckLayerHidden;
  [Token(Token = "0x40000FF")]
  [FieldOffset(Offset = "0x24")]
  [NonSerialized]
  public float RootMotionScale;
  [Token(Token = "0x4000100")]
  [FieldOffset(Offset = "0x28")]
  [NonSerialized]
  public string RootMotionBoneName;
  [Token(Token = "0x4000101")]
  [FieldOffset(Offset = "0x2C")]
  private bool mLoadError;
  [Token(Token = "0x4000102")]
  [FieldOffset(Offset = "0x30")]
  [NonSerialized]
  public Vector3 RootMotionInverse;
  [Token(Token = "0x4000103")]
  [FieldOffset(Offset = "0x3C")]
  public string DefaultAnimId;
  [Token(Token = "0x4000104")]
  [FieldOffset(Offset = "0x40")]
  public AnimDef DefaultAnim;
  [Token(Token = "0x4000105")]
  [FieldOffset(Offset = "0x44")]
  public bool DefaultAnimLoop;
  [Token(Token = "0x4000106")]
  [FieldOffset(Offset = "0x48")]
  private string common_skill_id;
  [Token(Token = "0x4000107")]
  [FieldOffset(Offset = "0x4C")]
  private SkillParam skill_param;
  [Token(Token = "0x4000108")]
  [FieldOffset(Offset = "0x0")]
  private static List<AnimationPlayer> mInstances;
  [Token(Token = "0x4000109")]
  [FieldOffset(Offset = "0x50")]
  public AnimationPlayer.AnimationUpdateEvent OnAnimationUpdate;
  [Token(Token = "0x400010A")]
  [FieldOffset(Offset = "0x54")]
  private float mResampleTimer;
  [Token(Token = "0x400010B")]
  [FieldOffset(Offset = "0x58")]
  public bool AlwaysUpdate;
  [Token(Token = "0x400010C")]
  [FieldOffset(Offset = "0x4")]
  private static bool mAllAnimationsUpdated;
  [Token(Token = "0x400010D")]
  [FieldOffset(Offset = "0x59")]
  private bool mUpdated;
  [Token(Token = "0x400010E")]
  [FieldOffset(Offset = "0x8")]
  public static long MaxUpdateTime;
  [Token(Token = "0x400010F")]
  [FieldOffset(Offset = "0x5C")]
  private List<AnimationPlayer.AnimLoadRequest> mAnimLoadRequests;
  [Token(Token = "0x4000110")]
  [FieldOffset(Offset = "0x60")]
  private Dictionary<string, AnimDef> mLoadedAnimations;
  [Token(Token = "0x4000111")]
  [FieldOffset(Offset = "0x64")]
  private List<AnimationPlayer.EntryAnimStateInfo> mEntryAnimStateInfoList;

  [Token(Token = "0x1700001A")]
  public AnimationPlayer.RootMotionModes RootMotionMode
  {
    [Token(Token = "0x600012E"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
    {
      return new AnimationPlayer.RootMotionModes();
    }
    [Token(Token = "0x600012F"), Address(RVA = "0x2C0C80", Offset = "0x2BFA80", VA = "0x102C0C80")] set
    {
    }
  }

  [Token(Token = "0x6000130")]
  [Address(RVA = "0x2BEF70", Offset = "0x2BDD70", VA = "0x102BEF70")]
  protected void SetLoadError()
  {
  }

  [Token(Token = "0x6000131")]
  [Address(RVA = "0x2BC910", Offset = "0x2BB710", VA = "0x102BC910")]
  public void ClearLoadError()
  {
  }

  [Token(Token = "0x1700001B")]
  public bool HasLoadError
  {
    [Token(Token = "0x6000132"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700001C")]
  public Animation AnimationComponent
  {
    [Token(Token = "0x6000133"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
    {
      return (Animation) null;
    }
  }

  [Token(Token = "0x6000134")]
  [Address(RVA = "0x2BF5D0", Offset = "0x2BE3D0", VA = "0x102BF5D0", Slot = "4")]
  protected virtual void Start()
  {
  }

  [Token(Token = "0x6000135")]
  [Address(RVA = "0x2BD920", Offset = "0x2BC720", VA = "0x102BD920", Slot = "5")]
  protected virtual void OnEnable()
  {
  }

  [Token(Token = "0x6000136")]
  [Address(RVA = "0x2BD8B0", Offset = "0x2BC6B0", VA = "0x102BD8B0", Slot = "6")]
  protected virtual void OnDisable()
  {
  }

  [Token(Token = "0x6000137")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
  protected virtual void OnDestroy()
  {
  }

  [Token(Token = "0x6000138")]
  [Address(RVA = "0x2BCEA0", Offset = "0x2BBCA0", VA = "0x102BCEA0")]
  private float EvaluateCurveValue(
    AnimationCurve curve,
    float startTime,
    float endTime,
    float length)
  {
    return new float();
  }

  [Token(Token = "0x6000139")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
  protected virtual void OnEventStart(AnimEvent e, float weight)
  {
  }

  [Token(Token = "0x600013A")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "9")]
  protected virtual void OnEvent(AnimEvent e, float time, float weight)
  {
  }

  [Token(Token = "0x600013B")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "10")]
  protected virtual void OnEventEnd(AnimEvent e, float weight)
  {
  }

  [Token(Token = "0x600013C")]
  [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "11")]
  protected virtual bool IsEventAllowed(AnimEvent e) => new bool();

  [Token(Token = "0x600013D")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "12")]
  public virtual void OnGenerateParticle(GameObject go)
  {
  }

  [Token(Token = "0x600013E")]
  [Address(RVA = "0x2BF920", Offset = "0x2BE720", VA = "0x102BF920")]
  protected void UpdateAnimationStates(float dt, bool forceUpdate)
  {
  }

  [Token(Token = "0x600013F")]
  [Address(RVA = "0x2BC5F0", Offset = "0x2BB3F0", VA = "0x102BC5F0")]
  private void AddClip(AnimationPlayer.AnimationStateSource state)
  {
  }

  [Token(Token = "0x6000140")]
  [Address(RVA = "0x2BE700", Offset = "0x2BD500", VA = "0x102BE700")]
  private void Sample()
  {
  }

  [Token(Token = "0x6000141")]
  [Address(RVA = "0x2BEFF0", Offset = "0x2BDDF0", VA = "0x102BEFF0")]
  public void SkipToAnimationEnd()
  {
  }

  [Token(Token = "0x6000142")]
  [Address(RVA = "0x2BDFF0", Offset = "0x2BCDF0", VA = "0x102BDFF0")]
  private void ProcessAnimationEvents()
  {
  }

  [Token(Token = "0x1700001D")]
  public virtual float LoadProgress
  {
    [Token(Token = "0x6000143"), Address(RVA = "0x2C0BB0", Offset = "0x2BF9B0", VA = "0x102C0BB0", Slot = "13")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x1700001E")]
  public virtual bool IsLoading
  {
    [Token(Token = "0x6000144"), Address(RVA = "0x2C0B70", Offset = "0x2BF970", VA = "0x102C0B70", Slot = "14")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700001F")]
  public int LoadingAnimationCount
  {
    [Token(Token = "0x6000145"), Address(RVA = "0x2C0C40", Offset = "0x2BFA40", VA = "0x102C0C40")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x6000146")]
  [Address(RVA = "0x2C0610", Offset = "0x2BF410", VA = "0x102C0610", Slot = "15")]
  protected virtual void Update()
  {
  }

  [Token(Token = "0x6000147")]
  [Address(RVA = "0x2BD5E0", Offset = "0x2BC3E0", VA = "0x102BD5E0", Slot = "16")]
  protected virtual void LateUpdate()
  {
  }

  [Token(Token = "0x6000148")]
  [Address(RVA = "0x2BF810", Offset = "0x2BE610", VA = "0x102BF810")]
  public void StopAll()
  {
  }

  [Token(Token = "0x6000149")]
  [Address(RVA = "0x2BF870", Offset = "0x2BE670", VA = "0x102BF870")]
  public void StopAnimation(string id)
  {
  }

  [Token(Token = "0x600014A")]
  [Address(RVA = "0x2BD0A0", Offset = "0x2BBEA0", VA = "0x102BD0A0")]
  private AnimationPlayer.AnimationStateSource FindState(string id)
  {
    return (AnimationPlayer.AnimationStateSource) null;
  }

  [Token(Token = "0x600014B")]
  [Address(RVA = "0x2BD5C0", Offset = "0x2BC3C0", VA = "0x102BD5C0")]
  public bool IsAnimationPlaying(string id) => new bool();

  [Token(Token = "0x600014C")]
  [Address(RVA = "0x2BD4D0", Offset = "0x2BC2D0", VA = "0x102BD4D0")]
  public float GetRemainingTime(string id) => new float();

  [Token(Token = "0x600014D")]
  [Address(RVA = "0x2BEF80", Offset = "0x2BDD80", VA = "0x102BEF80")]
  public void SetSpeed(string id, float speed)
  {
  }

  [Token(Token = "0x600014E")]
  [Address(RVA = "0x2BE7D0", Offset = "0x2BD5D0", VA = "0x102BE7D0")]
  public void SetAnimationComponent(Animation animComponent)
  {
  }

  [Token(Token = "0x600014F")]
  [Address(RVA = "0x2BD480", Offset = "0x2BC280", VA = "0x102BD480")]
  public float GetNormalizedTime(string id) => new float();

  [Token(Token = "0x6000150")]
  [Address(RVA = "0x2BD520", Offset = "0x2BC320", VA = "0x102BD520")]
  public float GetTargetWeight(string id) => new float();

  [Token(Token = "0x6000151")]
  [Address(RVA = "0x2BE2E0", Offset = "0x2BD0E0", VA = "0x102BE2E0")]
  public void ResetAnimation()
  {
  }

  [Token(Token = "0x6000152")]
  [Address(RVA = "0x2BDB70", Offset = "0x2BC970", VA = "0x102BDB70")]
  public void PlayAnimation(string id, bool loop, float interpTime, float startTime = 0.0f)
  {
  }

  [Token(Token = "0x6000153")]
  [Address(RVA = "0x2BCFC0", Offset = "0x2BBDC0", VA = "0x102BCFC0")]
  protected AnimDef FindAnimation(string id) => (AnimDef) null;

  [Token(Token = "0x6000154")]
  [Address(RVA = "0x2BD400", Offset = "0x2BC200", VA = "0x102BD400")]
  public float GetLength(string id) => new float();

  [Token(Token = "0x6000155")]
  [Address(RVA = "0x2BD540", Offset = "0x2BC340", VA = "0x102BD540")]
  private static void HACK_Animation_AddClip(
    Animation animation,
    AnimationClip clip,
    string newName)
  {
  }

  [Token(Token = "0x6000156")]
  [Address(RVA = "0x2BDF70", Offset = "0x2BCD70", VA = "0x102BDF70")]
  public void PlayAnimation(string id, bool loop)
  {
  }

  [Token(Token = "0x6000157")]
  [Address(RVA = "0x2BD140", Offset = "0x2BBF40", VA = "0x102BD140")]
  public AnimDef GetActiveAnimation(out float position) => (AnimDef) null;

  [Token(Token = "0x6000158")]
  [Address(RVA = "0x2BCB00", Offset = "0x2BB900", VA = "0x102BCB00")]
  private void EntryAnimState()
  {
  }

  [Token(Token = "0x6000159")]
  [Address(RVA = "0x2BD380", Offset = "0x2BC180", VA = "0x102BD380")]
  public AnimDef GetAnimation(string id) => (AnimDef) null;

  [Token(Token = "0x600015A")]
  [Address(RVA = "0x2BD630", Offset = "0x2BC430", VA = "0x102BD630")]
  public void LoadAnimationAsync(string id, string path)
  {
  }

  [Token(Token = "0x600015B")]
  [Address(RVA = "0x2BC5A0", Offset = "0x2BB3A0", VA = "0x102BC5A0")]
  public void AddAnimation(string id, AnimDef anim)
  {
  }

  [Token(Token = "0x600015C")]
  [Address(RVA = "0x2BF8D0", Offset = "0x2BE6D0", VA = "0x102BF8D0")]
  public void UnloadAnimation(string id)
  {
  }

  [Token(Token = "0x600015D")]
  [Address(RVA = "0x2BC8A0", Offset = "0x2BB6A0", VA = "0x102BC8A0")]
  private IEnumerator AsyncLoadAnimation() => (IEnumerator) null;

  [Token(Token = "0x600015E")]
  [Address(RVA = "0x2BC920", Offset = "0x2BB720", VA = "0x102BC920")]
  private AnimDef CreateInstance(AnimDef asset) => (AnimDef) null;

  [Token(Token = "0x600015F")]
  [Address(RVA = "0x2BD760", Offset = "0x2BC560", VA = "0x102BD760")]
  public void LoadCommonAnimationAsync(string id, string path, SkillParam _param)
  {
  }

  [Token(Token = "0x6000160")]
  [Address(RVA = "0x2BE400", Offset = "0x2BD200", VA = "0x102BE400")]
  private void RewriteAnimDef()
  {
  }

  [Token(Token = "0x6000161")]
  [Address(RVA = "0x2BEA70", Offset = "0x2BD870", VA = "0x102BEA70")]
  private void SetEventHitFrame(
    AnimDef _play_anim,
    SkillParam _param,
    UseCommonAnimHitFrame.HitCase _case,
    float _limit_time = -1f)
  {
  }

  [Token(Token = "0x6000162")]
  [Address(RVA = "0x2BED50", Offset = "0x2BDB50", VA = "0x102BED50")]
  private void SetEventTeleport(AnimDef _play_anim, SkillParam _param)
  {
  }

  [Token(Token = "0x6000163")]
  [Address(RVA = "0x2BE860", Offset = "0x2BD660", VA = "0x102BE860")]
  private void SetEventChanging(AnimDef _play_anim, SkillParam _param)
  {
  }

  [Token(Token = "0x6000164")]
  [Address(RVA = "0x2C09F0", Offset = "0x2BF7F0", VA = "0x102C09F0")]
  public AnimationPlayer()
  {
  }

  [Token(Token = "0x6000165")]
  [Address(RVA = "0x2C0960", Offset = "0x2BF760", VA = "0x102C0960")]
  static AnimationPlayer()
  {
  }

  [Token(Token = "0x2000035")]
  private class AnimationStateSource
  {
    [Token(Token = "0x4000112")]
    [FieldOffset(Offset = "0x8")]
    public string Name;
    [Token(Token = "0x4000113")]
    [FieldOffset(Offset = "0xC")]
    public AnimDef Clip;
    [Token(Token = "0x4000114")]
    [FieldOffset(Offset = "0x10")]
    public float Speed;
    [Token(Token = "0x4000115")]
    [FieldOffset(Offset = "0x14")]
    public float Time;
    [Token(Token = "0x4000116")]
    [FieldOffset(Offset = "0x18")]
    public float TimeOld;
    [Token(Token = "0x4000117")]
    [FieldOffset(Offset = "0x1C")]
    public float Weight;
    [Token(Token = "0x4000118")]
    [FieldOffset(Offset = "0x20")]
    public WrapMode WrapMode;
    [Token(Token = "0x4000119")]
    [FieldOffset(Offset = "0x24")]
    public AnimationState CopiedStateRef;
    [Token(Token = "0x400011A")]
    [FieldOffset(Offset = "0x28")]
    public float DesiredWeight;
    [Token(Token = "0x400011B")]
    [FieldOffset(Offset = "0x2C")]
    public float BlendRate;

    [Token(Token = "0x6000166")]
    [Address(RVA = "0x2C0F20", Offset = "0x2BFD20", VA = "0x102C0F20")]
    public AnimationStateSource()
    {
    }
  }

  [Token(Token = "0x2000036")]
  public enum RootMotionModes
  {
    [Token(Token = "0x400011D")] Translate,
    [Token(Token = "0x400011E")] Velocity,
    [Token(Token = "0x400011F")] Discard,
  }

  [Token(Token = "0x2000037")]
  public delegate void AnimationUpdateEvent(GameObject go);

  [Token(Token = "0x2000038")]
  private class AnimLoadRequest
  {
    [Token(Token = "0x4000120")]
    [FieldOffset(Offset = "0x8")]
    public string id;
    [Token(Token = "0x4000121")]
    [FieldOffset(Offset = "0xC")]
    public string path;
    [Token(Token = "0x4000122")]
    [FieldOffset(Offset = "0x10")]
    public LoadRequest request;

    [Token(Token = "0x600016B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AnimLoadRequest()
    {
    }
  }

  [Token(Token = "0x2000039")]
  private class EntryAnimStateInfo
  {
    [Token(Token = "0x4000123")]
    [FieldOffset(Offset = "0x8")]
    private string name;
    [Token(Token = "0x4000124")]
    [FieldOffset(Offset = "0xC")]
    private AnimationState state;

    [Token(Token = "0x17000020")]
    public string AnimName
    {
      [Token(Token = "0x600016C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000021")]
    public AnimationState AnimState
    {
      [Token(Token = "0x600016D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (AnimationState) null;
      }
    }

    [Token(Token = "0x600016E")]
    [Address(RVA = "0x2C2FC0", Offset = "0x2C1DC0", VA = "0x102C2FC0")]
    public EntryAnimStateInfo(AnimationState _state)
    {
    }
  }
}
