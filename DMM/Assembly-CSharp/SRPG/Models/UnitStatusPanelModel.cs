// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitStatusPanelModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033DB")]
  public class UnitStatusPanelModel
  {
    [Token(Token = "0x400F58E")]
    [FieldOffset(Offset = "0x8")]
    private readonly string STATUS_HIDE_TEXT;
    [Token(Token = "0x400F58F")]
    private const string StatusEmpty = "---";
    [Token(Token = "0x400F590")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsHide;
    [Token(Token = "0x400F591")]
    [FieldOffset(Offset = "0x10")]
    private string mParamValue;
    [Token(Token = "0x400F592")]
    [FieldOffset(Offset = "0x14")]
    private Color mParamColor;

    [Token(Token = "0x17002142")]
    public bool IsHide
    {
      [Token(Token = "0x600E84C"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002143")]
    public string ParamValue
    {
      [Token(Token = "0x600E84D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002144")]
    public Color ParamColor
    {
      [Token(Token = "0x600E84E"), Address(RVA = "0xAB0F90", Offset = "0xAAFD90", VA = "0x10AB0F90")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x600E84F")]
    [Address(RVA = "0xAD3DE0", Offset = "0xAD2BE0", VA = "0x10AD3DE0")]
    public UnitStatusPanelModel(bool isHide = false)
    {
    }

    [Token(Token = "0x600E850")]
    [Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")]
    public void Initialize(string paramValue)
    {
    }

    [Token(Token = "0x600E851")]
    [Address(RVA = "0xAD34D0", Offset = "0xAD22D0", VA = "0x10AD34D0")]
    public void SetDafault()
    {
    }

    [Token(Token = "0x600E852")]
    [Address(RVA = "0xAD3450", Offset = "0xAD2250", VA = "0x10AD3450")]
    public void Initialize(Unit unit, UnitStatusPanelModel.Type type)
    {
    }

    [Token(Token = "0x600E853")]
    [Address(RVA = "0xAD33D0", Offset = "0xAD21D0", VA = "0x10AD33D0")]
    public void Initialize(UnitData unitData, UnitStatusPanelModel.Type type)
    {
    }

    [Token(Token = "0x600E854")]
    [Address(RVA = "0xAD3AF0", Offset = "0xAD28F0", VA = "0x10AD3AF0")]
    public void SetParamValue(Unit unit, UnitStatusPanelModel.Type type)
    {
    }

    [Token(Token = "0x600E855")]
    [Address(RVA = "0xAD35B0", Offset = "0xAD23B0", VA = "0x10AD35B0")]
    public void SetParamValue(UnitData unitData, UnitStatusPanelModel.Type type)
    {
    }

    [Token(Token = "0x600E856")]
    [Address(RVA = "0xAD3520", Offset = "0xAD2320", VA = "0x10AD3520")]
    public void SetHideText(UnitStatusPanelModel.Type type)
    {
    }

    [Token(Token = "0x20033DC")]
    public enum Type
    {
      [Token(Token = "0x400F594")] Hp,
      [Token(Token = "0x400F595")] HpMax,
      [Token(Token = "0x400F596")] Mp,
      [Token(Token = "0x400F597")] MpIni,
      [Token(Token = "0x400F598")] MpMax,
      [Token(Token = "0x400F599")] Atk,
      [Token(Token = "0x400F59A")] Def,
      [Token(Token = "0x400F59B")] Mag,
      [Token(Token = "0x400F59C")] Mnd,
      [Token(Token = "0x400F59D")] Rec,
      [Token(Token = "0x400F59E")] Dex,
      [Token(Token = "0x400F59F")] Spd,
      [Token(Token = "0x400F5A0")] Cri,
      [Token(Token = "0x400F5A1")] Luk,
      [Token(Token = "0x400F5A2")] Mov,
      [Token(Token = "0x400F5A3")] Jmp,
      [Token(Token = "0x400F5A4")] Renkei,
      [Token(Token = "0x400F5A5")] StatusAwakeHP,
    }
  }
}
