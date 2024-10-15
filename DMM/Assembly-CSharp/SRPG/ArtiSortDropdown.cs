// Decompiled with JetBrains decompiler
// Type: SRPG.ArtiSortDropdown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200204E")]
  [FlowNode.Pin(121, "Close", FlowNode.PinTypes.Output, 121)]
  [FlowNode.Pin(111, "Open", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(103, "Select Accessory", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(102, "Select Armor", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(100, "Select None", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(13, "Select Accessory", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(12, "Select Armor", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(11, "Select Arms", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "Select None", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(101, "Select Arms", FlowNode.PinTypes.Output, 101)]
  public class ArtiSortDropdown : Pulldown, IFlowInterface
  {
    [Token(Token = "0x4008AE3")]
    private const int PININPUT_NONE = 10;
    [Token(Token = "0x4008AE4")]
    private const int PININPUT_ARMS = 11;
    [Token(Token = "0x4008AE5")]
    private const int PININPUT_ARMOR = 12;
    [Token(Token = "0x4008AE6")]
    private const int PININPUT_ACCESSORY = 13;
    [Token(Token = "0x4008AE7")]
    private const int PINOUTPUT_NONE = 100;
    [Token(Token = "0x4008AE8")]
    private const int PINOUTPUT_ARMS = 101;
    [Token(Token = "0x4008AE9")]
    private const int PINOUTPUT_ARMOR = 102;
    [Token(Token = "0x4008AEA")]
    private const int PINOUTPUT_ACCESSORY = 103;
    [Token(Token = "0x4008AEB")]
    private const int PINOUTPUT_OPEN = 111;
    [Token(Token = "0x4008AEC")]
    private const int PINOUTPUT_CLOSE = 121;
    [Token(Token = "0x4008AED")]
    [FieldOffset(Offset = "0x0")]
    public static ArtiSortDropdown.SortChangeEvent OnSortChange;
    [Token(Token = "0x4008AEE")]
    [FieldOffset(Offset = "0xF4")]
    public bool RefreshOnStart;
    [Token(Token = "0x4008AEF")]
    [FieldOffset(Offset = "0xF8")]
    public GameObject GameParamterRoot;
    [Token(Token = "0x4008AF0")]
    [FieldOffset(Offset = "0xFC")]
    public ArtiSortDropdown.ParentObjectEvent UpdateValue;
    [Token(Token = "0x4008AF1")]
    [FieldOffset(Offset = "0x100")]
    private ArtifactTypes mInitSelection;

    [Token(Token = "0x6008635")]
    [Address(RVA = "0x4792A0", Offset = "0x4780A0", VA = "0x104792A0", Slot = "47")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008636")]
    [Address(RVA = "0x479520", Offset = "0x478320", VA = "0x10479520", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x6008637")]
    [Address(RVA = "0x4794A0", Offset = "0x4782A0", VA = "0x104794A0")]
    private void SortChanged(int value)
    {
    }

    [Token(Token = "0x6008638")]
    [Address(RVA = "0x479330", Offset = "0x478130", VA = "0x10479330", Slot = "44")]
    protected override void OpenPulldown()
    {
    }

    [Token(Token = "0x6008639")]
    [Address(RVA = "0x479310", Offset = "0x478110", VA = "0x10479310", Slot = "45")]
    protected override void ClosePulldown(bool se = true)
    {
    }

    [Token(Token = "0x600863A")]
    [Address(RVA = "0x479350", Offset = "0x478150", VA = "0x10479350")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600863B")]
    [Address(RVA = "0x479890", Offset = "0x478690", VA = "0x10479890")]
    public ArtiSortDropdown()
    {
    }

    [Token(Token = "0x600863C")]
    [Address(RVA = "0x479750", Offset = "0x478550", VA = "0x10479750")]
    static ArtiSortDropdown()
    {
    }

    [Token(Token = "0x200204F")]
    public delegate void SortChangeEvent(int id);

    [Token(Token = "0x2002050")]
    public delegate void ParentObjectEvent();
  }
}
