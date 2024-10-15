// Decompiled with JetBrains decompiler
// Type: SRPG.RuneSortToggleItem
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
  [Token(Token = "0x2002AE8")]
  [AddComponentMenu("UI/SortFilter/RuneSortToggleItem")]
  public class RuneSortToggleItem : MonoBehaviour
  {
    [Token(Token = "0x400D151")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle m_Toggle;
    [Token(Token = "0x400D152")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text m_SortName;

    [Token(Token = "0x17001A1D")]
    public bool isOn
    {
      [Token(Token = "0x600C40E"), Address(RVA = "0x5F8EF0", Offset = "0x5F7CF0", VA = "0x105F8EF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C40F")]
    [Address(RVA = "0x8C4B90", Offset = "0x8C3990", VA = "0x108C4B90")]
    public void SetToggleSilient(bool value)
    {
    }

    [Token(Token = "0x600C410")]
    [Address(RVA = "0x8C4C10", Offset = "0x8C3A10", VA = "0x108C4C10")]
    public void SetToggleValueChangeListner(UnityAction<bool> onToggleValueChanged)
    {
    }

    [Token(Token = "0x600C411")]
    [Address(RVA = "0x8C4B10", Offset = "0x8C3910", VA = "0x108C4B10")]
    public void SetName(string name)
    {
    }

    [Token(Token = "0x600C412")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneSortToggleItem()
    {
    }
  }
}
