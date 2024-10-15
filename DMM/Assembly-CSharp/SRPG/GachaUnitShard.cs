// Decompiled with JetBrains decompiler
// Type: SRPG.GachaUnitShard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200245C")]
  [AddComponentMenu("UI/GachaUnitShard")]
  public class GachaUnitShard : MonoBehaviour
  {
    [Token(Token = "0x400A568")]
    [FieldOffset(Offset = "0xC")]
    private StateMachine<GachaUnitShard> mState;
    [Token(Token = "0x400A569")]
    [FieldOffset(Offset = "0x10")]
    public float WaitGaugeActionStarted;
    [Token(Token = "0x400A56A")]
    [FieldOffset(Offset = "0x14")]
    public float WaitGaugeActioned;
    [Token(Token = "0x400A56B")]
    [FieldOffset(Offset = "0x18")]
    public float WaitRebirthStarActioned;
    [Token(Token = "0x400A56C")]
    [FieldOffset(Offset = "0x1C")]
    public float WaitRebirthTextActioned;
    [Token(Token = "0x400A56D")]
    [FieldOffset(Offset = "0x20")]
    public float GaugeUpAnimSpan;
    [Token(Token = "0x400A56E")]
    [FieldOffset(Offset = "0x24")]
    public int GaugeUpAnimSoundSpan;
    [Token(Token = "0x400A56F")]
    [FieldOffset(Offset = "0x28")]
    public string[] GaugeUpAnimSoundList;
    [Token(Token = "0x400A570")]
    [FieldOffset(Offset = "0x2C")]
    private string[] DefaultGaugeUpAnimSoundList;
    [Token(Token = "0x400A571")]
    [FieldOffset(Offset = "0x30")]
    public GameObject gauge_bar;
    [Token(Token = "0x400A572")]
    [FieldOffset(Offset = "0x34")]
    public GameObject rebirthstar_root;
    [Token(Token = "0x400A573")]
    [FieldOffset(Offset = "0x38")]
    public GameObject rebirthstar_template;
    [Token(Token = "0x400A574")]
    [FieldOffset(Offset = "0x3C")]
    public RawImage unit_img;
    [Token(Token = "0x400A575")]
    [FieldOffset(Offset = "0x40")]
    public RawImage unit_img_blur01;
    [Token(Token = "0x400A576")]
    [FieldOffset(Offset = "0x44")]
    public RawImage unit_img_blur02;
    [Token(Token = "0x400A577")]
    [FieldOffset(Offset = "0x48")]
    public RawPolyImage unit_icon;
    [Token(Token = "0x400A578")]
    [FieldOffset(Offset = "0x4C")]
    public Image_Transparent element_icon;
    [Token(Token = "0x400A579")]
    [FieldOffset(Offset = "0x50")]
    public Text ShardName;
    [Token(Token = "0x400A57A")]
    [FieldOffset(Offset = "0x54")]
    public Text JobName;
    [Token(Token = "0x400A57B")]
    [FieldOffset(Offset = "0x58")]
    public Text JobComment;
    [Token(Token = "0x400A57C")]
    [FieldOffset(Offset = "0x5C")]
    public Text ShardNext;
    [Token(Token = "0x400A57D")]
    [FieldOffset(Offset = "0x60")]
    public Text ShardCurrent;
    [Token(Token = "0x400A57E")]
    [FieldOffset(Offset = "0x64")]
    public SliderAnimator ShardGauge;
    [Token(Token = "0x400A57F")]
    [FieldOffset(Offset = "0x68")]
    public GameObject Rebirthtext_root;
    [Token(Token = "0x400A580")]
    [FieldOffset(Offset = "0x6C")]
    private string[] mJobNameList;
    [Token(Token = "0x400A581")]
    [FieldOffset(Offset = "0x70")]
    private bool mUnlockUnit;
    [Token(Token = "0x400A582")]
    [FieldOffset(Offset = "0x71")]
    private bool mNotUnlockUnit;
    [Token(Token = "0x400A583")]
    private const string TRIGGER_SHARDGAUGE_CLOSE = "close";
    [Token(Token = "0x400A584")]
    private const string TRIGGER_JOBOPEN_START = "jobopen_start";
    [Token(Token = "0x400A585")]
    private const string TRIGGER_JOBOPEN_NEXT = "job_next";
    [Token(Token = "0x400A586")]
    private const string TRIGGER_JOBOPEN_END = "jobopen_end";
    [Token(Token = "0x400A587")]
    private const string TRIGGER_JOBOPEN_CLOSE = "jobopen_close";
    [Token(Token = "0x400A588")]
    [FieldOffset(Offset = "0x74")]
    private string ShardGaugeStartAnim;
    [Token(Token = "0x400A589")]
    private const string GachaShardAwakeText = "sys.GACHA_TEXT_SHARD_AWAKE";
    [Token(Token = "0x400A58A")]
    [FieldOffset(Offset = "0x78")]
    private bool isRunningAnimator;
    [Token(Token = "0x400A58B")]
    [FieldOffset(Offset = "0x7C")]
    private int StartAwakeLv;
    [Token(Token = "0x400A58C")]
    [FieldOffset(Offset = "0x80")]
    private int NowAwakeLv;
    [Token(Token = "0x400A58D")]
    [FieldOffset(Offset = "0x84")]
    private int NextAwakeLv;
    [Token(Token = "0x400A58E")]
    [FieldOffset(Offset = "0x88")]
    private int AwakeLvCap;
    [Token(Token = "0x400A58F")]
    [FieldOffset(Offset = "0x8C")]
    private int mCurrentAwakeJobIndex;
    [Token(Token = "0x400A590")]
    [FieldOffset(Offset = "0x90")]
    private bool mClicked;
    [Token(Token = "0x400A591")]
    [FieldOffset(Offset = "0x94")]
    private List<GameObject> mRebirthStars;
    [Token(Token = "0x400A592")]
    [FieldOffset(Offset = "0x98")]
    private List<string> mJobID;
    [Token(Token = "0x400A593")]
    [FieldOffset(Offset = "0x9C")]
    private List<int> mJobAwakeLv;
    [Token(Token = "0x400A594")]
    private const float ShardAnimSpan = 1f;
    [Token(Token = "0x400A595")]
    [FieldOffset(Offset = "0xA0")]
    private float mShardStart;
    [Token(Token = "0x400A596")]
    [FieldOffset(Offset = "0xA4")]
    private float mShardEnd;
    [Token(Token = "0x400A597")]
    [FieldOffset(Offset = "0xA8")]
    private float mShardAnimTime;
    [Token(Token = "0x400A598")]
    [FieldOffset(Offset = "0xAC")]
    private float mShardGet;
    [Token(Token = "0x400A599")]
    [FieldOffset(Offset = "0xB0")]
    private bool mJobEffectFlag;
    [Token(Token = "0x400A59A")]
    [FieldOffset(Offset = "0xB4")]
    private string mCurrentUnitIname;
    [Token(Token = "0x400A59B")]
    [FieldOffset(Offset = "0xB8")]
    private int mget_shard;
    [Token(Token = "0x400A59C")]
    [FieldOffset(Offset = "0xBC")]
    private int msub_shard;
    [Token(Token = "0x400A59D")]
    [FieldOffset(Offset = "0xC0")]
    private int muse_shard;
    [Token(Token = "0x400A59E")]
    [FieldOffset(Offset = "0xC4")]
    private int mremain_shard;
    [Token(Token = "0x400A59F")]
    [FieldOffset(Offset = "0xC8")]
    private int mnext_shard;
    [Token(Token = "0x400A5A0")]
    [FieldOffset(Offset = "0xCC")]
    private int mstart_gauge;

    [Token(Token = "0x1700163C")]
    public bool UnlockUnit
    {
      [Token(Token = "0x6009EF5"), Address(RVA = "0x5FE310", Offset = "0x5FD110", VA = "0x105FE310")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009EF6")]
    [Address(RVA = "0x618B20", Offset = "0x617920", VA = "0x10618B20")]
    private void Start()
    {
    }

    [Token(Token = "0x6009EF7")]
    [Address(RVA = "0x618D50", Offset = "0x617B50", VA = "0x10618D50")]
    private void Update()
    {
    }

    [Token(Token = "0x1700163D")]
    public bool IsRunningAnimator
    {
      [Token(Token = "0x6009EF8"), Address(RVA = "0x2B5E80", Offset = "0x2B4C80", VA = "0x102B5E80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009EF9")]
    [Address(RVA = "0x618970", Offset = "0x617770", VA = "0x10618970")]
    public void Reset()
    {
    }

    [Token(Token = "0x6009EFA")]
    [Address(RVA = "0x618980", Offset = "0x617780", VA = "0x10618980")]
    public void Restart()
    {
    }

    [Token(Token = "0x6009EFB")]
    [Address(RVA = "0x617320", Offset = "0x616120", VA = "0x10617320")]
    public void OnClicked()
    {
    }

    [Token(Token = "0x6009EFC")]
    [Address(RVA = "0x617000", Offset = "0x615E00", VA = "0x10617000")]
    private int GetPastShard(int index = 0, string iname = "") => new int();

    [Token(Token = "0x6009EFD")]
    [Address(RVA = "0x616DC0", Offset = "0x615BC0", VA = "0x10616DC0")]
    private int GetAmountShardEx(int index = 0, string iname = "") => new int();

    [Token(Token = "0x6009EFE")]
    [Address(RVA = "0x617A60", Offset = "0x616860", VA = "0x10617A60")]
    private void RefreshShardValue()
    {
    }

    [Token(Token = "0x6009EFF")]
    [Address(RVA = "0x617760", Offset = "0x616560", VA = "0x10617760")]
    private void RefreshJobWindow()
    {
    }

    [Token(Token = "0x6009F00")]
    [Address(RVA = "0x6170D0", Offset = "0x615ED0", VA = "0x106170D0")]
    private void InitRebirthStar()
    {
    }

    [Token(Token = "0x6009F01")]
    [Address(RVA = "0x6172D0", Offset = "0x6160D0", VA = "0x106172D0")]
    public bool IsReachingAwakelv() => new bool();

    [Token(Token = "0x6009F02")]
    [Address(RVA = "0x6172F0", Offset = "0x6160F0", VA = "0x106172F0")]
    public bool IsReachingUnlockUnit() => new bool();

    [Token(Token = "0x6009F03")]
    [Address(RVA = "0x617BC0", Offset = "0x6169C0", VA = "0x10617BC0")]
    public void Refresh(
      UnitParam param,
      string shard_name = "",
      int awake_lv = 0,
      int get_shard = 0,
      int current_index = 0)
    {
    }

    [Token(Token = "0x6009F04")]
    [Address(RVA = "0x617420", Offset = "0x616220", VA = "0x10617420")]
    private void RefreshAddStar()
    {
    }

    [Token(Token = "0x6009F05")]
    [Address(RVA = "0x617330", Offset = "0x616130", VA = "0x10617330")]
    private void RefreshAddGauge()
    {
    }

    [Token(Token = "0x6009F06")]
    [Address(RVA = "0x618AF0", Offset = "0x6178F0", VA = "0x10618AF0")]
    private void SetUsedShard(int end_gauge)
    {
    }

    [Token(Token = "0x6009F07")]
    [Address(RVA = "0x616B00", Offset = "0x615900", VA = "0x10616B00")]
    private void AnimationShard()
    {
    }

    [Token(Token = "0x6009F08")]
    [Address(RVA = "0x6178F0", Offset = "0x6166F0", VA = "0x106178F0")]
    private void RefreshShardGaugeImmediate()
    {
    }

    [Token(Token = "0x6009F09")]
    [Address(RVA = "0x618A60", Offset = "0x617860", VA = "0x10618A60")]
    private void SetJobEffectIndex()
    {
    }

    [Token(Token = "0x6009F0A")]
    [Address(RVA = "0x617260", Offset = "0x616060", VA = "0x10617260")]
    private bool IsOpenJobAnimation() => new bool();

    [Token(Token = "0x6009F0B")]
    [Address(RVA = "0x618D90", Offset = "0x617B90", VA = "0x10618D90")]
    public GachaUnitShard()
    {
    }

    [Token(Token = "0x200245D")]
    private class State_Init : State<GachaUnitShard>
    {
      [Token(Token = "0x6009F0C")]
      [Address(RVA = "0x62AE20", Offset = "0x629C20", VA = "0x1062AE20", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F0D")]
      [Address(RVA = "0x62AF40", Offset = "0x629D40", VA = "0x1062AF40")]
      public State_Init()
      {
      }
    }

    [Token(Token = "0x200245E")]
    private class State_WaitStartAnimation : State<GachaUnitShard>
    {
      [Token(Token = "0x6009F0E")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F0F")]
      [Address(RVA = "0x62C0F0", Offset = "0x62AEF0", VA = "0x1062C0F0", Slot = "5")]
      public override void Update(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F10")]
      [Address(RVA = "0x62C1C0", Offset = "0x62AFC0", VA = "0x1062C1C0")]
      public State_WaitStartAnimation()
      {
      }
    }

    [Token(Token = "0x200245F")]
    private class State_AddingGaugeSkip : State<GachaUnitShard>
    {
      [Token(Token = "0x6009F11")]
      [Address(RVA = "0x629DA0", Offset = "0x628BA0", VA = "0x10629DA0", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F12")]
      [Address(RVA = "0x629EA0", Offset = "0x628CA0", VA = "0x10629EA0")]
      private IEnumerator WaitGaugeObject() => (IEnumerator) null;

      [Token(Token = "0x6009F13")]
      [Address(RVA = "0x629F10", Offset = "0x628D10", VA = "0x10629F10")]
      public State_AddingGaugeSkip()
      {
      }
    }

    [Token(Token = "0x2002461")]
    private class State_WaitGaugeActionStarted : State<GachaUnitShard>
    {
      [Token(Token = "0x400A5A4")]
      [FieldOffset(Offset = "0xC")]
      private float mWaitTime;
      [Token(Token = "0x400A5A5")]
      [FieldOffset(Offset = "0x10")]
      private float mTimer;

      [Token(Token = "0x6009F1A")]
      [Address(RVA = "0x62BCB0", Offset = "0x62AAB0", VA = "0x1062BCB0", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F1B")]
      [Address(RVA = "0x62BCE0", Offset = "0x62AAE0", VA = "0x1062BCE0", Slot = "5")]
      public override void Update(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F1C")]
      [Address(RVA = "0x62BD80", Offset = "0x62AB80", VA = "0x1062BD80")]
      public State_WaitGaugeActionStarted()
      {
      }
    }

    [Token(Token = "0x2002462")]
    private class State_AddingGauge : State<GachaUnitShard>
    {
      [Token(Token = "0x6009F1D")]
      [Address(RVA = "0x629F50", Offset = "0x628D50", VA = "0x10629F50", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F1E")]
      [Address(RVA = "0x629F80", Offset = "0x628D80", VA = "0x10629F80", Slot = "5")]
      public override void Update(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F1F")]
      [Address(RVA = "0x62A010", Offset = "0x628E10", VA = "0x1062A010")]
      public State_AddingGauge()
      {
      }
    }

    [Token(Token = "0x2002463")]
    private class State_GaugeSkip : State<GachaUnitShard>
    {
      [Token(Token = "0x6009F20")]
      [Address(RVA = "0x62AD30", Offset = "0x629B30", VA = "0x1062AD30", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F21")]
      [Address(RVA = "0x62ADE0", Offset = "0x629BE0", VA = "0x1062ADE0")]
      public State_GaugeSkip()
      {
      }
    }

    [Token(Token = "0x2002464")]
    private class State_WaitGaugeActioned : State<GachaUnitShard>
    {
      [Token(Token = "0x400A5A6")]
      [FieldOffset(Offset = "0xC")]
      private float mWaitTime;
      [Token(Token = "0x400A5A7")]
      [FieldOffset(Offset = "0x10")]
      private float mTimer;

      [Token(Token = "0x6009F22")]
      [Address(RVA = "0x62BDC0", Offset = "0x62ABC0", VA = "0x1062BDC0", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F23")]
      [Address(RVA = "0x62BDF0", Offset = "0x62ABF0", VA = "0x1062BDF0", Slot = "5")]
      public override void Update(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F24")]
      [Address(RVA = "0x62BEC0", Offset = "0x62ACC0", VA = "0x1062BEC0")]
      public State_WaitGaugeActioned()
      {
      }
    }

    [Token(Token = "0x2002465")]
    private class State_AddingRebirthStar : State<GachaUnitShard>
    {
      [Token(Token = "0x400A5A8")]
      [FieldOffset(Offset = "0xC")]
      private Transform rebirth_star;
      [Token(Token = "0x400A5A9")]
      [FieldOffset(Offset = "0x10")]
      private int new_star;

      [Token(Token = "0x6009F25")]
      [Address(RVA = "0x62A050", Offset = "0x628E50", VA = "0x1062A050", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F26")]
      [Address(RVA = "0x62A1F0", Offset = "0x628FF0", VA = "0x1062A1F0", Slot = "5")]
      public override void Update(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F27")]
      [Address(RVA = "0x62A3E0", Offset = "0x6291E0", VA = "0x1062A3E0")]
      public State_AddingRebirthStar()
      {
      }
    }

    [Token(Token = "0x2002466")]
    private class State_WaitAddingRebirthStarActioned : State<GachaUnitShard>
    {
      [Token(Token = "0x400A5AA")]
      [FieldOffset(Offset = "0xC")]
      private float mWaitTime;
      [Token(Token = "0x400A5AB")]
      [FieldOffset(Offset = "0x10")]
      private float mTimer;

      [Token(Token = "0x6009F28")]
      [Address(RVA = "0x62BAD0", Offset = "0x62A8D0", VA = "0x1062BAD0", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F29")]
      [Address(RVA = "0x62BB00", Offset = "0x62A900", VA = "0x1062BB00", Slot = "5")]
      public override void Update(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F2A")]
      [Address(RVA = "0x62BB80", Offset = "0x62A980", VA = "0x1062BB80")]
      public State_WaitAddingRebirthStarActioned()
      {
      }
    }

    [Token(Token = "0x2002467")]
    private class State_ShowRebirthText : State<GachaUnitShard>
    {
      [Token(Token = "0x400A5AC")]
      [FieldOffset(Offset = "0xC")]
      private GameObject anim;

      [Token(Token = "0x6009F2B")]
      [Address(RVA = "0x62B480", Offset = "0x62A280", VA = "0x1062B480", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F2C")]
      [Address(RVA = "0x62B550", Offset = "0x62A350", VA = "0x1062B550", Slot = "5")]
      public override void Update(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F2D")]
      [Address(RVA = "0x62B630", Offset = "0x62A430", VA = "0x1062B630")]
      public State_ShowRebirthText()
      {
      }
    }

    [Token(Token = "0x2002468")]
    private class State_WaitRebirthTextActioned : State<GachaUnitShard>
    {
      [Token(Token = "0x400A5AD")]
      [FieldOffset(Offset = "0xC")]
      private float mWaitTime;
      [Token(Token = "0x400A5AE")]
      [FieldOffset(Offset = "0x10")]
      private float mTimer;

      [Token(Token = "0x6009F2E")]
      [Address(RVA = "0x62BFE0", Offset = "0x62ADE0", VA = "0x1062BFE0", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F2F")]
      [Address(RVA = "0x62C010", Offset = "0x62AE10", VA = "0x1062C010", Slot = "5")]
      public override void Update(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F30")]
      [Address(RVA = "0x62C0B0", Offset = "0x62AEB0", VA = "0x1062C0B0")]
      public State_WaitRebirthTextActioned()
      {
      }
    }

    [Token(Token = "0x2002469")]
    private class State_CheckRemainPiece : State<GachaUnitShard>
    {
      [Token(Token = "0x6009F31")]
      [Address(RVA = "0x62A890", Offset = "0x629690", VA = "0x1062A890", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F32")]
      [Address(RVA = "0x62A980", Offset = "0x629780", VA = "0x1062A980")]
      public State_CheckRemainPiece()
      {
      }
    }

    [Token(Token = "0x200246A")]
    private class State_EndShardGaugeBarAnimation : State<GachaUnitShard>
    {
      [Token(Token = "0x6009F33")]
      [Address(RVA = "0x62AA80", Offset = "0x629880", VA = "0x1062AA80", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F34")]
      [Address(RVA = "0x62AB10", Offset = "0x629910", VA = "0x1062AB10", Slot = "5")]
      public override void Update(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F35")]
      [Address(RVA = "0x62AC10", Offset = "0x629A10", VA = "0x1062AC10")]
      public State_EndShardGaugeBarAnimation()
      {
      }
    }

    [Token(Token = "0x200246B")]
    private class State_StartJobOpenAnimation : State<GachaUnitShard>
    {
      [Token(Token = "0x6009F36")]
      [Address(RVA = "0x62B670", Offset = "0x62A470", VA = "0x1062B670", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F37")]
      [Address(RVA = "0x62B740", Offset = "0x62A540", VA = "0x1062B740", Slot = "5")]
      public override void Update(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F38")]
      [Address(RVA = "0x62B840", Offset = "0x62A640", VA = "0x1062B840")]
      public State_StartJobOpenAnimation()
      {
      }
    }

    [Token(Token = "0x200246C")]
    private class State_CheckJobOpen : State<GachaUnitShard>
    {
      [Token(Token = "0x400A5AF")]
      [FieldOffset(Offset = "0xC")]
      private Animator at;

      [Token(Token = "0x6009F39")]
      [Address(RVA = "0x62A5E0", Offset = "0x6293E0", VA = "0x1062A5E0", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F3A")]
      [Address(RVA = "0x62A630", Offset = "0x629430", VA = "0x1062A630", Slot = "5")]
      public override void Update(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F3B")]
      [Address(RVA = "0x62A700", Offset = "0x629500", VA = "0x1062A700")]
      public State_CheckJobOpen()
      {
      }
    }

    [Token(Token = "0x200246D")]
    private class State_CloseJobOpenAnimation : State<GachaUnitShard>
    {
      [Token(Token = "0x6009F3C")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F3D")]
      [Address(RVA = "0x62A9C0", Offset = "0x6297C0", VA = "0x1062A9C0", Slot = "5")]
      public override void Update(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F3E")]
      [Address(RVA = "0x62AA40", Offset = "0x629840", VA = "0x1062AA40")]
      public State_CloseJobOpenAnimation()
      {
      }
    }

    [Token(Token = "0x200246E")]
    private class State_WaitEndUnitShard : State<GachaUnitShard>
    {
      [Token(Token = "0x400A5B0")]
      [FieldOffset(Offset = "0xC")]
      private float mWaitTime;
      [Token(Token = "0x400A5B1")]
      [FieldOffset(Offset = "0x10")]
      private float mTimer;

      [Token(Token = "0x6009F3F")]
      [Address(RVA = "0x62BBC0", Offset = "0x62A9C0", VA = "0x1062BBC0", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F40")]
      [Address(RVA = "0x62BBF0", Offset = "0x62A9F0", VA = "0x1062BBF0", Slot = "5")]
      public override void Update(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F41")]
      [Address(RVA = "0x62BC70", Offset = "0x62AA70", VA = "0x1062BC70")]
      public State_WaitEndUnitShard()
      {
      }
    }

    [Token(Token = "0x200246F")]
    private class State_EndUnitShard : State<GachaUnitShard>
    {
      [Token(Token = "0x6009F42")]
      [Address(RVA = "0x62AC50", Offset = "0x629A50", VA = "0x1062AC50", Slot = "4")]
      public override void Begin(GachaUnitShard self)
      {
      }

      [Token(Token = "0x6009F43")]
      [Address(RVA = "0x62ACF0", Offset = "0x629AF0", VA = "0x1062ACF0")]
      public State_EndUnitShard()
      {
      }
    }
  }
}
