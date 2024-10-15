// Decompiled with JetBrains decompiler
// Type: SRPG.RuneFilterCategory
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
  [Token(Token = "0x2002AE2")]
  [AddComponentMenu("UI/SortFilter/RuneFilterCategory")]
  public class RuneFilterCategory : MonoBehaviour
  {
    [Token(Token = "0x400D12C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mHeaderText;
    [Token(Token = "0x400D12D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mToggleTemplate;
    [Token(Token = "0x400D12E")]
    [FieldOffset(Offset = "0x14")]
    private List<Toggle> mToggles;
    [Token(Token = "0x400D12F")]
    [FieldOffset(Offset = "0x18")]
    private FilterRuneParam mFilterParam;
    [Token(Token = "0x400D130")]
    [FieldOffset(Offset = "0x1C")]
    private Dictionary<string, GameObject> mCreatedToggles;

    [Token(Token = "0x17001A16")]
    public List<Toggle> Toggles
    {
      [Token(Token = "0x600C3E6"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<Toggle>) null;
      }
    }

    [Token(Token = "0x17001A17")]
    public FilterRuneParam FilterParam
    {
      [Token(Token = "0x600C3E7"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (FilterRuneParam) null;
      }
    }

    [Token(Token = "0x600C3E8")]
    [Address(RVA = "0x8C2640", Offset = "0x8C1440", VA = "0x108C2640")]
    public void Init(FilterRuneParam filter_param)
    {
    }

    [Token(Token = "0x600C3E9")]
    [Address(RVA = "0x8C2B40", Offset = "0x8C1940", VA = "0x108C2B40")]
    private void OnToggleValueChanged()
    {
    }

    [Token(Token = "0x600C3EA")]
    [Address(RVA = "0x8C2AB0", Offset = "0x8C18B0", VA = "0x108C2AB0")]
    public bool IsExistActiveToggle() => new bool();

    [Token(Token = "0x600C3EB")]
    [Address(RVA = "0x8C2BF0", Offset = "0x8C19F0", VA = "0x108C2BF0")]
    public RuneFilterCategory()
    {
    }
  }
}
