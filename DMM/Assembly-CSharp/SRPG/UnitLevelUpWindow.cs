// Decompiled with JetBrains decompiler
// Type: SRPG.UnitLevelUpWindow
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
  [Token(Token = "0x2002C74")]
  [FlowNode.Pin(0, "Close", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("UI/UnitLevelUpWindow")]
  public class UnitLevelUpWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DC0A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RectTransform ListParent;
    [Token(Token = "0x400DC0B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ListItemTemplate;
    [Token(Token = "0x400DC0C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text CurrentLevel;
    [Token(Token = "0x400DC0D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text FinishedLevel;
    [Token(Token = "0x400DC0E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text MaxLevel;
    [Token(Token = "0x400DC0F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text NextExp;
    [Token(Token = "0x400DC10")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private SliderAnimator LevelGauge;
    [Token(Token = "0x400DC11")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text GetAllExp;
    [Token(Token = "0x400DC12")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button DecideBtn;
    [Token(Token = "0x400DC13")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button CancelBtn;
    [Token(Token = "0x400DC14")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Button MaxBtn;
    [Token(Token = "0x400DC15")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private SliderAnimator AddLevelGauge;
    [Token(Token = "0x400DC16")]
    [FieldOffset(Offset = "0x3C")]
    private MasterParam master;
    [Token(Token = "0x400DC17")]
    [FieldOffset(Offset = "0x40")]
    private PlayerData player;
    [Token(Token = "0x400DC18")]
    [FieldOffset(Offset = "0x44")]
    private UnitData mOriginUnit;
    [Token(Token = "0x400DC19")]
    [FieldOffset(Offset = "0x48")]
    private int mLv;
    [Token(Token = "0x400DC1A")]
    [FieldOffset(Offset = "0x4C")]
    private int mExp;
    [Token(Token = "0x400DC1B")]
    [FieldOffset(Offset = "0x50")]
    private List<GameObject> mItems;
    [Token(Token = "0x400DC1C")]
    [FieldOffset(Offset = "0x54")]
    private List<UnitLevelUpListItem> mUnitLevelupLists;
    [Token(Token = "0x400DC1D")]
    [FieldOffset(Offset = "0x58")]
    private float mExpStart;
    [Token(Token = "0x400DC1E")]
    [FieldOffset(Offset = "0x5C")]
    private float mExpEnd;
    [Token(Token = "0x400DC1F")]
    [FieldOffset(Offset = "0x60")]
    private float mExpAnimTime;
    [Token(Token = "0x400DC20")]
    [FieldOffset(Offset = "0x64")]
    private Dictionary<string, int> mSelectExpItems;
    [Token(Token = "0x400DC21")]
    [FieldOffset(Offset = "0x68")]
    public UnitLevelUpWindow.OnUnitLevelupEvent OnDecideEvent;
    [Token(Token = "0x400DC22")]
    [FieldOffset(Offset = "0x6C")]
    private List<ItemData> mCacheExpItemList;
    [Token(Token = "0x400DC23")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string CONFIRM_PATH;

    [Token(Token = "0x600CE01")]
    [Address(RVA = "0x98E160", Offset = "0x98CF60", VA = "0x1098E160")]
    private void Start()
    {
    }

    [Token(Token = "0x600CE02")]
    [Address(RVA = "0x98C220", Offset = "0x98B020", VA = "0x1098C220")]
    private void Init()
    {
    }

    [Token(Token = "0x600CE03")]
    [Address(RVA = "0x98CFC0", Offset = "0x98BDC0", VA = "0x1098CFC0")]
    private void OnDecideConfirm()
    {
    }

    [Token(Token = "0x600CE04")]
    [Address(RVA = "0x98D1E0", Offset = "0x98BFE0", VA = "0x1098D1E0")]
    private void OnDecide()
    {
    }

    [Token(Token = "0x600CE05")]
    [Address(RVA = "0x98CB50", Offset = "0x98B950", VA = "0x1098CB50")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x600CE06")]
    [Address(RVA = "0x98D210", Offset = "0x98C010", VA = "0x1098D210")]
    private void OnMax()
    {
    }

    [Token(Token = "0x600CE07")]
    [Address(RVA = "0x98CC80", Offset = "0x98BA80", VA = "0x1098CC80")]
    private int OnCheck(string iname, int num) => new int();

    [Token(Token = "0x600CE08")]
    [Address(RVA = "0x98D310", Offset = "0x98C110", VA = "0x1098D310")]
    private void RefreshExpSelectItems(string iname, int value)
    {
    }

    [Token(Token = "0x600CE09")]
    [Address(RVA = "0x98D3F0", Offset = "0x98C1F0", VA = "0x1098D3F0")]
    private void RefreshFinishedStatus()
    {
    }

    [Token(Token = "0x600CE0A")]
    [Address(RVA = "0x98BAE0", Offset = "0x98A8E0", VA = "0x1098BAE0")]
    private void CalcCanUnitLevelUpMax()
    {
    }

    [Token(Token = "0x600CE0B")]
    [Address(RVA = "0x98DCC0", Offset = "0x98CAC0", VA = "0x1098DCC0")]
    private void RefreshUseMaxItems(string iname, bool is_on)
    {
    }

    [Token(Token = "0x600CE0C")]
    [Address(RVA = "0x98DFD0", Offset = "0x98CDD0", VA = "0x1098DFD0")]
    private void SaveSelectUseMax()
    {
    }

    [Token(Token = "0x600CE0D")]
    [Address(RVA = "0x4521B0", Offset = "0x450FB0", VA = "0x104521B0")]
    private void Close()
    {
    }

    [Token(Token = "0x600CE0E")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CE0F")]
    [Address(RVA = "0x98E3B0", Offset = "0x98D1B0", VA = "0x1098E3B0")]
    public UnitLevelUpWindow()
    {
    }

    [Token(Token = "0x600CE10")]
    [Address(RVA = "0x98E360", Offset = "0x98D160", VA = "0x1098E360")]
    static UnitLevelUpWindow()
    {
    }

    [Token(Token = "0x2002C75")]
    public delegate void OnUnitLevelupEvent(Dictionary<string, int> dict);
  }
}
