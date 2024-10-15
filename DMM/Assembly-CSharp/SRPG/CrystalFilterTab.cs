// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalFilterTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002ADB")]
  [AddComponentMenu("UI/SortFilter/CrystalFilterTab")]
  public class CrystalFilterTab : MonoBehaviour
  {
    [Token(Token = "0x400D10A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject m_FilteredObject;
    [Token(Token = "0x400D10B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject m_DefaultObject;
    [Token(Token = "0x400D10C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle m_Toggle;
    [Token(Token = "0x400D10D")]
    [FieldOffset(Offset = "0x18")]
    private bool m_IsFiltered;

    [Token(Token = "0x600C3BF")]
    [Address(RVA = "0x8BF8F0", Offset = "0x8BE6F0", VA = "0x108BF8F0")]
    public void SetCrystalFilterParam(CrystalFilterParam param)
    {
    }

    [Token(Token = "0x600C3C0")]
    [Address(RVA = "0x8BFA10", Offset = "0x8BE810", VA = "0x108BFA10")]
    public void SetCrystalReplaceFilterParam(
      CrystalReplaceFilterWindow _window,
      CrystalReplaceFilterParam param)
    {
    }

    [Token(Token = "0x17001A12")]
    public bool isOn
    {
      [Token(Token = "0x600C3C1"), Address(RVA = "0x8BFBB0", Offset = "0x8BE9B0", VA = "0x108BFBB0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C3C2"), Address(RVA = "0x8BFC20", Offset = "0x8BEA20", VA = "0x108BFC20")] set
      {
      }
    }

    [Token(Token = "0x600C3C3")]
    [Address(RVA = "0x8BFB40", Offset = "0x8BE940", VA = "0x108BFB40")]
    public void SetIsFiltered(bool isFiltered)
    {
    }

    [Token(Token = "0x600C3C4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalFilterTab()
    {
    }
  }
}
