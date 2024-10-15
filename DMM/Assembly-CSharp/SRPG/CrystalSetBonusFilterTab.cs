// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalSetBonusFilterTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022E0")]
  public class CrystalSetBonusFilterTab : MonoBehaviour
  {
    [Token(Token = "0x4009B52")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject m_FilteredObject;
    [Token(Token = "0x4009B53")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject m_DefaultObject;
    [Token(Token = "0x4009B54")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle m_Toggle;
    [Token(Token = "0x4009B55")]
    [FieldOffset(Offset = "0x18")]
    private bool m_IsFiltered;

    [Token(Token = "0x60095C7")]
    [Address(RVA = "0x5888F0", Offset = "0x5876F0", VA = "0x105888F0")]
    public void SetCrystalSetBonusFilterParam(CrystalSetBonusFilterParam param)
    {
    }

    [Token(Token = "0x170014ED")]
    public bool isOn
    {
      [Token(Token = "0x60095C8"), Address(RVA = "0x588A80", Offset = "0x587880", VA = "0x10588A80")] get
      {
        return new bool();
      }
      [Token(Token = "0x60095C9"), Address(RVA = "0x588AF0", Offset = "0x5878F0", VA = "0x10588AF0")] set
      {
      }
    }

    [Token(Token = "0x60095CA")]
    [Address(RVA = "0x588A10", Offset = "0x587810", VA = "0x10588A10")]
    public void SetIsFiltered(bool isFiltered)
    {
    }

    [Token(Token = "0x60095CB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalSetBonusFilterTab()
    {
    }
  }
}
