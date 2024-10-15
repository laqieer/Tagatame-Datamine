// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRepeatQuestUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200206F")]
  [AddComponentMenu("UI/AutoRepeatQuest/AutoRepeatQuestUnit")]
  public class AutoRepeatQuestUnit : UnitController
  {
    [Token(Token = "0x4008BA9")]
    private const string ID_IDLE = "idle";
    [Token(Token = "0x4008BAA")]
    private const string ID_ACTION = "action";
    [Token(Token = "0x4008BAB")]
    private const string ID_RUN = "RUN";
    [Token(Token = "0x4008BAC")]
    [FieldOffset(Offset = "0x128")]
    private string mCurrentAnimId;
    [Token(Token = "0x4008BAD")]
    [FieldOffset(Offset = "0x12C")]
    private float mElapsedTime;
    [Token(Token = "0x4008BAE")]
    [FieldOffset(Offset = "0x130")]
    private Projector mShadow;
    [Token(Token = "0x4008BAF")]
    [FieldOffset(Offset = "0x134")]
    private bool mIsDispShadow;
    [Token(Token = "0x4008BB0")]
    [FieldOffset(Offset = "0x138")]
    private AutoRepeatQuestUnit.UnitAnimationParam mParam;
    [Token(Token = "0x4008BB1")]
    [FieldOffset(Offset = "0x13C")]
    private AutoRepeatQuestUnit.eState mState;

    [Token(Token = "0x60086E1")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "11")]
    protected override bool IsEventAllowed(AnimEvent e) => new bool();

    [Token(Token = "0x60086E2")]
    [Address(RVA = "0x483E30", Offset = "0x482C30", VA = "0x10483E30", Slot = "4")]
    protected override void Start()
    {
    }

    [Token(Token = "0x60086E3")]
    [Address(RVA = "0x483D10", Offset = "0x482B10", VA = "0x10483D10")]
    public void SetUnitData(
      AutoRepeatQuestUnit.UnitAnimationParam param,
      bool is_finished,
      bool is_disp_shadow)
    {
    }

    [Token(Token = "0x60086E4")]
    [Address(RVA = "0x483670", Offset = "0x482470", VA = "0x10483670")]
    private void CreateShadow()
    {
    }

    [Token(Token = "0x60086E5")]
    [Address(RVA = "0x483BA0", Offset = "0x4829A0", VA = "0x10483BA0", Slot = "21")]
    protected override void PostSetup()
    {
    }

    [Token(Token = "0x60086E6")]
    [Address(RVA = "0x483A10", Offset = "0x482810", VA = "0x10483A10")]
    private IEnumerator LoadThread() => (IEnumerator) null;

    [Token(Token = "0x60086E7")]
    [Address(RVA = "0x483F60", Offset = "0x482D60", VA = "0x10483F60", Slot = "15")]
    protected override void Update()
    {
    }

    [Token(Token = "0x60086E8")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update_StateRunning()
    {
    }

    [Token(Token = "0x60086E9")]
    [Address(RVA = "0x483E50", Offset = "0x482C50", VA = "0x10483E50")]
    private void Update_StateFinished()
    {
    }

    [Token(Token = "0x60086EA")]
    [Address(RVA = "0x483A80", Offset = "0x482880", VA = "0x10483A80")]
    private void PlayUnitAnimation(string anim_id, bool loop, float startTime = 0.0f)
    {
    }

    [Token(Token = "0x60086EB")]
    [Address(RVA = "0x483DF0", Offset = "0x482BF0", VA = "0x10483DF0")]
    private void Setup_Running()
    {
    }

    [Token(Token = "0x60086EC")]
    [Address(RVA = "0x483DB0", Offset = "0x482BB0", VA = "0x10483DB0")]
    private void Setup_Finished()
    {
    }

    [Token(Token = "0x60086ED")]
    [Address(RVA = "0x4839A0", Offset = "0x4827A0", VA = "0x104839A0")]
    private void LoadAnimation_Running()
    {
    }

    [Token(Token = "0x60086EE")]
    [Address(RVA = "0x483920", Offset = "0x482720", VA = "0x10483920")]
    private void LoadAnimation_Finished()
    {
    }

    [Token(Token = "0x60086EF")]
    [Address(RVA = "0x4840A0", Offset = "0x482EA0", VA = "0x104840A0")]
    public AutoRepeatQuestUnit()
    {
    }

    [Token(Token = "0x2002070")]
    public enum eState
    {
      [Token(Token = "0x4008BB3")] None,
      [Token(Token = "0x4008BB4")] Running,
      [Token(Token = "0x4008BB5")] Finished,
    }

    [Token(Token = "0x2002071")]
    [Serializable]
    public class UnitAnimationParam
    {
      [Token(Token = "0x4008BB6")]
      [FieldOffset(Offset = "0x8")]
      [SerializeField]
      private Transform mRunningPos;
      [Token(Token = "0x4008BB7")]
      [FieldOffset(Offset = "0xC")]
      [SerializeField]
      private Transform mFinishedPos;
      [Token(Token = "0x4008BB8")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private float mRunningSpeed;
      [Token(Token = "0x4008BB9")]
      [FieldOffset(Offset = "0x14")]
      [SerializeField]
      private float mIdleSpeed;
      [Token(Token = "0x4008BBA")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private float mActionSpeed;
      [Token(Token = "0x4008BBB")]
      [FieldOffset(Offset = "0x1C")]
      [SerializeField]
      private float mIdleTime;
      [Token(Token = "0x4008BBC")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private float mRunAnimStartTime;

      [Token(Token = "0x1700131D")]
      public Transform RunningPos
      {
        [Token(Token = "0x60086F0"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (Transform) null;
        }
      }

      [Token(Token = "0x1700131E")]
      public Transform FinishedPos
      {
        [Token(Token = "0x60086F1"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (Transform) null;
        }
      }

      [Token(Token = "0x1700131F")]
      public float RunningSpeed
      {
        [Token(Token = "0x60086F2"), Address(RVA = "0x2CD710", Offset = "0x2CC510", VA = "0x102CD710")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x17001320")]
      public float IdleSpeed
      {
        [Token(Token = "0x60086F3"), Address(RVA = "0x2C72E0", Offset = "0x2C60E0", VA = "0x102C72E0")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x17001321")]
      public float ActionSpeed
      {
        [Token(Token = "0x60086F4"), Address(RVA = "0x3A3980", Offset = "0x3A2780", VA = "0x103A3980")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x17001322")]
      public float IdleTime
      {
        [Token(Token = "0x60086F5"), Address(RVA = "0x3A3950", Offset = "0x3A2750", VA = "0x103A3950")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x17001323")]
      public float RunAnimStartTime
      {
        [Token(Token = "0x60086F6"), Address(RVA = "0x3A3990", Offset = "0x3A2790", VA = "0x103A3990")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x60086F7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UnitAnimationParam()
      {
      }
    }
  }
}
