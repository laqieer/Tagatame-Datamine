// Decompiled with JetBrains decompiler
// Type: SRPG.RuneResetEvoStatusPriorityChild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029D6")]
  public class RuneResetEvoStatusPriorityChild : MonoBehaviour
  {
    [Token(Token = "0x400CB1C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle mTogglePriority;
    [Token(Token = "0x400CB1D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray mImageArray;
    [Token(Token = "0x400CB1E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneDrawCost mRuneDrawCost;
    [Token(Token = "0x400CB1F")]
    [FieldOffset(Offset = "0x18")]
    private UnityAction<bool> mOnValueChanged;
    [Token(Token = "0x400CB20")]
    [FieldOffset(Offset = "0x1C")]
    private RuneCost mRuneCost;
    [Token(Token = "0x400CB21")]
    [FieldOffset(Offset = "0x20")]
    private int mPriority;
    [Token(Token = "0x400CB22")]
    [FieldOffset(Offset = "0x24")]
    private int mUseCount;

    [Token(Token = "0x170019B2")]
    public int Priority
    {
      [Token(Token = "0x600BE8F"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170019B3")]
    public bool IsOn
    {
      [Token(Token = "0x600BE90"), Address(RVA = "0x85ED10", Offset = "0x85DB10", VA = "0x1085ED10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170019B4")]
    public RuneCost RuneCost
    {
      [Token(Token = "0x600BE91"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (RuneCost) null;
      }
    }

    [Token(Token = "0x600BE92")]
    [Address(RVA = "0x85E930", Offset = "0x85D730", VA = "0x1085E930")]
    public bool IsEnoughCost() => new bool();

    [Token(Token = "0x600BE93")]
    [Address(RVA = "0x85EB80", Offset = "0x85D980", VA = "0x1085EB80")]
    public void SetUseCount(int use_count)
    {
    }

    [Token(Token = "0x600BE94")]
    [Address(RVA = "0x85EBA0", Offset = "0x85D9A0", VA = "0x1085EBA0")]
    public void Setup(RuneCost cost, UnityAction<bool> onValueChanged, int use_count = 1)
    {
    }

    [Token(Token = "0x600BE95")]
    [Address(RVA = "0x85E960", Offset = "0x85D760", VA = "0x1085E960")]
    public void OnValueChanged(bool isOn)
    {
    }

    [Token(Token = "0x600BE96")]
    [Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")]
    public void SetPriority(int priority)
    {
    }

    [Token(Token = "0x600BE97")]
    [Address(RVA = "0x85EB40", Offset = "0x85D940", VA = "0x1085EB40")]
    public void SetToggle(bool isOn)
    {
    }

    [Token(Token = "0x600BE98")]
    [Address(RVA = "0x85EA30", Offset = "0x85D830", VA = "0x1085EA30")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BE99")]
    [Address(RVA = "0x85ECF0", Offset = "0x85DAF0", VA = "0x1085ECF0")]
    public RuneResetEvoStatusPriorityChild()
    {
    }
  }
}
