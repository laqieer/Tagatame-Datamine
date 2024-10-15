// Decompiled with JetBrains decompiler
// Type: SRPG.SortMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AEC")]
  [FlowNode.Pin(2, "Restore State", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Open", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("UI/SortMenu")]
  public class SortMenu : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D172")]
    [FieldOffset(Offset = "0xC")]
    public bool LocalizeCaption;
    [Token(Token = "0x400D173")]
    [FieldOffset(Offset = "0x10")]
    public string DefaultCaption;
    [Token(Token = "0x400D174")]
    [FieldOffset(Offset = "0x14")]
    public Toggle Ascending;
    [Token(Token = "0x400D175")]
    [FieldOffset(Offset = "0x18")]
    public Toggle Descending;
    [Token(Token = "0x400D176")]
    [FieldOffset(Offset = "0x1C")]
    public SortMenu.SortMenuEvent OnAccept;
    [Token(Token = "0x400D177")]
    [FieldOffset(Offset = "0x20")]
    public SortMenu.SortMenuItem[] Items;
    [Token(Token = "0x400D178")]
    [FieldOffset(Offset = "0x24")]
    public SortMenu.SortMenuItem[] Filters;
    [Token(Token = "0x400D179")]
    [FieldOffset(Offset = "0x28")]
    public Button ToggleFiltersOn;
    [Token(Token = "0x400D17A")]
    [FieldOffset(Offset = "0x2C")]
    public Button ToggleFiltersOff;
    [Token(Token = "0x400D17B")]
    [FieldOffset(Offset = "0x30")]
    private bool mSelectedAscending;
    [Token(Token = "0x400D17C")]
    [FieldOffset(Offset = "0x31")]
    public bool UseFilterCaption;

    [Token(Token = "0x600C428")]
    [Address(RVA = "0x8CE6D0", Offset = "0x8CD4D0", VA = "0x108CE6D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C429")]
    [Address(RVA = "0x8CEA00", Offset = "0x8CD800", VA = "0x108CEA00")]
    public void Reset()
    {
    }

    [Token(Token = "0x600C42A")]
    [Address(RVA = "0x8CF270", Offset = "0x8CE070", VA = "0x108CF270")]
    private void Start()
    {
    }

    [Token(Token = "0x600C42B")]
    [Address(RVA = "0x8CEF30", Offset = "0x8CDD30", VA = "0x108CEF30")]
    public void SetAllFiltersOn()
    {
    }

    [Token(Token = "0x600C42C")]
    [Address(RVA = "0x8CEE50", Offset = "0x8CDC50", VA = "0x108CEE50")]
    public void SetAllFiltersOff()
    {
    }

    [Token(Token = "0x600C42D")]
    [Address(RVA = "0x8CE9D0", Offset = "0x8CD7D0", VA = "0x108CE9D0")]
    public void Open()
    {
    }

    [Token(Token = "0x600C42E")]
    [Address(RVA = "0x8CECC0", Offset = "0x8CDAC0", VA = "0x108CECC0")]
    public void SaveState()
    {
    }

    [Token(Token = "0x600C42F")]
    [Address(RVA = "0x8CEAE0", Offset = "0x8CD8E0", VA = "0x108CEAE0", Slot = "5")]
    public virtual void RestoreState()
    {
    }

    [Token(Token = "0x600C430")]
    [Address(RVA = "0x8CE6A0", Offset = "0x8CD4A0", VA = "0x108CE6A0")]
    public void Accept()
    {
    }

    [Token(Token = "0x17001A20")]
    public string CurrentCaption
    {
      [Token(Token = "0x600C431"), Address(RVA = "0x8CF410", Offset = "0x8CE210", VA = "0x108CF410")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001A21")]
    public string SortMethod
    {
      [Token(Token = "0x600C432"), Address(RVA = "0x8CF700", Offset = "0x8CE500", VA = "0x108CF700")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600C433"), Address(RVA = "0x8CF990", Offset = "0x8CE790", VA = "0x108CF990")] set
      {
      }
    }

    [Token(Token = "0x17001A22")]
    public bool IsAscending
    {
      [Token(Token = "0x600C434"), Address(RVA = "0x8CF620", Offset = "0x8CE420", VA = "0x108CF620")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C435"), Address(RVA = "0x8CF7D0", Offset = "0x8CE5D0", VA = "0x108CF7D0")] set
      {
      }
    }

    [Token(Token = "0x17001A23")]
    public bool IsDescending
    {
      [Token(Token = "0x600C436"), Address(RVA = "0x8CF690", Offset = "0x8CE490", VA = "0x108CF690")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C437"), Address(RVA = "0x8CF8B0", Offset = "0x8CE6B0", VA = "0x108CF8B0")] set
      {
      }
    }

    [Token(Token = "0x600C438")]
    [Address(RVA = "0x8CE700", Offset = "0x8CD500", VA = "0x108CE700")]
    public bool Contains(string method) => new bool();

    [Token(Token = "0x600C439")]
    [Address(RVA = "0x8CE770", Offset = "0x8CD570", VA = "0x108CE770")]
    public string[] GetFilters(bool invert = false) => (string[]) null;

    [Token(Token = "0x600C43A")]
    [Address(RVA = "0x8CF010", Offset = "0x8CDE10", VA = "0x108CF010")]
    public void SetFilters(string[] filters, bool invert = false)
    {
    }

    [Token(Token = "0x600C43B")]
    [Address(RVA = "0x8CF3A0", Offset = "0x8CE1A0", VA = "0x108CF3A0")]
    public SortMenu()
    {
    }

    [Token(Token = "0x2002AED")]
    public delegate void SortMenuEvent(SortMenu menu);

    [Token(Token = "0x2002AEE")]
    [Serializable]
    public struct SortMenuItem
    {
      [Token(Token = "0x400D17D")]
      [FieldOffset(Offset = "0x0")]
      public string Method;
      [Token(Token = "0x400D17E")]
      [FieldOffset(Offset = "0x4")]
      public Toggle Toggle;
      [Token(Token = "0x400D17F")]
      [FieldOffset(Offset = "0x8")]
      public string Caption;
      [Token(Token = "0x400D180")]
      [FieldOffset(Offset = "0xC")]
      [NonSerialized]
      public bool LastState;
    }
  }
}
