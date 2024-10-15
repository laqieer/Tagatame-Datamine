// Decompiled with JetBrains decompiler
// Type: SRPG.SortMenuButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AF1")]
  [FlowNode.Pin(101, "Open", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(111, "Close", FlowNode.PinTypes.Output, 111)]
  public class SortMenuButton : SRPG_Button, IFlowInterface
  {
    [Token(Token = "0x400D187")]
    private const int PIN_OUT_OPEN = 101;
    [Token(Token = "0x400D188")]
    private const int PIN_OUT_CLOSED = 111;
    [Token(Token = "0x400D189")]
    [FieldOffset(Offset = "0xC0")]
    public GameObject Target;
    [Token(Token = "0x400D18A")]
    [FieldOffset(Offset = "0xC4")]
    public SortMenu Menu;
    [Token(Token = "0x400D18B")]
    [FieldOffset(Offset = "0xC8")]
    public Text Caption;
    [Token(Token = "0x400D18C")]
    [FieldOffset(Offset = "0xCC")]
    private SortMenu mMenu;
    [Token(Token = "0x400D18D")]
    [FieldOffset(Offset = "0xD0")]
    private GameObject mMenuObject;
    [Token(Token = "0x400D18E")]
    [FieldOffset(Offset = "0xD4")]
    public string MenuID;
    [Token(Token = "0x400D18F")]
    [FieldOffset(Offset = "0xD8")]
    public string FilterActive;
    [Token(Token = "0x400D190")]
    [FieldOffset(Offset = "0xDC")]
    public bool CreateMenuInstance;

    [Token(Token = "0x600C447")]
    [Address(RVA = "0x8CDDF0", Offset = "0x8CCBF0", VA = "0x108CDDF0")]
    public void OpenSortMenu()
    {
    }

    [Token(Token = "0x600C448")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "44")]
    public void Activated(int PinID)
    {
    }

    [Token(Token = "0x600C449")]
    [Address(RVA = "0x8CDA60", Offset = "0x8CC860", VA = "0x108CDA60")]
    private void OnSortChange(SortMenu menu)
    {
    }

    [Token(Token = "0x600C44A")]
    [Address(RVA = "0x8CD4B0", Offset = "0x8CC2B0", VA = "0x108CD4B0", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600C44B")]
    [Address(RVA = "0x8CDE40", Offset = "0x8CCC40", VA = "0x108CDE40", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600C44C")]
    [Address(RVA = "0x8CE3A0", Offset = "0x8CD1A0", VA = "0x108CE3A0", Slot = "45")]
    protected virtual void UpdateFilterState(bool active)
    {
    }

    [Token(Token = "0x600C44D")]
    [Address(RVA = "0x8CD9C0", Offset = "0x8CC7C0", VA = "0x108CD9C0", Slot = "5")]
    protected override void OnEnable()
    {
    }

    [Token(Token = "0x600C44E")]
    [Address(RVA = "0x8CE440", Offset = "0x8CD240", VA = "0x108CE440")]
    private void UpdateTarget(string method, bool ascending)
    {
    }

    [Token(Token = "0x600C44F")]
    [Address(RVA = "0x8CD910", Offset = "0x8CC710", VA = "0x108CD910", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600C450")]
    [Address(RVA = "0x8CD640", Offset = "0x8CC440", VA = "0x108CD640")]
    public void ForceReloadFilter()
    {
    }

    [Token(Token = "0x600C451")]
    [Address(RVA = "0x8CE380", Offset = "0x8CD180", VA = "0x108CE380")]
    public SortMenuButton()
    {
    }
  }
}
