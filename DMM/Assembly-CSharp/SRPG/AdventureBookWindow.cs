// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureBookWindow
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
  [Token(Token = "0x2001F77")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "エリアを選択した", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("UI/Adventure/AdventureBookWindow")]
  public class AdventureBookWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40084DE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x40084DF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Space(5f)]
    private GameObject GoParentItem;
    [Token(Token = "0x40084E0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private AdventureBookItemArea TemplateItem;
    [Token(Token = "0x40084E1")]
    [FieldOffset(Offset = "0x18")]
    [Space(5f)]
    [SerializeField]
    private ContentController CcReward;
    [Token(Token = "0x40084E2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [Space(5f)]
    private GameObject GoParentBuff;
    [Token(Token = "0x40084E3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AdventureBookItemBuff TemplateBuff;
    [Token(Token = "0x40084E4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ScrollRect ScrollAreaInfo;
    [Token(Token = "0x40084E5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollRect ScrollBuffInfo;
    [Token(Token = "0x40084E6")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private ScrollRect ScrollItemInfo;
    [Token(Token = "0x40084E7")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x40084E8")]
    private const int PIN_OUT_AREA_SELECTED = 11;
    [Token(Token = "0x40084E9")]
    [FieldOffset(Offset = "0x30")]
    private int mCurrentAreaIndex;
    [Token(Token = "0x40084EA")]
    [FieldOffset(Offset = "0x34")]
    private List<AdventureBookItemArea> mBookAreaList;
    [Token(Token = "0x40084EB")]
    [FieldOffset(Offset = "0x38")]
    private List<AdventureBookItemBuff> mBookBuffList;
    [Token(Token = "0x40084EC")]
    [FieldOffset(Offset = "0x3C")]
    private List<AdventureBookItemRewardParam> mBookItemRewardParamList;

    [Token(Token = "0x6008143")]
    [Address(RVA = "0x41BFB0", Offset = "0x41ADB0", VA = "0x1041BFB0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008144")]
    [Address(RVA = "0x41CAB0", Offset = "0x41B8B0", VA = "0x1041CAB0")]
    private void Init()
    {
    }

    [Token(Token = "0x6008145")]
    [Address(RVA = "0x41CDE0", Offset = "0x41BBE0", VA = "0x1041CDE0")]
    private bool Refresh() => new bool();

    [Token(Token = "0x6008146")]
    [Address(RVA = "0x41C020", Offset = "0x41AE20", VA = "0x1041C020")]
    private void CreateArea(List<AdventureBook> ab_list)
    {
    }

    [Token(Token = "0x6008147")]
    [Address(RVA = "0x41CD60", Offset = "0x41BB60", VA = "0x1041CD60")]
    private void OnAreaSelectItem(AdventureBookItemArea item)
    {
    }

    [Token(Token = "0x6008148")]
    [Address(RVA = "0x41C440", Offset = "0x41B240", VA = "0x1041C440")]
    private void CreateBuff(AdventureBook book)
    {
    }

    [Token(Token = "0x6008149")]
    [Address(RVA = "0x41C790", Offset = "0x41B590", VA = "0x1041C790")]
    private void CreateReward(AdventureBook book)
    {
    }

    [Token(Token = "0x600814A")]
    [Address(RVA = "0x41CFD0", Offset = "0x41BDD0", VA = "0x1041CFD0")]
    private void SetCurrentAreaIndex(int index)
    {
    }

    [Token(Token = "0x600814B")]
    [Address(RVA = "0x41CF00", Offset = "0x41BD00", VA = "0x1041CF00")]
    private void SetAreaTabAnchor(int index)
    {
    }

    [Token(Token = "0x600814C")]
    [Address(RVA = "0x41BF90", Offset = "0x41AD90", VA = "0x1041BF90", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600814D")]
    [Address(RVA = "0x41D170", Offset = "0x41BF70", VA = "0x1041D170")]
    public AdventureBookWindow()
    {
    }
  }
}
