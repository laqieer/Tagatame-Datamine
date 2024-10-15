// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardFilterTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AD6")]
  [AddComponentMenu("UI/SortFilter/ConceptCardFilterTab")]
  public class ConceptCardFilterTab : MonoBehaviour
  {
    [Token(Token = "0x400D0EA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mFilteredObject;
    [Token(Token = "0x400D0EB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mDefaultObject;
    [Token(Token = "0x400D0EC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle mToggle;
    [Token(Token = "0x400D0ED")]
    [FieldOffset(Offset = "0x18")]
    private bool m_IsFiltered;

    [Token(Token = "0x17001A0D")]
    public bool isOn
    {
      [Token(Token = "0x600C3A0"), Address(RVA = "0x8BD940", Offset = "0x8BC740", VA = "0x108BD940")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C3A1"), Address(RVA = "0x8BD9B0", Offset = "0x8BC7B0", VA = "0x108BD9B0")] set
      {
      }
    }

    [Token(Token = "0x600C3A2")]
    [Address(RVA = "0x8BD8D0", Offset = "0x8BC6D0", VA = "0x108BD8D0")]
    public void SetIsFiltered(bool isFiltered)
    {
    }

    [Token(Token = "0x600C3A3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardFilterTab()
    {
    }
  }
}
