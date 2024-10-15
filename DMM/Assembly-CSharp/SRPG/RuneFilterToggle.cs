// Decompiled with JetBrains decompiler
// Type: SRPG.RuneFilterToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029A8")]
  public class RuneFilterToggle : MonoBehaviour
  {
    [Token(Token = "0x400C9CB")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400C9CC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle mToggle;
    [Token(Token = "0x400C9CD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mRarityParent;
    [Token(Token = "0x400C9CE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mRarityTemplate;
    [Token(Token = "0x400C9CF")]
    [FieldOffset(Offset = "0x1C")]
    private RuneFilterToggleModel mModel;

    [Token(Token = "0x17001990")]
    public Toggle Toggle
    {
      [Token(Token = "0x600BD11"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (Toggle) null;
      }
    }

    [Token(Token = "0x600BD12")]
    [Address(RVA = "0x84B830", Offset = "0x84A630", VA = "0x1084B830")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BD13")]
    [Address(RVA = "0x84B6E0", Offset = "0x84A4E0", VA = "0x1084B6E0")]
    public void Initialize(RuneFilterToggleModel model)
    {
    }

    [Token(Token = "0x600BD14")]
    [Address(RVA = "0x84BCD0", Offset = "0x84AAD0", VA = "0x1084BCD0")]
    private void Setup()
    {
    }

    [Token(Token = "0x600BD15")]
    [Address(RVA = "0x84BB10", Offset = "0x84A910", VA = "0x1084BB10")]
    public void RefreshToggleRarity()
    {
    }

    [Token(Token = "0x600BD16")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneFilterToggle()
    {
    }
  }
}
