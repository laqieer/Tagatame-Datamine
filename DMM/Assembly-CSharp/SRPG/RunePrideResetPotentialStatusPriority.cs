// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideResetPotentialStatusPriority
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A48")]
  public class RunePrideResetPotentialStatusPriority : MonoBehaviour
  {
    [Token(Token = "0x400CDB7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mPriorityParent;
    [Token(Token = "0x400CDB8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RunePrideResetPotentialStatusPriorityChild mPriorityChildTemplate;
    [Token(Token = "0x400CDB9")]
    [FieldOffset(Offset = "0x14")]
    private List<RunePrideResetPotentialStatusPriorityChild> mPriorityChildList;
    [Token(Token = "0x400CDBA")]
    [FieldOffset(Offset = "0x18")]
    private UnityAction<bool> mOnValueChanged;
    [Token(Token = "0x400CDBB")]
    private const string KEY_NAME = "RUNEPRIDESETTING.RESETPRIORITY";
    [Token(Token = "0x400CDBC")]
    [FieldOffset(Offset = "0x1C")]
    private string mUnitPieceName;
    [Token(Token = "0x400CDBD")]
    [FieldOffset(Offset = "0x20")]
    private int mNeedItemCount;

    [Token(Token = "0x170019D3")]
    public List<RunePrideResetPotentialStatusPriorityChild> PriorityChildList
    {
      [Token(Token = "0x600C0D4"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<RunePrideResetPotentialStatusPriorityChild>) null;
      }
    }

    [Token(Token = "0x600C0D5")]
    [Address(RVA = "0x895930", Offset = "0x894730", VA = "0x10895930")]
    public void Setup(
      UnitData unit_data,
      RunePrideItemListParam list_param,
      UnityAction<bool> onValueChanged,
      int use_count)
    {
    }

    [Token(Token = "0x600C0D6")]
    [Address(RVA = "0x895850", Offset = "0x894650", VA = "0x10895850")]
    public void SetUseCount(int use_count)
    {
    }

    [Token(Token = "0x600C0D7")]
    [Address(RVA = "0x8955E0", Offset = "0x8943E0", VA = "0x108955E0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C0D8")]
    [Address(RVA = "0x895290", Offset = "0x894090", VA = "0x10895290")]
    private void OnValueChanged(bool isOn)
    {
    }

    [Token(Token = "0x600C0D9")]
    [Address(RVA = "0x8952D0", Offset = "0x8940D0", VA = "0x108952D0")]
    private void PrioritySort()
    {
    }

    [Token(Token = "0x600C0DA")]
    [Address(RVA = "0x894B00", Offset = "0x893900", VA = "0x10894B00")]
    public List<JSON_RunePrideSubMats> GetEnoughCosts() => (List<JSON_RunePrideSubMats>) null;

    [Token(Token = "0x600C0DB")]
    [Address(RVA = "0x8956B0", Offset = "0x8944B0", VA = "0x108956B0")]
    public void SavePrefs()
    {
    }

    [Token(Token = "0x600C0DC")]
    [Address(RVA = "0x894E30", Offset = "0x893C30", VA = "0x10894E30")]
    public void LoadPrefs()
    {
    }

    [Token(Token = "0x600C0DD")]
    [Address(RVA = "0x895D70", Offset = "0x894B70", VA = "0x10895D70")]
    public RunePrideResetPotentialStatusPriority()
    {
    }

    [Token(Token = "0x2002A49")]
    private class Config
    {
      [Token(Token = "0x400CDBE")]
      [FieldOffset(Offset = "0x8")]
      public int[] priority;

      [Token(Token = "0x600C0DE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Config()
      {
      }
    }

    [Token(Token = "0x2002A4A")]
    private class SortObj
    {
      [Token(Token = "0x400CDBF")]
      [FieldOffset(Offset = "0x8")]
      public int priority;
      [Token(Token = "0x400CDC0")]
      [FieldOffset(Offset = "0xC")]
      public RunePrideResetPotentialStatusPriorityChild child;

      [Token(Token = "0x600C0DF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public SortObj()
      {
      }
    }
  }
}
