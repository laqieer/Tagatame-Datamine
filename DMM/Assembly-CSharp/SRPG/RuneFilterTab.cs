// Decompiled with JetBrains decompiler
// Type: SRPG.RuneFilterTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AE3")]
  [AddComponentMenu("UI/SortFilter/RuneFilterTab")]
  public class RuneFilterTab : MonoBehaviour
  {
    [Token(Token = "0x400D131")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject m_FilteredObject;
    [Token(Token = "0x400D132")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject m_DefaultObject;
    [Token(Token = "0x400D133")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle m_Toggle;
    [Token(Token = "0x400D134")]
    [FieldOffset(Offset = "0x18")]
    private bool m_IsFiltered;

    [Token(Token = "0x17001A18")]
    public bool isOn
    {
      [Token(Token = "0x600C3ED"), Address(RVA = "0x8C2D10", Offset = "0x8C1B10", VA = "0x108C2D10")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C3EE"), Address(RVA = "0x8C2D80", Offset = "0x8C1B80", VA = "0x108C2D80")] set
      {
      }
    }

    [Token(Token = "0x600C3EF")]
    [Address(RVA = "0x8C2CA0", Offset = "0x8C1AA0", VA = "0x108C2CA0")]
    public void SetIsFiltered(bool isFiltered)
    {
    }

    [Token(Token = "0x600C3F0")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneFilterTab()
    {
    }
  }
}
