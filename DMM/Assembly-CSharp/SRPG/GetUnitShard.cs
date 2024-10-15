// Decompiled with JetBrains decompiler
// Type: SRPG.GetUnitShard
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
  [Token(Token = "0x2002503")]
  [AddComponentMenu("UI/GetUnitShard")]
  public class GetUnitShard : MonoBehaviour
  {
    [Token(Token = "0x400A939")]
    [FieldOffset(Offset = "0xC")]
    private StateMachine<GetUnitShard> mState;
    [Token(Token = "0x400A93A")]
    [FieldOffset(Offset = "0x10")]
    public float WaitGaugeActionStarted;
    [Token(Token = "0x400A93B")]
    [FieldOffset(Offset = "0x14")]
    public float WaitGaugeActioned;
    [Token(Token = "0x400A93C")]
    [FieldOffset(Offset = "0x18")]
    public float WaitRebirthStarActioned;
    [Token(Token = "0x400A93D")]
    [FieldOffset(Offset = "0x1C")]
    public float WaitRebirthTextActioned;
    [Token(Token = "0x400A93E")]
    [FieldOffset(Offset = "0x20")]
    public float GaugeUpAnimSpan;
    [Token(Token = "0x400A93F")]
    [FieldOffset(Offset = "0x24")]
    public int GaugeUpAnimSoundSpan;
    [Token(Token = "0x400A940")]
    [FieldOffset(Offset = "0x28")]
    public string[] GaugeUpAnimSoundList;
    [Token(Token = "0x400A941")]
    [FieldOffset(Offset = "0x2C")]
    private string[] DefaultGaugeUpAnimSoundList;
    [Token(Token = "0x400A942")]
    [FieldOffset(Offset = "0x30")]
    public GameObject gauge_bar;
    [Token(Token = "0x400A943")]
    [FieldOffset(Offset = "0x34")]
    public GameObject rebirthstar_root;
    [Token(Token = "0x400A944")]
    [FieldOffset(Offset = "0x38")]
    public GameObject rebirthstar_template;
    [Token(Token = "0x400A945")]
    [FieldOffset(Offset = "0x3C")]
    public RawImage unit_img;
    [Token(Token = "0x400A946")]
    [FieldOffset(Offset = "0x40")]
    public RawImage unit_img_blur01;
    [Token(Token = "0x400A947")]
    [FieldOffset(Offset = "0x44")]
    public RawImage unit_img_blur02;
    [Token(Token = "0x400A948")]
    [FieldOffset(Offset = "0x48")]
    public RawPolyImage unit_icon;
    [Token(Token = "0x400A949")]
    [FieldOffset(Offset = "0x4C")]
    public Image_Transparent element_icon;
    [Token(Token = "0x400A94A")]
    [FieldOffset(Offset = "0x50")]
    public Text ShardName;
    [Token(Token = "0x400A94B")]
    [FieldOffset(Offset = "0x54")]
    public Text JobName;
    [Token(Token = "0x400A94C")]
    [FieldOffset(Offset = "0x58")]
    public Text JobComment;
    [Token(Token = "0x400A94D")]
    [FieldOffset(Offset = "0x5C")]
    public Text ShardNext;
    [Token(Token = "0x400A94E")]
    [FieldOffset(Offset = "0x60")]
    public Text ShardCurrent;
    [Token(Token = "0x400A94F")]
    [FieldOffset(Offset = "0x64")]
    public SliderAnimator ShardGauge;
    [Token(Token = "0x400A950")]
    [FieldOffset(Offset = "0x68")]
    public GameObject Rebirthtext_root;
    [Token(Token = "0x400A951")]
    [FieldOffset(Offset = "0x6C")]
    private string[] mJobNameList;
    [Token(Token = "0x400A952")]
    [FieldOffset(Offset = "0x70")]
    private bool mUnlockUnit;
    [Token(Token = "0x400A953")]
    [FieldOffset(Offset = "0x71")]
    private bool mNotUnlockUnit;
    [Token(Token = "0x400A954")]
    private const string TRIGGER_SHARDGAUGE_CLOSE = "close";
    [Token(Token = "0x400A955")]
    private const string TRIGGER_JOBOPEN_START = "jobopen_start";
    [Token(Token = "0x400A956")]
    private const string TRIGGER_JOBOPEN_NEXT = "job_next";
    [Token(Token = "0x400A957")]
    private const string TRIGGER_JOBOPEN_END = "jobopen_end";
    [Token(Token = "0x400A958")]
    private const string TRIGGER_JOBOPEN_CLOSE = "jobopen_close";
    [Token(Token = "0x400A959")]
    [FieldOffset(Offset = "0x74")]
    private string ShardGaugeStartAnim;
    [Token(Token = "0x400A95A")]
    private const string GachaShardAwakeText = "sys.GACHA_TEXT_SHARD_AWAKE";
    [Token(Token = "0x400A95B")]
    [FieldOffset(Offset = "0x78")]
    private bool isRunningAnimator;
    [Token(Token = "0x400A95C")]
    [FieldOffset(Offset = "0x7C")]
    private int StartAwakeLv;
    [Token(Token = "0x400A95D")]
    [FieldOffset(Offset = "0x80")]
    private int NowAwakeLv;
    [Token(Token = "0x400A95E")]
    [FieldOffset(Offset = "0x84")]
    private int NextAwakeLv;
    [Token(Token = "0x400A95F")]
    [FieldOffset(Offset = "0x88")]
    private int AwakeLvCap;
    [Token(Token = "0x400A960")]
    [FieldOffset(Offset = "0x8C")]
    private int mCurrentAwakeJobIndex;
    [Token(Token = "0x400A961")]
    [FieldOffset(Offset = "0x90")]
    private bool mClicked;
    [Token(Token = "0x400A962")]
    [FieldOffset(Offset = "0x94")]
    private List<GameObject> mRebirthStars;
    [Token(Token = "0x400A963")]
    [FieldOffset(Offset = "0x98")]
    private List<string> mJobID;
    [Token(Token = "0x400A964")]
    [FieldOffset(Offset = "0x9C")]
    private List<int> mJobAwakeLv;
    [Token(Token = "0x400A965")]
    private const float ShardAnimSpan = 1f;
    [Token(Token = "0x400A966")]
    [FieldOffset(Offset = "0xA0")]
    private float mShardStart;
    [Token(Token = "0x400A967")]
    [FieldOffset(Offset = "0xA4")]
    private float mShardEnd;
    [Token(Token = "0x400A968")]
    [FieldOffset(Offset = "0xA8")]
    private float mShardAnimTime;
    [Token(Token = "0x400A969")]
    [FieldOffset(Offset = "0xAC")]
    private float mShardGet;
    [Token(Token = "0x400A96A")]
    [FieldOffset(Offset = "0xB0")]
    private bool mJobEffectFlag;
    [Token(Token = "0x400A96B")]
    [FieldOffset(Offset = "0xB4")]
    private string mCurrentUnitIname;
    [Token(Token = "0x400A96C")]
    [FieldOffset(Offset = "0xB8")]
    private int mget_shard;
    [Token(Token = "0x400A96D")]
    [FieldOffset(Offset = "0xBC")]
    private int msub_shard;
    [Token(Token = "0x400A96E")]
    [FieldOffset(Offset = "0xC0")]
    private int muse_shard;
    [Token(Token = "0x400A96F")]
    [FieldOffset(Offset = "0xC4")]
    private int mremain_shard;
    [Token(Token = "0x400A970")]
    [FieldOffset(Offset = "0xC8")]
    private int mnext_shard;
    [Token(Token = "0x400A971")]
    [FieldOffset(Offset = "0xCC")]
    private int mstart_gauge;

    [Token(Token = "0x170016BB")]
    public bool UnlockUnit
    {
      [Token(Token = "0x600A2A1"), Address(RVA = "0x5FE310", Offset = "0x5FD110", VA = "0x105FE310")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A2A2")]
    [Address(RVA = "0x64DC40", Offset = "0x64CA40", VA = "0x1064DC40")]
    private void Start()
    {
    }

    [Token(Token = "0x600A2A3")]
    [Address(RVA = "0x64DE60", Offset = "0x64CC60", VA = "0x1064DE60")]
    private void Update()
    {
    }

    [Token(Token = "0x170016BC")]
    public bool IsRunningAnimator
    {
      [Token(Token = "0x600A2A4"), Address(RVA = "0x2B5E80", Offset = "0x2B4C80", VA = "0x102B5E80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A2A5")]
    [Address(RVA = "0x618970", Offset = "0x617770", VA = "0x10618970")]
    public void Reset()
    {
    }

    [Token(Token = "0x600A2A6")]
    [Address(RVA = "0x64DAE0", Offset = "0x64C8E0", VA = "0x1064DAE0")]
    public void Restart()
    {
    }

    [Token(Token = "0x600A2A7")]
    [Address(RVA = "0x617320", Offset = "0x616120", VA = "0x10617320")]
    public void OnClicked()
    {
    }

    [Token(Token = "0x600A2A8")]
    [Address(RVA = "0x64C2D0", Offset = "0x64B0D0", VA = "0x1064C2D0")]
    private int GetPastShard(int index = 0, string iname = "") => new int();

    [Token(Token = "0x600A2A9")]
    [Address(RVA = "0x64C090", Offset = "0x64AE90", VA = "0x1064C090")]
    private int GetAmountShardEx(int index = 0, string iname = "") => new int();

    [Token(Token = "0x600A2AA")]
    [Address(RVA = "0x64CC10", Offset = "0x64BA10", VA = "0x1064CC10")]
    private void RefreshShardValue()
    {
    }

    [Token(Token = "0x600A2AB")]
    [Address(RVA = "0x64C910", Offset = "0x64B710", VA = "0x1064C910")]
    private void RefreshJobWindow()
    {
    }

    [Token(Token = "0x600A2AC")]
    [Address(RVA = "0x64C3B0", Offset = "0x64B1B0", VA = "0x1064C3B0")]
    private void InitRebirthStar()
    {
    }

    [Token(Token = "0x600A2AD")]
    [Address(RVA = "0x64C5B0", Offset = "0x64B3B0", VA = "0x1064C5B0")]
    public bool IsReachingAwakelv() => new bool();

    [Token(Token = "0x600A2AE")]
    [Address(RVA = "0x64CD70", Offset = "0x64BB70", VA = "0x1064CD70")]
    public void Refresh(
      UnitParam param,
      string shard_name = "",
      int awake_lv = 0,
      int get_shard = 0,
      int current_index = 0)
    {
    }

    [Token(Token = "0x600A2AF")]
    [Address(RVA = "0x64C5D0", Offset = "0x64B3D0", VA = "0x1064C5D0")]
    private void RefreshAddStar()
    {
    }

    [Token(Token = "0x600A2B0")]
    [Address(RVA = "0x617330", Offset = "0x616130", VA = "0x10617330")]
    private void RefreshAddGauge()
    {
    }

    [Token(Token = "0x600A2B1")]
    [Address(RVA = "0x618AF0", Offset = "0x6178F0", VA = "0x10618AF0")]
    private void SetUsedShard(int end_gauge)
    {
    }

    [Token(Token = "0x600A2B2")]
    [Address(RVA = "0x64BDD0", Offset = "0x64ABD0", VA = "0x1064BDD0")]
    private void AnimationShard()
    {
    }

    [Token(Token = "0x600A2B3")]
    [Address(RVA = "0x64CAA0", Offset = "0x64B8A0", VA = "0x1064CAA0")]
    private void RefreshShardGaugeImmediate()
    {
    }

    [Token(Token = "0x600A2B4")]
    [Address(RVA = "0x64DBB0", Offset = "0x64C9B0", VA = "0x1064DBB0")]
    private void SetJobEffectIndex()
    {
    }

    [Token(Token = "0x600A2B5")]
    [Address(RVA = "0x64C540", Offset = "0x64B340", VA = "0x1064C540")]
    private bool IsOpenJobAnimation() => new bool();

    [Token(Token = "0x600A2B6")]
    [Address(RVA = "0x64DEA0", Offset = "0x64CCA0", VA = "0x1064DEA0")]
    public GetUnitShard()
    {
    }

    [Token(Token = "0x2002504")]
    private class State_Init : State<GetUnitShard>
    {
      [Token(Token = "0x600A2B7")]
      [Address(RVA = "0x656F20", Offset = "0x655D20", VA = "0x10656F20", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2B8")]
      [Address(RVA = "0x656F70", Offset = "0x655D70", VA = "0x10656F70")]
      public State_Init()
      {
      }
    }

    [Token(Token = "0x2002505")]
    private class State_WaitStartAnimation : State<GetUnitShard>
    {
      [Token(Token = "0x600A2B9")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2BA")]
      [Address(RVA = "0x657800", Offset = "0x656600", VA = "0x10657800", Slot = "5")]
      public override void Update(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2BB")]
      [Address(RVA = "0x6578D0", Offset = "0x6566D0", VA = "0x106578D0")]
      public State_WaitStartAnimation()
      {
      }
    }

    [Token(Token = "0x2002506")]
    private class State_AddingGaugeSkip : State<GetUnitShard>
    {
      [Token(Token = "0x600A2BC")]
      [Address(RVA = "0x655F40", Offset = "0x654D40", VA = "0x10655F40", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2BD")]
      [Address(RVA = "0x656040", Offset = "0x654E40", VA = "0x10656040")]
      private IEnumerator WaitGaugeObject() => (IEnumerator) null;

      [Token(Token = "0x600A2BE")]
      [Address(RVA = "0x6560B0", Offset = "0x654EB0", VA = "0x106560B0")]
      public State_AddingGaugeSkip()
      {
      }
    }

    [Token(Token = "0x2002508")]
    private class State_WaitGaugeActionStarted : State<GetUnitShard>
    {
      [Token(Token = "0x400A975")]
      [FieldOffset(Offset = "0xC")]
      private float mWaitTime;
      [Token(Token = "0x400A976")]
      [FieldOffset(Offset = "0x10")]
      private float mTimer;

      [Token(Token = "0x600A2C5")]
      [Address(RVA = "0x62BCB0", Offset = "0x62AAB0", VA = "0x1062BCB0", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2C6")]
      [Address(RVA = "0x657530", Offset = "0x656330", VA = "0x10657530", Slot = "5")]
      public override void Update(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2C7")]
      [Address(RVA = "0x6575D0", Offset = "0x6563D0", VA = "0x106575D0")]
      public State_WaitGaugeActionStarted()
      {
      }
    }

    [Token(Token = "0x2002509")]
    private class State_AddingGauge : State<GetUnitShard>
    {
      [Token(Token = "0x600A2C8")]
      [Address(RVA = "0x6560F0", Offset = "0x654EF0", VA = "0x106560F0", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2C9")]
      [Address(RVA = "0x656140", Offset = "0x654F40", VA = "0x10656140", Slot = "5")]
      public override void Update(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2CA")]
      [Address(RVA = "0x6561D0", Offset = "0x654FD0", VA = "0x106561D0")]
      public State_AddingGauge()
      {
      }
    }

    [Token(Token = "0x200250A")]
    private class State_GaugeSkip : State<GetUnitShard>
    {
      [Token(Token = "0x600A2CB")]
      [Address(RVA = "0x656D30", Offset = "0x655B30", VA = "0x10656D30", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2CC")]
      [Address(RVA = "0x656EE0", Offset = "0x655CE0", VA = "0x10656EE0")]
      public State_GaugeSkip()
      {
      }
    }

    [Token(Token = "0x200250B")]
    private class State_WaitGaugeActioned : State<GetUnitShard>
    {
      [Token(Token = "0x400A977")]
      [FieldOffset(Offset = "0xC")]
      private float mWaitTime;
      [Token(Token = "0x400A978")]
      [FieldOffset(Offset = "0x10")]
      private float mTimer;

      [Token(Token = "0x600A2CD")]
      [Address(RVA = "0x62BDC0", Offset = "0x62ABC0", VA = "0x1062BDC0", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2CE")]
      [Address(RVA = "0x657610", Offset = "0x656410", VA = "0x10657610", Slot = "5")]
      public override void Update(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2CF")]
      [Address(RVA = "0x6576E0", Offset = "0x6564E0", VA = "0x106576E0")]
      public State_WaitGaugeActioned()
      {
      }
    }

    [Token(Token = "0x200250C")]
    private class State_AddingRebirthStar : State<GetUnitShard>
    {
      [Token(Token = "0x400A979")]
      [FieldOffset(Offset = "0xC")]
      private Transform rebirth_star;
      [Token(Token = "0x400A97A")]
      [FieldOffset(Offset = "0x10")]
      private int new_star;

      [Token(Token = "0x600A2D0")]
      [Address(RVA = "0x656210", Offset = "0x655010", VA = "0x10656210", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2D1")]
      [Address(RVA = "0x6563B0", Offset = "0x6551B0", VA = "0x106563B0", Slot = "5")]
      public override void Update(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2D2")]
      [Address(RVA = "0x6565A0", Offset = "0x6553A0", VA = "0x106565A0")]
      public State_AddingRebirthStar()
      {
      }
    }

    [Token(Token = "0x200250D")]
    private class State_WaitAddingRebirthStarActioned : State<GetUnitShard>
    {
      [Token(Token = "0x400A97B")]
      [FieldOffset(Offset = "0xC")]
      private float mWaitTime;
      [Token(Token = "0x400A97C")]
      [FieldOffset(Offset = "0x10")]
      private float mTimer;

      [Token(Token = "0x600A2D3")]
      [Address(RVA = "0x62BAD0", Offset = "0x62A8D0", VA = "0x1062BAD0", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2D4")]
      [Address(RVA = "0x6573B0", Offset = "0x6561B0", VA = "0x106573B0", Slot = "5")]
      public override void Update(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2D5")]
      [Address(RVA = "0x657430", Offset = "0x656230", VA = "0x10657430")]
      public State_WaitAddingRebirthStarActioned()
      {
      }
    }

    [Token(Token = "0x200250E")]
    private class State_ShowRebirthText : State<GetUnitShard>
    {
      [Token(Token = "0x400A97D")]
      [FieldOffset(Offset = "0xC")]
      private GameObject anim;

      [Token(Token = "0x600A2D6")]
      [Address(RVA = "0x656FB0", Offset = "0x655DB0", VA = "0x10656FB0", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2D7")]
      [Address(RVA = "0x657080", Offset = "0x655E80", VA = "0x10657080", Slot = "5")]
      public override void Update(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2D8")]
      [Address(RVA = "0x657160", Offset = "0x655F60", VA = "0x10657160")]
      public State_ShowRebirthText()
      {
      }
    }

    [Token(Token = "0x200250F")]
    private class State_WaitRebirthTextActioned : State<GetUnitShard>
    {
      [Token(Token = "0x400A97E")]
      [FieldOffset(Offset = "0xC")]
      private float mWaitTime;
      [Token(Token = "0x400A97F")]
      [FieldOffset(Offset = "0x10")]
      private float mTimer;

      [Token(Token = "0x600A2D9")]
      [Address(RVA = "0x62BFE0", Offset = "0x62ADE0", VA = "0x1062BFE0", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2DA")]
      [Address(RVA = "0x657720", Offset = "0x656520", VA = "0x10657720", Slot = "5")]
      public override void Update(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2DB")]
      [Address(RVA = "0x6577C0", Offset = "0x6565C0", VA = "0x106577C0")]
      public State_WaitRebirthTextActioned()
      {
      }
    }

    [Token(Token = "0x2002510")]
    private class State_CheckRemainPiece : State<GetUnitShard>
    {
      [Token(Token = "0x600A2DC")]
      [Address(RVA = "0x656740", Offset = "0x655540", VA = "0x10656740", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2DD")]
      [Address(RVA = "0x656980", Offset = "0x655780", VA = "0x10656980")]
      public State_CheckRemainPiece()
      {
      }
    }

    [Token(Token = "0x2002511")]
    private class State_EndShardGaugeBarAnimation : State<GetUnitShard>
    {
      [Token(Token = "0x600A2DE")]
      [Address(RVA = "0x656A80", Offset = "0x655880", VA = "0x10656A80", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2DF")]
      [Address(RVA = "0x656B10", Offset = "0x655910", VA = "0x10656B10", Slot = "5")]
      public override void Update(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2E0")]
      [Address(RVA = "0x656C10", Offset = "0x655A10", VA = "0x10656C10")]
      public State_EndShardGaugeBarAnimation()
      {
      }
    }

    [Token(Token = "0x2002512")]
    private class State_StartJobOpenAnimation : State<GetUnitShard>
    {
      [Token(Token = "0x600A2E1")]
      [Address(RVA = "0x6571A0", Offset = "0x655FA0", VA = "0x106571A0", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2E2")]
      [Address(RVA = "0x657270", Offset = "0x656070", VA = "0x10657270", Slot = "5")]
      public override void Update(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2E3")]
      [Address(RVA = "0x657370", Offset = "0x656170", VA = "0x10657370")]
      public State_StartJobOpenAnimation()
      {
      }
    }

    [Token(Token = "0x2002513")]
    private class State_CheckJobOpen : State<GetUnitShard>
    {
      [Token(Token = "0x400A980")]
      [FieldOffset(Offset = "0xC")]
      private Animator at;

      [Token(Token = "0x600A2E4")]
      [Address(RVA = "0x6565E0", Offset = "0x6553E0", VA = "0x106565E0", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2E5")]
      [Address(RVA = "0x656630", Offset = "0x655430", VA = "0x10656630", Slot = "5")]
      public override void Update(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2E6")]
      [Address(RVA = "0x656700", Offset = "0x655500", VA = "0x10656700")]
      public State_CheckJobOpen()
      {
      }
    }

    [Token(Token = "0x2002514")]
    private class State_CloseJobOpenAnimation : State<GetUnitShard>
    {
      [Token(Token = "0x600A2E7")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2E8")]
      [Address(RVA = "0x6569C0", Offset = "0x6557C0", VA = "0x106569C0", Slot = "5")]
      public override void Update(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2E9")]
      [Address(RVA = "0x656A40", Offset = "0x655840", VA = "0x10656A40")]
      public State_CloseJobOpenAnimation()
      {
      }
    }

    [Token(Token = "0x2002515")]
    private class State_WaitEndUnitShard : State<GetUnitShard>
    {
      [Token(Token = "0x400A981")]
      [FieldOffset(Offset = "0xC")]
      private float mWaitTime;
      [Token(Token = "0x400A982")]
      [FieldOffset(Offset = "0x10")]
      private float mTimer;

      [Token(Token = "0x600A2EA")]
      [Address(RVA = "0x62BBC0", Offset = "0x62A9C0", VA = "0x1062BBC0", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2EB")]
      [Address(RVA = "0x657470", Offset = "0x656270", VA = "0x10657470", Slot = "5")]
      public override void Update(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2EC")]
      [Address(RVA = "0x6574F0", Offset = "0x6562F0", VA = "0x106574F0")]
      public State_WaitEndUnitShard()
      {
      }
    }

    [Token(Token = "0x2002516")]
    private class State_EndUnitShard : State<GetUnitShard>
    {
      [Token(Token = "0x600A2ED")]
      [Address(RVA = "0x656C50", Offset = "0x655A50", VA = "0x10656C50", Slot = "4")]
      public override void Begin(GetUnitShard self)
      {
      }

      [Token(Token = "0x600A2EE")]
      [Address(RVA = "0x656CF0", Offset = "0x655AF0", VA = "0x10656CF0")]
      public State_EndUnitShard()
      {
      }
    }
  }
}
