// Decompiled with JetBrains decompiler
// Type: SRPG.Models.GachaTabListItemModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003347")]
  public class GachaTabListItemModel : GachaTabListItemBaseModel
  {
    [Token(Token = "0x400F1FE")]
    [FieldOffset(Offset = "0x10")]
    private readonly string mFormatKey;
    [Token(Token = "0x400F1FF")]
    [FieldOffset(Offset = "0x14")]
    private GachaTabListItemModel.GachaTabListItemModelData mData;
    [Token(Token = "0x400F200")]
    [FieldOffset(Offset = "0x18")]
    private string mTimeLimitText;

    [Token(Token = "0x17001E56")]
    public GachaTabListItemModel.GachaTabListItemModelData Data
    {
      [Token(Token = "0x600E2CF"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (GachaTabListItemModel.GachaTabListItemModelData) null;
      }
    }

    [Token(Token = "0x17001E57")]
    public string TimeLimitText
    {
      [Token(Token = "0x600E2D0"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E2D1")]
    [Address(RVA = "0xAB1350", Offset = "0xAB0150", VA = "0x10AB1350")]
    public void Initialize(
      GachaTabListItemModel.GachaTabListItemModelData data)
    {
    }

    [Token(Token = "0x600E2D2")]
    [Address(RVA = "0xAB1380", Offset = "0xAB0180", VA = "0x10AB1380", Slot = "4")]
    protected override bool IsIgnoreUpdateButtonInteractable() => new bool();

    [Token(Token = "0x600E2D3")]
    [Address(RVA = "0xAB13A0", Offset = "0xAB01A0", VA = "0x10AB13A0")]
    public bool UpdateButtonInteractable(bool isInteractable) => new bool();

    [Token(Token = "0x600E2D4")]
    [Address(RVA = "0xAB13D0", Offset = "0xAB01D0", VA = "0x10AB13D0")]
    public bool UpdateTimeLimitText(TimeSpan span) => new bool();

    [Token(Token = "0x600E2D5")]
    [Address(RVA = "0xAB16D0", Offset = "0xAB04D0", VA = "0x10AB16D0")]
    public GachaTabListItemModel()
    {
    }

    [Token(Token = "0x2003348")]
    public class GachaTabListItemModelData : GachaTabListItemBaseModel.GachaTabListItemBaseModelData
    {
      [Token(Token = "0x17001E58")]
      public bool IsButtonInteractable
      {
        [Token(Token = "0x600E2D6"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
        {
          return new bool();
        }
        [Token(Token = "0x600E2D7"), Address(RVA = "0x305870", Offset = "0x304670", VA = "0x10305870")] set
        {
        }
      }

      [Token(Token = "0x17001E59")]
      public bool Disabled
      {
        [Token(Token = "0x600E2D8"), Address(RVA = "0x3FE5C0", Offset = "0x3FD3C0", VA = "0x103FE5C0")] get
        {
          return new bool();
        }
        [Token(Token = "0x600E2D9"), Address(RVA = "0x4082C0", Offset = "0x4070C0", VA = "0x104082C0")] set
        {
        }
      }

      [Token(Token = "0x17001E5A")]
      public Sprite TabSprite
      {
        [Token(Token = "0x600E2DA"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return (Sprite) null;
        }
        [Token(Token = "0x600E2DB"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
        {
        }
      }

      [Token(Token = "0x600E2DC")]
      [Address(RVA = "0xAB12F0", Offset = "0xAB00F0", VA = "0x10AB12F0")]
      public GachaTabListItemModelData(
        bool isButtonInteractable,
        bool disabled,
        Sprite tabSprite,
        GachaTabListItemBase.GachaTabListItemBaseSetupData baseData)
      {
      }
    }
  }
}
