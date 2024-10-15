// Decompiled with JetBrains decompiler
// Type: SRPG.UnitPickerFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CD8")]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "Restore State", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("UI/UnitPickerFilter")]
  public class UnitPickerFilter : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DEE1")]
    [FieldOffset(Offset = "0xC")]
    public string MenuID;
    [Token(Token = "0x400DEE2")]
    [FieldOffset(Offset = "0x10")]
    public bool LocalizeCaption;
    [Token(Token = "0x400DEE3")]
    [FieldOffset(Offset = "0x14")]
    public string DefaultCaption;
    [Token(Token = "0x400DEE4")]
    [FieldOffset(Offset = "0x18")]
    public bool UseFilterCaption;
    [Token(Token = "0x400DEE5")]
    [FieldOffset(Offset = "0x1C")]
    public Button ToggleFiltersOn;
    [Token(Token = "0x400DEE6")]
    [FieldOffset(Offset = "0x20")]
    public Button ToggleFiltersOff;
    [Token(Token = "0x400DEE7")]
    [FieldOffset(Offset = "0x24")]
    public SortMenu.SortMenuItem[] Filters;
    [Token(Token = "0x400DEE8")]
    [FieldOffset(Offset = "0x28")]
    public SRPG_Button DecideButton;
    [Token(Token = "0x400DEE9")]
    [FieldOffset(Offset = "0x2C")]
    public UnitPickerFilter.FilterEvent OnAccept;

    [Token(Token = "0x600D09D")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D09E")]
    [Address(RVA = "0x9BAE50", Offset = "0x9B9C50", VA = "0x109BAE50")]
    public void Open()
    {
    }

    [Token(Token = "0x600D09F")]
    [Address(RVA = "0x9BB620", Offset = "0x9BA420", VA = "0x109BB620")]
    private void Start()
    {
    }

    [Token(Token = "0x600D0A0")]
    [Address(RVA = "0x9BA900", Offset = "0x9B9700", VA = "0x109BA900")]
    private void Accecpt()
    {
    }

    [Token(Token = "0x600D0A1")]
    [Address(RVA = "0x9BB060", Offset = "0x9B9E60", VA = "0x109BB060")]
    public void SaveState()
    {
    }

    [Token(Token = "0x600D0A2")]
    [Address(RVA = "0x9BAF60", Offset = "0x9B9D60", VA = "0x109BAF60")]
    public void RestoreState()
    {
    }

    [Token(Token = "0x17001B72")]
    public string CurrentCaption
    {
      [Token(Token = "0x600D0A3"), Address(RVA = "0x9BB840", Offset = "0x9BA640", VA = "0x109BB840")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600D0A4")]
    [Address(RVA = "0x9BB210", Offset = "0x9BA010", VA = "0x109BB210")]
    public void SetAllFiltersOn()
    {
    }

    [Token(Token = "0x600D0A5")]
    [Address(RVA = "0x9BB130", Offset = "0x9B9F30", VA = "0x109BB130")]
    public void SetAllFiltersOff()
    {
    }

    [Token(Token = "0x600D0A6")]
    [Address(RVA = "0x9BABF0", Offset = "0x9B99F0", VA = "0x109BABF0")]
    public string[] GetFilters(bool invert = false) => (string[]) null;

    [Token(Token = "0x600D0A7")]
    [Address(RVA = "0x9BAAA0", Offset = "0x9B98A0", VA = "0x109BAAA0")]
    public string[] GetFiltersAll() => (string[]) null;

    [Token(Token = "0x600D0A8")]
    [Address(RVA = "0x9BB2F0", Offset = "0x9BA0F0", VA = "0x109BB2F0")]
    public void SetFilters(string[] filters, bool invert = false)
    {
    }

    [Token(Token = "0x600D0A9")]
    [Address(RVA = "0x9BB7D0", Offset = "0x9BA5D0", VA = "0x109BB7D0")]
    public UnitPickerFilter()
    {
    }

    [Token(Token = "0x2002CD9")]
    public delegate void FilterEvent(string[] filter);
  }
}
