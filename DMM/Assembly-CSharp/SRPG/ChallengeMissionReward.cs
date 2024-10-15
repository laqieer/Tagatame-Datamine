// Decompiled with JetBrains decompiler
// Type: SRPG.ChallengeMissionReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002131")]
  [AddComponentMenu("UI/ChallengeMissionReward")]
  [FlowNode.Pin(1, "完了", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(4, "継続", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(3, "コンプリート報酬", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(5, "全ミッションコンプリート", FlowNode.PinTypes.Output, 5)]
  [FlowNode.Pin(2, "ミッション報酬", FlowNode.PinTypes.Output, 1)]
  public class ChallengeMissionReward : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400907B")]
    [FieldOffset(Offset = "0xC")]
    public GameObject PanelNormal;
    [Token(Token = "0x400907C")]
    [FieldOffset(Offset = "0x10")]
    public GameObject PanelComplete;
    [Token(Token = "0x400907D")]
    [FieldOffset(Offset = "0x14")]
    public Transform RewardHolder;
    [Token(Token = "0x400907E")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400907F")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject ExpTemplate;
    [Token(Token = "0x4009080")]
    [FieldOffset(Offset = "0x20")]
    public GameObject GoldTemplate;
    [Token(Token = "0x4009081")]
    [FieldOffset(Offset = "0x24")]
    public GameObject StaminaTemplate;
    [Token(Token = "0x4009082")]
    [FieldOffset(Offset = "0x28")]
    public GameObject ConceptCardTemplate;
    [Token(Token = "0x4009083")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject UnitTemplate;
    [Token(Token = "0x4009084")]
    [FieldOffset(Offset = "0x30")]
    public Text TextMessage;
    [Token(Token = "0x4009085")]
    [FieldOffset(Offset = "0x34")]
    private bool isAllMissionCompleteMessageShown;
    [Token(Token = "0x4009086")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GridLayoutGroup GridLayout;
    [Token(Token = "0x4009087")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private int MaxCellSize;
    [Token(Token = "0x4009088")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private int MinCellSize;
    [Token(Token = "0x4009089")]
    [FieldOffset(Offset = "0x44")]
    private TrophyParam mTrophy;

    [Token(Token = "0x6008B49")]
    [Address(RVA = "0x4EE460", Offset = "0x4ED260", VA = "0x104EE460", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008B4A")]
    [Address(RVA = "0x4EE520", Offset = "0x4ED320", VA = "0x104EE520")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008B4B")]
    [Address(RVA = "0x4EEFB0", Offset = "0x4EDDB0", VA = "0x104EEFB0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008B4C")]
    [Address(RVA = "0x4F04A0", Offset = "0x4EF2A0", VA = "0x104F04A0")]
    private IEnumerator showRewardMessage() => (IEnumerator) null;

    [Token(Token = "0x6008B4D")]
    [Address(RVA = "0x4EF2C0", Offset = "0x4EE0C0", VA = "0x104EF2C0")]
    private void UpdateRewardSingle(TrophyParam trophy)
    {
    }

    [Token(Token = "0x6008B4E")]
    [Address(RVA = "0x4EFC50", Offset = "0x4EEA50", VA = "0x104EFC50")]
    private void UpdateRewardSome(TrophyParam trophy)
    {
    }

    [Token(Token = "0x6008B4F")]
    [Address(RVA = "0x4EEE10", Offset = "0x4EDC10", VA = "0x104EEE10")]
    private bool SetRewardCellSize(GridLayoutGroup grid, int count) => new bool();

    [Token(Token = "0x6008B50")]
    [Address(RVA = "0x4EF1F0", Offset = "0x4EDFF0", VA = "0x104EF1F0")]
    private void UpdateRewardAmount(GameObject obj, int num)
    {
    }

    [Token(Token = "0x6008B51")]
    [Address(RVA = "0x4F03E0", Offset = "0x4EF1E0", VA = "0x104F03E0")]
    private void UpdateReward(TrophyParam trophy)
    {
    }

    [Token(Token = "0x6008B52")]
    [Address(RVA = "0x4EE770", Offset = "0x4ED570", VA = "0x104EE770")]
    private string GetAllRewardText(TrophyParam trophy) => (string) null;

    [Token(Token = "0x6008B53")]
    [Address(RVA = "0x4F0470", Offset = "0x4EF270", VA = "0x104F0470")]
    public ChallengeMissionReward()
    {
    }
  }
}
