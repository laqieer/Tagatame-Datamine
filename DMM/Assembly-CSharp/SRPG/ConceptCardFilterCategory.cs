// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardFilterCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AD5")]
  [AddComponentMenu("UI/SortFilter/ConceptCardFilterCategory")]
  public class ConceptCardFilterCategory : MonoBehaviour
  {
    [Token(Token = "0x400D0E5")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mHeaderText;
    [Token(Token = "0x400D0E6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mToggleTemplate;
    [Token(Token = "0x400D0E7")]
    [FieldOffset(Offset = "0x14")]
    private List<Toggle> mToggles;
    [Token(Token = "0x400D0E8")]
    [FieldOffset(Offset = "0x18")]
    private FilterConceptCardParam mFilterParam;
    [Token(Token = "0x400D0E9")]
    [FieldOffset(Offset = "0x1C")]
    private Dictionary<string, GameObject> mCreatedToggles;

    [Token(Token = "0x17001A0B")]
    public List<Toggle> Toggles
    {
      [Token(Token = "0x600C399"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<Toggle>) null;
      }
    }

    [Token(Token = "0x17001A0C")]
    public FilterConceptCardParam FilterParam
    {
      [Token(Token = "0x600C39A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (FilterConceptCardParam) null;
      }
    }

    [Token(Token = "0x600C39B")]
    [Address(RVA = "0x8BD280", Offset = "0x8BC080", VA = "0x108BD280")]
    public void Init(FilterConceptCardParam filter_param)
    {
    }

    [Token(Token = "0x600C39C")]
    [Address(RVA = "0x8BD770", Offset = "0x8BC570", VA = "0x108BD770")]
    private void OnToggleValueChanged()
    {
    }

    [Token(Token = "0x600C39D")]
    [Address(RVA = "0x8BD6E0", Offset = "0x8BC4E0", VA = "0x108BD6E0")]
    public bool IsExistActiveToggle() => new bool();

    [Token(Token = "0x600C39E")]
    [Address(RVA = "0x8BD820", Offset = "0x8BC620", VA = "0x108BD820")]
    public ConceptCardFilterCategory()
    {
    }
  }
}
