// Decompiled with JetBrains decompiler
// Type: SRPG.ArtiFilterItemTab
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
  [Token(Token = "0x2002ACD")]
  [AddComponentMenu("UI/SortFilter/ArtiFilterItemTab")]
  public class ArtiFilterItemTab : MonoBehaviour
  {
    [Token(Token = "0x400D0C3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text TextTab;
    [Token(Token = "0x400D0C4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle ToggleTab;
    [Token(Token = "0x400D0C5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject GoFiltered;
    [Token(Token = "0x400D0C6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject GoDefault;
    [Token(Token = "0x400D0C7")]
    [FieldOffset(Offset = "0x1C")]
    private int mIndex;
    [Token(Token = "0x400D0C8")]
    [FieldOffset(Offset = "0x20")]
    private FilterArtifactParam mParam;

    [Token(Token = "0x17001A08")]
    public int Index
    {
      [Token(Token = "0x600C373"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001A09")]
    public FilterArtifactParam Param
    {
      [Token(Token = "0x600C374"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (FilterArtifactParam) null;
      }
    }

    [Token(Token = "0x17001A0A")]
    public bool IsOn
    {
      [Token(Token = "0x600C375"), Address(RVA = "0x8BA640", Offset = "0x8B9440", VA = "0x108BA640")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C376"), Address(RVA = "0x8BA6B0", Offset = "0x8B94B0", VA = "0x108BA6B0")] set
      {
      }
    }

    [Token(Token = "0x600C377")]
    [Address(RVA = "0x8BA5F0", Offset = "0x8B93F0", VA = "0x108BA5F0")]
    public void SetToggleSilent(bool val)
    {
    }

    [Token(Token = "0x600C378")]
    [Address(RVA = "0x8BA4F0", Offset = "0x8B92F0", VA = "0x108BA4F0")]
    public void SetItem(int index, FilterArtifactParam param, UnityAction<bool> action = null)
    {
    }

    [Token(Token = "0x600C379")]
    [Address(RVA = "0x8BA480", Offset = "0x8B9280", VA = "0x108BA480")]
    public void SetIsFiltered(bool is_filtered)
    {
    }

    [Token(Token = "0x600C37A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtiFilterItemTab()
    {
    }
  }
}
