// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalFilterCategory
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
  [Token(Token = "0x2002AD9")]
  [AddComponentMenu("UI/SortFilter/CrystalFilterCategory")]
  public class CrystalFilterCategory : MonoBehaviour
  {
    [Token(Token = "0x400D103")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mHeaderText;
    [Token(Token = "0x400D104")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle mToggleTemplate;
    [Token(Token = "0x400D105")]
    [FieldOffset(Offset = "0x14")]
    private Dictionary<Toggle, CrystalFilterCondParam> mToggleDatas;
    [Token(Token = "0x400D106")]
    [FieldOffset(Offset = "0x18")]
    private CrystalFilterParam mFilterParam;
    [Token(Token = "0x400D107")]
    [FieldOffset(Offset = "0x1C")]
    private Dictionary<string, GameObject> mCreatedToggles;

    [Token(Token = "0x17001A10")]
    public Dictionary<Toggle, CrystalFilterCondParam> ToggleDatas
    {
      [Token(Token = "0x600C3B7"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (Dictionary<Toggle, CrystalFilterCondParam>) null;
      }
    }

    [Token(Token = "0x17001A11")]
    public CrystalFilterParam FilterParam
    {
      [Token(Token = "0x600C3B8"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (CrystalFilterParam) null;
      }
    }

    [Token(Token = "0x600C3B9")]
    [Address(RVA = "0x8BF200", Offset = "0x8BE000", VA = "0x108BF200")]
    public void Init(CrystalFilterParam filter_param)
    {
    }

    [Token(Token = "0x600C3BA")]
    [Address(RVA = "0x8BF6D0", Offset = "0x8BE4D0", VA = "0x108BF6D0")]
    public bool IsExistActiveToggle() => new bool();

    [Token(Token = "0x600C3BB")]
    [Address(RVA = "0x8BF840", Offset = "0x8BE640", VA = "0x108BF840")]
    public CrystalFilterCategory()
    {
    }
  }
}
