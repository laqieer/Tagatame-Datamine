// Decompiled with JetBrains decompiler
// Type: SRPG.AwardList
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
  [Token(Token = "0x2002076")]
  [FlowNode.Pin(0, "StartUp", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(101, "SelectEnd", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "Select", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/AwardList")]
  [FlowNode.Pin(50, "TabNormal", FlowNode.PinTypes.Input, 50)]
  [FlowNode.Pin(10, "StartUpEnd", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "IsSelectAward", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(51, "TabExtra", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(102, "ResetAward", FlowNode.PinTypes.Output, 102)]
  public class AwardList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008BD7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject AwardListRoot;
    [Token(Token = "0x4008BD8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text Pager;
    [Token(Token = "0x4008BD9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SRPG_Button Prev;
    [Token(Token = "0x4008BDA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button Next;
    [Token(Token = "0x4008BDB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject Blank;
    [Token(Token = "0x4008BDC")]
    [FieldOffset(Offset = "0x20")]
    private List<GameObject> mAwardItems;
    [Token(Token = "0x4008BDD")]
    [FieldOffset(Offset = "0x24")]
    private GameManager gm;
    [Token(Token = "0x4008BDE")]
    [FieldOffset(Offset = "0x28")]
    private AwardParam[] mAwards;
    [Token(Token = "0x4008BDF")]
    [FieldOffset(Offset = "0x2C")]
    private List<string> mOpenAwards;
    [Token(Token = "0x4008BE0")]
    [FieldOffset(Offset = "0x30")]
    private int mMaxViewItems;
    [Token(Token = "0x4008BE1")]
    [FieldOffset(Offset = "0x34")]
    private int mCurrentPage;
    [Token(Token = "0x4008BE2")]
    [FieldOffset(Offset = "0x38")]
    private int mMaxPage;
    [Token(Token = "0x4008BE3")]
    [FieldOffset(Offset = "0x3C")]
    private bool IsRefresh;
    [Token(Token = "0x4008BE4")]
    [FieldOffset(Offset = "0x40")]
    private AwardParam.Tab mCurrentTab;
    [Token(Token = "0x4008BE5")]
    [FieldOffset(Offset = "0x44")]
    private AwardParam.Tab mPrevTab;
    [Token(Token = "0x4008BE6")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<AwardParam.Tab, List<AwardParam>> mAwardDatas;

    [Token(Token = "0x600870E")]
    [Address(RVA = "0x485860", Offset = "0x484660", VA = "0x10485860", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600870F")]
    [Address(RVA = "0x486EA0", Offset = "0x485CA0", VA = "0x10486EA0")]
    private void TabChange(AwardParam.Tab tab)
    {
    }

    [Token(Token = "0x6008710")]
    [Address(RVA = "0x485990", Offset = "0x484790", VA = "0x10485990")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008711")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008712")]
    [Address(RVA = "0x486FB0", Offset = "0x485DB0", VA = "0x10486FB0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008713")]
    [Address(RVA = "0x4863D0", Offset = "0x4851D0", VA = "0x104863D0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008714")]
    [Address(RVA = "0x485D30", Offset = "0x484B30", VA = "0x10485D30")]
    private void OnNextPage()
    {
    }

    [Token(Token = "0x6008715")]
    [Address(RVA = "0x485D60", Offset = "0x484B60", VA = "0x10485D60")]
    private void OnPrevPage()
    {
    }

    [Token(Token = "0x6008716")]
    [Address(RVA = "0x485E30", Offset = "0x484C30", VA = "0x10485E30")]
    private void RefreshAwardDatas()
    {
    }

    [Token(Token = "0x6008717")]
    [Address(RVA = "0x485C70", Offset = "0x484A70", VA = "0x10485C70")]
    private AwardParam CreateRemoveAwardData() => (AwardParam) null;

    [Token(Token = "0x6008718")]
    [Address(RVA = "0x485D80", Offset = "0x484B80", VA = "0x10485D80")]
    private void OnSelected(string select = "")
    {
    }

    [Token(Token = "0x6008719")]
    [Address(RVA = "0x486DB0", Offset = "0x485BB0", VA = "0x10486DB0")]
    public void SetOpenAwards(string[] awards)
    {
    }

    [Token(Token = "0x600871A")]
    [Address(RVA = "0x486FE0", Offset = "0x485DE0", VA = "0x10486FE0")]
    public AwardList()
    {
    }
  }
}
