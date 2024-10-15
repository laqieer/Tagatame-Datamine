// Decompiled with JetBrains decompiler
// Type: SRPG.RuneResetEvoStatusPriority
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
  [Token(Token = "0x20029D2")]
  public class RuneResetEvoStatusPriority : MonoBehaviour
  {
    [Token(Token = "0x400CB0F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mPriorityParent;
    [Token(Token = "0x400CB10")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneResetEvoStatusPriorityChild mPriorityChildTemplate;
    [Token(Token = "0x400CB11")]
    [FieldOffset(Offset = "0x14")]
    private List<RuneResetEvoStatusPriorityChild> mPriorityChildList;
    [Token(Token = "0x400CB12")]
    [FieldOffset(Offset = "0x18")]
    private UnityAction<bool> mOnValueChanged;
    [Token(Token = "0x400CB13")]
    [FieldOffset(Offset = "0x1C")]
    private BindRuneData mRuneData;
    [Token(Token = "0x400CB14")]
    private const string KEY_NAME = "RUNESETTING.RESETCONFIG";

    [Token(Token = "0x170019B1")]
    public List<RuneResetEvoStatusPriorityChild> PriorityChildList
    {
      [Token(Token = "0x600BE7E"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<RuneResetEvoStatusPriorityChild>) null;
      }
    }

    [Token(Token = "0x600BE7F")]
    [Address(RVA = "0x85FA90", Offset = "0x85E890", VA = "0x1085FA90")]
    public void Setup(BindRuneData bind_rune, UnityAction<bool> onValueChanged, int use_count)
    {
    }

    [Token(Token = "0x600BE80")]
    [Address(RVA = "0x85F9B0", Offset = "0x85E7B0", VA = "0x1085F9B0")]
    public void SetUseCount(int use_count)
    {
    }

    [Token(Token = "0x600BE81")]
    [Address(RVA = "0x85F6D0", Offset = "0x85E4D0", VA = "0x1085F6D0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BE82")]
    [Address(RVA = "0x85F3F0", Offset = "0x85E1F0", VA = "0x1085F3F0")]
    private void OnValueChanged(bool isOn)
    {
    }

    [Token(Token = "0x600BE83")]
    [Address(RVA = "0x85F430", Offset = "0x85E230", VA = "0x1085F430")]
    private void PrioritySort()
    {
    }

    [Token(Token = "0x600BE84")]
    [Address(RVA = "0x85ED80", Offset = "0x85DB80", VA = "0x1085ED80")]
    public int GetEnoughCostIndex() => new int();

    [Token(Token = "0x600BE85")]
    [Address(RVA = "0x85F7C0", Offset = "0x85E5C0", VA = "0x1085F7C0")]
    public void SavePrefs()
    {
    }

    [Token(Token = "0x600BE86")]
    [Address(RVA = "0x85F020", Offset = "0x85DE20", VA = "0x1085F020")]
    private void LoadPrefs()
    {
    }

    [Token(Token = "0x600BE87")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneResetEvoStatusPriority()
    {
    }

    [Token(Token = "0x20029D3")]
    private class Config
    {
      [Token(Token = "0x400CB15")]
      [FieldOffset(Offset = "0x8")]
      public int[] priority;

      [Token(Token = "0x600BE88")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Config()
      {
      }
    }

    [Token(Token = "0x20029D4")]
    private class SortObj
    {
      [Token(Token = "0x400CB16")]
      [FieldOffset(Offset = "0x8")]
      public int priority;
      [Token(Token = "0x400CB17")]
      [FieldOffset(Offset = "0xC")]
      public RuneResetEvoStatusPriorityChild child;

      [Token(Token = "0x600BE89")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public SortObj()
      {
      }
    }
  }
}
