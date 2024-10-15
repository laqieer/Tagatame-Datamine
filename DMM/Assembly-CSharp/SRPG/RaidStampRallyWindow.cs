// Decompiled with JetBrains decompiler
// Type: SRPG.RaidStampRallyWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028F2")]
  [AddComponentMenu("UI/Raid/RaidStampRallyWindow")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class RaidStampRallyWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C4E5")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400C4E6")]
    private const int PIN_OUTPUT_END_RAID_BEAT_LIST = 101;
    [Token(Token = "0x400C4E7")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string RAID_BOSS_ALIVE_OBJECT_KEY;
    [Token(Token = "0x400C4E8")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string RAID_BOSS_DEAD_OBJECT_KEY;
    [Token(Token = "0x400C4E9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mRaidIconTemplate;
    [Token(Token = "0x400C4EA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RaidRewardIcon mRaidRewardIconTemplate;
    [Token(Token = "0x400C4EB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform mRaidRewardIconParent;
    [Token(Token = "0x400C4EC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button mRewardButton;
    [Token(Token = "0x400C4ED")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mRoundText;
    [Token(Token = "0x400C4EE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject[] mRaidIcons;
    [Token(Token = "0x400C4EF")]
    [FieldOffset(Offset = "0x8")]
    private static RaidStampRallyWindow mInstance;
    [Token(Token = "0x400C4F0")]
    [FieldOffset(Offset = "0x24")]
    private ReqRaidBeatList.Response mRaidBeatListData;
    [Token(Token = "0x400C4F1")]
    [FieldOffset(Offset = "0x28")]
    private bool mIsAllRaidBossBeat;
    [Token(Token = "0x400C4F2")]
    [FieldOffset(Offset = "0x29")]
    private bool mIsExistReward;
    [Token(Token = "0x400C4F3")]
    [FieldOffset(Offset = "0x2C")]
    private List<GameObject> mCreatedRaidBossIconList;
    [Token(Token = "0x400C4F4")]
    [FieldOffset(Offset = "0x30")]
    private List<GameObject> mCreatedRewardIconList;

    [Token(Token = "0x1700195B")]
    public static RaidStampRallyWindow Instance
    {
      [Token(Token = "0x600B952"), Address(RVA = "0x80EB10", Offset = "0x80D910", VA = "0x1080EB10")] get
      {
        return (RaidStampRallyWindow) null;
      }
    }

    [Token(Token = "0x600B953")]
    [Address(RVA = "0x80DE40", Offset = "0x80CC40", VA = "0x1080DE40")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B954")]
    [Address(RVA = "0x80E990", Offset = "0x80D790", VA = "0x1080E990")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B955")]
    [Address(RVA = "0x80DD70", Offset = "0x80CB70", VA = "0x1080DD70", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B956")]
    [Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")]
    public void SetParam(ReqRaidBeatList.Response beat_data)
    {
    }

    [Token(Token = "0x600B957")]
    [Address(RVA = "0x80E8C0", Offset = "0x80D6C0", VA = "0x1080E8C0")]
    private void Init()
    {
    }

    [Token(Token = "0x600B958")]
    [Address(RVA = "0x80E0C0", Offset = "0x80CEC0", VA = "0x1080E0C0")]
    private void Init_RaidBossList()
    {
    }

    [Token(Token = "0x600B959")]
    [Address(RVA = "0x80E4D0", Offset = "0x80D2D0", VA = "0x1080E4D0")]
    private void Init_Reward()
    {
    }

    [Token(Token = "0x600B95A")]
    [Address(RVA = "0x80DF00", Offset = "0x80CD00", VA = "0x1080DF00")]
    public static List<RaidBossParam> GetRaidBossAll(int period_id) => (List<RaidBossParam>) null;

    [Token(Token = "0x600B95B")]
    [Address(RVA = "0x80EA70", Offset = "0x80D870", VA = "0x1080EA70")]
    public RaidStampRallyWindow()
    {
    }

    [Token(Token = "0x600B95C")]
    [Address(RVA = "0x80E9F0", Offset = "0x80D7F0", VA = "0x1080E9F0")]
    static RaidStampRallyWindow()
    {
    }
  }
}
