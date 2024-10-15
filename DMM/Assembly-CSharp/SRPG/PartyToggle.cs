// Decompiled with JetBrains decompiler
// Type: SRPG.PartyToggle
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
  [Token(Token = "0x200235A")]
  public class PartyToggle : ContentNode
  {
    [Token(Token = "0x4009E75")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x4009E76")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Toggle mToggle;
    [Token(Token = "0x4009E77")]
    [FieldOffset(Offset = "0x38")]
    private PartyToggleModel mModel;

    [Token(Token = "0x17001544")]
    public PartyToggleModel Model
    {
      [Token(Token = "0x600985F"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (PartyToggleModel) null;
      }
    }

    [Token(Token = "0x17001545")]
    public Toggle Toggle
    {
      [Token(Token = "0x6009860"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (Toggle) null;
      }
    }

    [Token(Token = "0x6009861")]
    [Address(RVA = "0x5B8A00", Offset = "0x5B7800", VA = "0x105B8A00")]
    public void Initialize(
      BulkReleaseWindow.EquipPartyType type,
      bool visible,
      bool badge,
      bool toggle,
      bool toggle_intractable)
    {
    }

    [Token(Token = "0x6009862")]
    [Address(RVA = "0x5B8AD0", Offset = "0x5B78D0", VA = "0x105B8AD0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6009863")]
    [Address(RVA = "0x36F5F0", Offset = "0x36E3F0", VA = "0x1036F5F0")]
    public void SetModel(PartyToggleModel model)
    {
    }

    [Token(Token = "0x6009864")]
    [Address(RVA = "0x5B8B50", Offset = "0x5B7950", VA = "0x105B8B50")]
    public void SetToggle(bool isflag)
    {
    }

    [Token(Token = "0x6009865")]
    [Address(RVA = "0x5B8940", Offset = "0x5B7740", VA = "0x105B8940")]
    public static void CallBack(ContentNode node, PartyToggleModel model)
    {
    }

    [Token(Token = "0x6009866")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public PartyToggle()
    {
    }
  }
}
