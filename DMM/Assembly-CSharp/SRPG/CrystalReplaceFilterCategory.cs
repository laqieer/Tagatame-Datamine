// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalReplaceFilterCategory
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
  [Token(Token = "0x200228A")]
  [AddComponentMenu("UI/SortFilter/CrystalReplaceFilterCategory")]
  public class CrystalReplaceFilterCategory : MonoBehaviour
  {
    [Token(Token = "0x400995A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mHeaderText;
    [Token(Token = "0x400995B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle mToggleTemplate;
    [Token(Token = "0x400995C")]
    [FieldOffset(Offset = "0x14")]
    private Dictionary<Toggle, CrystalReplaceFilterCondParam> mToggleDatas;
    [Token(Token = "0x400995D")]
    [FieldOffset(Offset = "0x18")]
    private CrystalReplaceFilterParam mFilterParam;
    [Token(Token = "0x400995E")]
    [FieldOffset(Offset = "0x1C")]
    private Dictionary<string, GameObject> mCreatedToggles;
    [Token(Token = "0x400995F")]
    [FieldOffset(Offset = "0x20")]
    private CrystalReplaceFilterWindow mWindow;

    [Token(Token = "0x170014C6")]
    public Dictionary<Toggle, CrystalReplaceFilterCondParam> ToggleDatas
    {
      [Token(Token = "0x60093C9"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (Dictionary<Toggle, CrystalReplaceFilterCondParam>) null;
      }
    }

    [Token(Token = "0x170014C7")]
    public CrystalReplaceFilterParam FilterParam
    {
      [Token(Token = "0x60093CA"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (CrystalReplaceFilterParam) null;
      }
    }

    [Token(Token = "0x60093CB")]
    [Address(RVA = "0x56BAF0", Offset = "0x56A8F0", VA = "0x1056BAF0")]
    public void Init(CrystalReplaceFilterWindow _window, CrystalReplaceFilterParam filter_param)
    {
    }

    [Token(Token = "0x60093CC")]
    [Address(RVA = "0x56BF40", Offset = "0x56AD40", VA = "0x1056BF40")]
    public bool IsExistActiveToggle() => new bool();

    [Token(Token = "0x60093CD")]
    [Address(RVA = "0x56C120", Offset = "0x56AF20", VA = "0x1056C120")]
    public CrystalReplaceFilterCategory()
    {
    }
  }
}
