// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactSortToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FE9")]
  public class ArtifactSortToggle : MonoBehaviour
  {
    [Token(Token = "0x400878C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text NameText;
    [Token(Token = "0x400878D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle ToggleButton;
    [Token(Token = "0x400878E")]
    [FieldOffset(Offset = "0x14")]
    private SortArtifactCondParam mParam;
    [Token(Token = "0x400878F")]
    [FieldOffset(Offset = "0x18")]
    private string mParentIname;

    [Token(Token = "0x170012DA")]
    public SortArtifactCondParam GetParam
    {
      [Token(Token = "0x60083A3"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (SortArtifactCondParam) null;
      }
    }

    [Token(Token = "0x170012DB")]
    public string GetParentIname
    {
      [Token(Token = "0x60083A4"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170012DC")]
    public Toggle GetToggle
    {
      [Token(Token = "0x60083A5"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (Toggle) null;
      }
    }

    [Token(Token = "0x60083A6")]
    [Address(RVA = "0x441C50", Offset = "0x440A50", VA = "0x10441C50")]
    public void SetUp(
      ArtifactSortWindow _window,
      SortArtifactCondParam _param,
      string _parent_iname)
    {
    }

    [Token(Token = "0x60083A7")]
    [Address(RVA = "0x441E80", Offset = "0x440C80", VA = "0x10441E80")]
    public void ToggleOff()
    {
    }

    [Token(Token = "0x60083A8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtifactSortToggle()
    {
    }
  }
}
