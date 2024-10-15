// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactSortWindow
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
  [Token(Token = "0x2001FEB")]
  [FlowNode.Pin(102, "変更なし", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(2, "ソートセーブ", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "変更あり", FlowNode.PinTypes.Output, 101)]
  public class ArtifactSortWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008792")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008793")]
    private const int PIN_INPUT_CLOSE = 2;
    [Token(Token = "0x4008794")]
    private const int PIN_OUTPUT_CHANGE_SORT = 101;
    [Token(Token = "0x4008795")]
    private const int PIN_OUTPUT_NOT_CHANGE = 102;
    [Token(Token = "0x4008796")]
    private const string NONE_TITLE_INAME = "NoTitle";
    [Token(Token = "0x4008797")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform TabParent;
    [Token(Token = "0x4008798")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ArtifactSortTab TabTempleate;
    [Token(Token = "0x4008799")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform CategoryParent;
    [Token(Token = "0x400879A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ArtifactSortCategory CategoryTempleate;
    [Token(Token = "0x400879B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Toggle ToggleAscending;
    [Token(Token = "0x400879C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle mToggleDescending;
    [Token(Token = "0x400879D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Toggle mToggleArtifatStone;
    [Token(Token = "0x400879F")]
    [FieldOffset(Offset = "0x2C")]
    private List<SortArtifactParam> mSortArtifactParams;
    [Token(Token = "0x40087A0")]
    [FieldOffset(Offset = "0x30")]
    private SortUtility.SortPrefs mCurrentSortPrefs;
    [Token(Token = "0x40087A1")]
    [FieldOffset(Offset = "0x34")]
    private Dictionary<string, List<SortArtifactParam>> mTabDic;
    [Token(Token = "0x40087A2")]
    [FieldOffset(Offset = "0x38")]
    private List<ArtifactSortToggle> mToggleList;
    [Token(Token = "0x40087A3")]
    [FieldOffset(Offset = "0x3C")]
    private List<ArtifactSortCategory> mItemList;
    [Token(Token = "0x40087A4")]
    [FieldOffset(Offset = "0x40")]
    private string mSelectTabName;
    [Token(Token = "0x40087A5")]
    [FieldOffset(Offset = "0x44")]
    private string mSelectSortIname;
    [Token(Token = "0x40087A6")]
    [FieldOffset(Offset = "0x48")]
    private bool mIsArtifatStone;
    [Token(Token = "0x40087A7")]
    [FieldOffset(Offset = "0x0")]
    public static string SortPlaceKey;

    [Token(Token = "0x170012DD")]
    public string SelectCondIname
    {
      [Token(Token = "0x60083AB"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60083AC"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] private set
      {
      }
    }

    [Token(Token = "0x60083AD")]
    [Address(RVA = "0x4437D0", Offset = "0x4425D0", VA = "0x104437D0")]
    private void Start()
    {
    }

    [Token(Token = "0x60083AE")]
    [Address(RVA = "0x441ED0", Offset = "0x440CD0", VA = "0x10441ED0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60083AF")]
    [Address(RVA = "0x4426B0", Offset = "0x4414B0", VA = "0x104426B0")]
    private void Init()
    {
    }

    [Token(Token = "0x60083B0")]
    [Address(RVA = "0x442090", Offset = "0x440E90", VA = "0x10442090")]
    private void DisplayList()
    {
    }

    [Token(Token = "0x60083B1")]
    [Address(RVA = "0x441F20", Offset = "0x440D20", VA = "0x10441F20")]
    private void ChangeTabActive()
    {
    }

    [Token(Token = "0x60083B2")]
    [Address(RVA = "0x443790", Offset = "0x442590", VA = "0x10443790")]
    public void SetToggleButton(ArtifactSortToggle _toggle)
    {
    }

    [Token(Token = "0x60083B3")]
    [Address(RVA = "0x443560", Offset = "0x442360", VA = "0x10443560")]
    public void SelectSortToggle(ArtifactSortToggle _toggle, bool _is_on)
    {
    }

    [Token(Token = "0x60083B4")]
    [Address(RVA = "0x443740", Offset = "0x442540", VA = "0x10443740")]
    public void SelectTabToggle(ArtifactSortTab _tab, bool _is_on)
    {
    }

    [Token(Token = "0x60083B5")]
    [Address(RVA = "0x443040", Offset = "0x441E40", VA = "0x10443040")]
    private bool IsSavePrefs() => new bool();

    [Token(Token = "0x60083B6")]
    [Address(RVA = "0x443880", Offset = "0x442680", VA = "0x10443880")]
    public ArtifactSortWindow()
    {
    }

    [Token(Token = "0x60083B7")]
    [Address(RVA = "0x443830", Offset = "0x442630", VA = "0x10443830")]
    static ArtifactSortWindow()
    {
    }
  }
}
