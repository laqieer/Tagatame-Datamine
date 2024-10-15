// Decompiled with JetBrains decompiler
// Type: SRPG.UnitPickerSort
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CDA")]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("UI/UnitPickerSort")]
  public class UnitPickerSort : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DEEA")]
    [FieldOffset(Offset = "0xC")]
    public string MenuID;
    [Token(Token = "0x400DEEB")]
    [FieldOffset(Offset = "0x10")]
    public bool LocalizeCaption;
    [Token(Token = "0x400DEEC")]
    [FieldOffset(Offset = "0x14")]
    public string DefaultCaption;
    [Token(Token = "0x400DEED")]
    [FieldOffset(Offset = "0x18")]
    public bool UseFilterCaption;
    [Token(Token = "0x400DEEE")]
    [FieldOffset(Offset = "0x19")]
    public bool mSelectedAscending;
    [Token(Token = "0x400DEEF")]
    [FieldOffset(Offset = "0x1C")]
    public Toggle Ascending;
    [Token(Token = "0x400DEF0")]
    [FieldOffset(Offset = "0x20")]
    public Toggle Descending;
    [Token(Token = "0x400DEF1")]
    [FieldOffset(Offset = "0x24")]
    public SortMenu.SortMenuItem[] Items;
    [Token(Token = "0x400DEF2")]
    [FieldOffset(Offset = "0x28")]
    public SRPG_Button DecideButton;
    [Token(Token = "0x400DEF3")]
    [FieldOffset(Offset = "0x2C")]
    public UnitPickerSort.SortEvent OnAccept;

    [Token(Token = "0x600D0AE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D0AF")]
    [Address(RVA = "0x9BBB90", Offset = "0x9BA990", VA = "0x109BBB90")]
    public void Open()
    {
    }

    [Token(Token = "0x600D0B0")]
    [Address(RVA = "0x9BC030", Offset = "0x9BAE30", VA = "0x109BC030")]
    private void Start()
    {
    }

    [Token(Token = "0x600D0B1")]
    [Address(RVA = "0x9BB980", Offset = "0x9BA780", VA = "0x109BB980")]
    private void Accept()
    {
    }

    [Token(Token = "0x600D0B2")]
    [Address(RVA = "0x9BBF10", Offset = "0x9BAD10", VA = "0x109BBF10")]
    public void SetUp(string method)
    {
    }

    [Token(Token = "0x600D0B3")]
    [Address(RVA = "0x9BBEA0", Offset = "0x9BACA0", VA = "0x109BBEA0")]
    public void SetUp(string method, bool ascending = false)
    {
    }

    [Token(Token = "0x600D0B4")]
    [Address(RVA = "0x9BBDC0", Offset = "0x9BABC0", VA = "0x109BBDC0")]
    public void SaveState()
    {
    }

    [Token(Token = "0x600D0B5")]
    [Address(RVA = "0x9BBCB0", Offset = "0x9BAAB0", VA = "0x109BBCB0")]
    public void RestoreState()
    {
    }

    [Token(Token = "0x17001B73")]
    public string CurrentCaption
    {
      [Token(Token = "0x600D0B6"), Address(RVA = "0x9BC150", Offset = "0x9BAF50", VA = "0x109BC150")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001B74")]
    public string SortMethod
    {
      [Token(Token = "0x600D0B7"), Address(RVA = "0x9BC360", Offset = "0x9BB160", VA = "0x109BC360")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600D0B8"), Address(RVA = "0x9BC600", Offset = "0x9BB400", VA = "0x109BC600")] set
      {
      }
    }

    [Token(Token = "0x17001B75")]
    public bool IsAscending
    {
      [Token(Token = "0x600D0B9"), Address(RVA = "0x9BC280", Offset = "0x9BB080", VA = "0x109BC280")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D0BA"), Address(RVA = "0x9BC440", Offset = "0x9BB240", VA = "0x109BC440")] set
      {
      }
    }

    [Token(Token = "0x17001B76")]
    public bool IsDescending
    {
      [Token(Token = "0x600D0BB"), Address(RVA = "0x9BC2F0", Offset = "0x9BB0F0", VA = "0x109BC2F0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D0BC"), Address(RVA = "0x9BC520", Offset = "0x9BB320", VA = "0x109BC520")] set
      {
      }
    }

    [Token(Token = "0x600D0BD")]
    [Address(RVA = "0x9BBA70", Offset = "0x9BA870", VA = "0x109BBA70")]
    public bool Contains(string method) => new bool();

    [Token(Token = "0x600D0BE")]
    [Address(RVA = "0x9BBAE0", Offset = "0x9BA8E0", VA = "0x109BBAE0")]
    public string GetSortMethod() => (string) null;

    [Token(Token = "0x600D0BF")]
    [Address(RVA = "0x9BC0E0", Offset = "0x9BAEE0", VA = "0x109BC0E0")]
    public UnitPickerSort()
    {
    }

    [Token(Token = "0x2002CDB")]
    public delegate void SortEvent(string method, bool ascending);
  }
}
