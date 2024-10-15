// Decompiled with JetBrains decompiler
// Type: SRPG.FilterUnitTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AE1")]
  [AddComponentMenu("UI/SortFilter/FilterUnitTab")]
  public class FilterUnitTab : MonoBehaviour
  {
    [Token(Token = "0x400D128")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject m_FilteredObject;
    [Token(Token = "0x400D129")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject m_DefaultObject;
    [Token(Token = "0x400D12A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle m_Toggle;
    [Token(Token = "0x400D12B")]
    [FieldOffset(Offset = "0x18")]
    private bool m_IsFiltered;

    [Token(Token = "0x17001A15")]
    public bool isOn
    {
      [Token(Token = "0x600C3E2"), Address(RVA = "0x8C19E0", Offset = "0x8C07E0", VA = "0x108C19E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C3E3"), Address(RVA = "0x8C1A50", Offset = "0x8C0850", VA = "0x108C1A50")] set
      {
      }
    }

    [Token(Token = "0x600C3E4")]
    [Address(RVA = "0x8C1970", Offset = "0x8C0770", VA = "0x108C1970")]
    public void SetIsFiltered(bool isFiltered)
    {
    }

    [Token(Token = "0x600C3E5")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public FilterUnitTab()
    {
    }
  }
}
