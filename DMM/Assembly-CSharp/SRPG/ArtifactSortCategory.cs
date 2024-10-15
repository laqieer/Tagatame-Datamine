// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactSortCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FE6")]
  public class ArtifactSortCategory : MonoBehaviour
  {
    [Token(Token = "0x4008780")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform Parent;
    [Token(Token = "0x4008781")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ArtifactSortToggle ToggleTempleate;
    [Token(Token = "0x4008782")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject NameTextParent;
    [Token(Token = "0x4008783")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text NameText;
    [Token(Token = "0x4008784")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject SubNameTextParent;
    [Token(Token = "0x4008785")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text SubNameText;

    [Token(Token = "0x170012D8")]
    public SortArtifactParam Param
    {
      [Token(Token = "0x6008399"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (SortArtifactParam) null;
      }
      [Token(Token = "0x600839A"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] private set
      {
      }
    }

    [Token(Token = "0x600839B")]
    [Address(RVA = "0x441740", Offset = "0x440540", VA = "0x10441740")]
    public void SetUp(ArtifactSortWindow _window, SortArtifactParam _param, bool _is_disp_title)
    {
    }

    [Token(Token = "0x600839C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtifactSortCategory()
    {
    }
  }
}
