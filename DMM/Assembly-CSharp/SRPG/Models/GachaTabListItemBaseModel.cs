// Decompiled with JetBrains decompiler
// Type: SRPG.Models.GachaTabListItemBaseModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003345")]
  public class GachaTabListItemBaseModel
  {
    [Token(Token = "0x400F1F7")]
    [FieldOffset(Offset = "0x8")]
    private GachaTabListItemBaseModel.GachaTabListItemBaseModelData mData;
    [Token(Token = "0x400F1F8")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsSelect;
    [Token(Token = "0x400F1F9")]
    [FieldOffset(Offset = "0xD")]
    private bool mIsButtonEnable;

    [Token(Token = "0x17001E4E")]
    public GachaTabListItemBaseModel.GachaTabListItemBaseModelData Data
    {
      [Token(Token = "0x600E2BD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (GachaTabListItemBaseModel.GachaTabListItemBaseModelData) null;
      }
    }

    [Token(Token = "0x17001E4F")]
    public bool IsSelect
    {
      [Token(Token = "0x600E2BE"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E50")]
    public bool IsButtonEnable
    {
      [Token(Token = "0x600E2BF"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E51")]
    public Vector3 TabScale
    {
      [Token(Token = "0x600E2C0"), Address(RVA = "0xAB1290", Offset = "0xAB0090", VA = "0x10AB1290")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x600E2C1")]
    [Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")]
    public void Initialize(
      GachaTabListItemBaseModel.GachaTabListItemBaseModelData data)
    {
    }

    [Token(Token = "0x600E2C2")]
    [Address(RVA = "0xAB1270", Offset = "0xAB0070", VA = "0x10AB1270")]
    public bool UpdateTabSelect(bool isSelect) => new bool();

    [Token(Token = "0x600E2C3")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "4")]
    protected virtual bool IsIgnoreUpdateButtonInteractable() => new bool();

    [Token(Token = "0x600E2C4")]
    [Address(RVA = "0xAB1230", Offset = "0xAB0030", VA = "0x10AB1230")]
    public bool UpdateButtonEnable(bool isEnable) => new bool();

    [Token(Token = "0x600E2C5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GachaTabListItemBaseModel()
    {
    }

    [Token(Token = "0x2003346")]
    public class GachaTabListItemBaseModelData
    {
      [Token(Token = "0x17001E52")]
      public GachaTopParamNew Param
      {
        [Token(Token = "0x600E2C6"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (GachaTopParamNew) null;
        }
        [Token(Token = "0x600E2C7"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] protected set
        {
        }
      }

      [Token(Token = "0x17001E53")]
      public GachaWindow.GachaTabCategory TabCategory
      {
        [Token(Token = "0x600E2C8"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
        {
          return new GachaWindow.GachaTabCategory();
        }
        [Token(Token = "0x600E2C9"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] protected set
        {
        }
      }

      [Token(Token = "0x17001E54")]
      public int TabIndex
      {
        [Token(Token = "0x600E2CA"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
        [Token(Token = "0x600E2CB"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] protected set
        {
        }
      }

      [Token(Token = "0x17001E55")]
      public bool IsBadgeEnable
      {
        [Token(Token = "0x600E2CC"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
        {
          return new bool();
        }
        [Token(Token = "0x600E2CD"), Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")] protected set
        {
        }
      }

      [Token(Token = "0x600E2CE")]
      [Address(RVA = "0xAB11F0", Offset = "0xAAFFF0", VA = "0x10AB11F0")]
      public GachaTabListItemBaseModelData(
        GachaTabListItemBase.GachaTabListItemBaseSetupData data)
      {
      }
    }
  }
}
