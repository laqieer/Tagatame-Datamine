// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.UnitTobiraExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034EF")]
  public class UnitTobiraExhibit : BaseExhibit, IRenderModel<UnitTobiraModel>, IRenderModel
  {
    [Token(Token = "0x400FB49")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (UnitTobiraExhibit.EKey), typeof (UnitTobiraExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400FB4A")]
    [FieldOffset(Offset = "0x38")]
    public GameObject[] LevelIconGOList;
    [Token(Token = "0x400FB4B")]
    [FieldOffset(Offset = "0x3C")]
    public Animator animator;

    [Token(Token = "0x600EA5B")]
    [Address(RVA = "0xAFB750", Offset = "0xAFA550", VA = "0x10AFB750", Slot = "8")]
    public void Render(UnitTobiraModel model)
    {
    }

    [Token(Token = "0x600EA5C")]
    [Address(RVA = "0xAFBB70", Offset = "0xAFA970", VA = "0x10AFBB70")]
    private void SetBase(UnitTobiraModel model)
    {
    }

    [Token(Token = "0x600EA5D")]
    [Address(RVA = "0xAFBBA0", Offset = "0xAFA9A0", VA = "0x10AFBBA0")]
    private void SetDisable(UnitTobiraModel model)
    {
    }

    [Token(Token = "0x600EA5E")]
    [Address(RVA = "0xAFBBE0", Offset = "0xAFA9E0", VA = "0x10AFBBE0")]
    private void SetEnable(UnitTobiraModel model)
    {
    }

    [Token(Token = "0x600EA5F")]
    [Address(RVA = "0xAFBDC0", Offset = "0xAFABC0", VA = "0x10AFBDC0")]
    private void SetLock(UnitTobiraModel model)
    {
    }

    [Token(Token = "0x600EA60")]
    [Address(RVA = "0xAFBDF0", Offset = "0xAFABF0", VA = "0x10AFBDF0")]
    private void SetSelect(UnitTobiraModel model)
    {
    }

    [Token(Token = "0x600EA61")]
    [Address(RVA = "0xAFBD10", Offset = "0xAFAB10", VA = "0x10AFBD10")]
    private void SetHilight(UnitTobiraModel model)
    {
    }

    [Token(Token = "0x600EA62")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitTobiraExhibit()
    {
    }

    [Token(Token = "0x20034F0")]
    private enum EKey
    {
      [Token(Token = "0x400FB4D")] None,
      [Token(Token = "0x400FB4E")] Base,
      [Token(Token = "0x400FB4F")] Disable,
      [Token(Token = "0x400FB50")] Enable,
      [Token(Token = "0x400FB51")] Lock,
      [Token(Token = "0x400FB52")] Selected,
      [Token(Token = "0x400FB53")] hilight,
    }
  }
}
