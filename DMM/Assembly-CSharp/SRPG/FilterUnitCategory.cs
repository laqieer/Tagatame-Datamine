// Decompiled with JetBrains decompiler
// Type: SRPG.FilterUnitCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AE0")]
  [AddComponentMenu("UI/SortFilter/FilterUnitCategory")]
  public class FilterUnitCategory : MonoBehaviour
  {
    [Token(Token = "0x400D126")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text m_HeaderText;
    [Token(Token = "0x400D127")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject m_ToggleTemplate;

    [Token(Token = "0x600C3DE")]
    [Address(RVA = "0x8C1920", Offset = "0x8C0720", VA = "0x108C1920")]
    private void Start()
    {
    }

    [Token(Token = "0x600C3DF")]
    [Address(RVA = "0x5A9D10", Offset = "0x5A8B10", VA = "0x105A9D10")]
    public void SetHeaderText(string headerText)
    {
    }

    [Token(Token = "0x600C3E0")]
    [Address(RVA = "0x8C1800", Offset = "0x8C0600", VA = "0x108C1800")]
    public Toggle CreateFilterButton(FilterUnitConditionParam filterConditionParam)
    {
      return (Toggle) null;
    }

    [Token(Token = "0x600C3E1")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public FilterUnitCategory()
    {
    }
  }
}
