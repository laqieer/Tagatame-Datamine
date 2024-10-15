// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactLevelUpWindow
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
  [Token(Token = "0x200200C")]
  [FlowNode.Pin(0, "Close", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("UI/ArtifactLevelUpWindow")]
  public class ArtifactLevelUpWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40088BD")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RectTransform ListParent;
    [Token(Token = "0x40088BE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ListItemTemplate;
    [Token(Token = "0x40088BF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text CurrentLevel;
    [Token(Token = "0x40088C0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text FinishedLevel;
    [Token(Token = "0x40088C1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text MaxLevel;
    [Token(Token = "0x40088C2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text NextExp;
    [Token(Token = "0x40088C3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private SliderAnimator LevelGauge;
    [Token(Token = "0x40088C4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text GetAllExp;
    [Token(Token = "0x40088C5")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button DecideBtn;
    [Token(Token = "0x40088C6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button CancelBtn;
    [Token(Token = "0x40088C7")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Button MaxBtn;
    [Token(Token = "0x40088C8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private SliderAnimator AddLevelGauge;
    [Token(Token = "0x40088C9")]
    [FieldOffset(Offset = "0x3C")]
    private MasterParam master;
    [Token(Token = "0x40088CA")]
    [FieldOffset(Offset = "0x40")]
    private PlayerData player;
    [Token(Token = "0x40088CB")]
    [FieldOffset(Offset = "0x44")]
    private ArtifactData mOriginArtifact;
    [Token(Token = "0x40088CC")]
    [FieldOffset(Offset = "0x48")]
    private List<GameObject> mItems;
    [Token(Token = "0x40088CD")]
    [FieldOffset(Offset = "0x4C")]
    private List<ArtifactLevelUpListItem> mArtifactLevelupLists;
    [Token(Token = "0x40088CE")]
    [FieldOffset(Offset = "0x50")]
    private float mExpStart;
    [Token(Token = "0x40088CF")]
    [FieldOffset(Offset = "0x54")]
    private float mExpEnd;
    [Token(Token = "0x40088D0")]
    [FieldOffset(Offset = "0x58")]
    private float mExpAnimTime;
    [Token(Token = "0x40088D1")]
    [FieldOffset(Offset = "0x5C")]
    private Dictionary<string, int> mSelectExpItems;
    [Token(Token = "0x40088D2")]
    [FieldOffset(Offset = "0x60")]
    public ArtifactLevelUpWindow.OnArtifactLevelupEvent OnDecideEvent;
    [Token(Token = "0x40088D3")]
    [FieldOffset(Offset = "0x64")]
    private List<ItemData> mCacheExpItemList;
    [Token(Token = "0x40088D4")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string CONFIRM_PATH;

    [Token(Token = "0x6008474")]
    [Address(RVA = "0x454170", Offset = "0x452F70", VA = "0x10454170")]
    private void Start()
    {
    }

    [Token(Token = "0x6008475")]
    [Address(RVA = "0x4521D0", Offset = "0x450FD0", VA = "0x104521D0")]
    private void Init()
    {
    }

    [Token(Token = "0x6008476")]
    [Address(RVA = "0x452FE0", Offset = "0x451DE0", VA = "0x10452FE0")]
    private void OnDecideConfirm()
    {
    }

    [Token(Token = "0x6008477")]
    [Address(RVA = "0x453200", Offset = "0x452000", VA = "0x10453200")]
    private void OnDecide()
    {
    }

    [Token(Token = "0x6008478")]
    [Address(RVA = "0x452B70", Offset = "0x451970", VA = "0x10452B70")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x6008479")]
    [Address(RVA = "0x453230", Offset = "0x452030", VA = "0x10453230")]
    private void OnMax()
    {
    }

    [Token(Token = "0x600847A")]
    [Address(RVA = "0x452CA0", Offset = "0x451AA0", VA = "0x10452CA0")]
    private int OnCheck(string iname, int num) => new int();

    [Token(Token = "0x600847B")]
    [Address(RVA = "0x453330", Offset = "0x452130", VA = "0x10453330")]
    private void RefreshExpSelectItems(string iname, int value)
    {
    }

    [Token(Token = "0x600847C")]
    [Address(RVA = "0x453410", Offset = "0x452210", VA = "0x10453410")]
    private void RefreshFinishedStatus()
    {
    }

    [Token(Token = "0x600847D")]
    [Address(RVA = "0x451A20", Offset = "0x450820", VA = "0x10451A20")]
    private void CalcCanArtifactLevelUpMax()
    {
    }

    [Token(Token = "0x600847E")]
    [Address(RVA = "0x453CD0", Offset = "0x452AD0", VA = "0x10453CD0")]
    private void RefreshUseMaxItems(string iname, bool is_on)
    {
    }

    [Token(Token = "0x600847F")]
    [Address(RVA = "0x453FE0", Offset = "0x452DE0", VA = "0x10453FE0")]
    private void SaveSelectUseMax()
    {
    }

    [Token(Token = "0x6008480")]
    [Address(RVA = "0x4521B0", Offset = "0x450FB0", VA = "0x104521B0")]
    private void Close()
    {
    }

    [Token(Token = "0x6008481")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008482")]
    [Address(RVA = "0x4543C0", Offset = "0x4531C0", VA = "0x104543C0")]
    public ArtifactLevelUpWindow()
    {
    }

    [Token(Token = "0x6008483")]
    [Address(RVA = "0x454370", Offset = "0x453170", VA = "0x10454370")]
    static ArtifactLevelUpWindow()
    {
    }

    [Token(Token = "0x200200D")]
    public delegate void OnArtifactLevelupEvent(Dictionary<string, int> dict);
  }
}
