// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalSetBonusFilterCategry
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
  [Token(Token = "0x20022DD")]
  public class CrystalSetBonusFilterCategry : MonoBehaviour
  {
    [Token(Token = "0x4009B4A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mHeaderText;
    [Token(Token = "0x4009B4B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle mToggleTemplate;
    [Token(Token = "0x4009B4C")]
    [FieldOffset(Offset = "0x14")]
    private Dictionary<Toggle, CrystalSetBonusFilterCondParam> mToggleDatas;
    [Token(Token = "0x4009B4D")]
    [FieldOffset(Offset = "0x18")]
    private CrystalSetBonusFilterParam mFilterParam;
    [Token(Token = "0x4009B4E")]
    [FieldOffset(Offset = "0x1C")]
    private Dictionary<string, GameObject> mCreatedToggles;

    [Token(Token = "0x170014EB")]
    public Dictionary<Toggle, CrystalSetBonusFilterCondParam> ToggleDatas
    {
      [Token(Token = "0x60095BB"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (Dictionary<Toggle, CrystalSetBonusFilterCondParam>) null;
      }
    }

    [Token(Token = "0x170014EC")]
    public CrystalSetBonusFilterParam FilterParam
    {
      [Token(Token = "0x60095BC"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (CrystalSetBonusFilterParam) null;
      }
    }

    [Token(Token = "0x60095BD")]
    [Address(RVA = "0x5881D0", Offset = "0x586FD0", VA = "0x105881D0")]
    public void Init(
      CrystalSetBonusFilterParam filter_param,
      List<CrystalSetBonusFilterCondParam> cond_params)
    {
    }

    [Token(Token = "0x60095BE")]
    [Address(RVA = "0x588790", Offset = "0x587590", VA = "0x10588790")]
    private void OnToggleValueChanged()
    {
    }

    [Token(Token = "0x60095BF")]
    [Address(RVA = "0x5886A0", Offset = "0x5874A0", VA = "0x105886A0")]
    public bool IsExistActiveToggle() => new bool();

    [Token(Token = "0x60095C0")]
    [Address(RVA = "0x588840", Offset = "0x587640", VA = "0x10588840")]
    public CrystalSetBonusFilterCategry()
    {
    }
  }
}
