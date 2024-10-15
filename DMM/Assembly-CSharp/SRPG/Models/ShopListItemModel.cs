// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ShopListItemModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033BD")]
  public class ShopListItemModel
  {
    [Token(Token = "0x400F4F5")]
    [FieldOffset(Offset = "0x8")]
    private ShopListItemModel.Param param;
    [Token(Token = "0x400F4F6")]
    [FieldOffset(Offset = "0xC")]
    private Sprite eventCoinIconSprite;

    [Token(Token = "0x170020AF")]
    public EShopType ShopType
    {
      [Token(Token = "0x600E747"), Address(RVA = "0xAC6C60", Offset = "0xAC5A60", VA = "0x10AC6C60")] get
      {
        return new EShopType();
      }
    }

    [Token(Token = "0x170020B0")]
    public EShopBannerType BannerType
    {
      [Token(Token = "0x600E748"), Address(RVA = "0xAC6C80", Offset = "0xAC5A80", VA = "0x10AC6C80")] get
      {
        return new EShopBannerType();
      }
    }

    [Token(Token = "0x170020B1")]
    public int Priority
    {
      [Token(Token = "0x600E749"), Address(RVA = "0x805480", Offset = "0x804280", VA = "0x10805480")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020B2")]
    public long EndTime
    {
      [Token(Token = "0x600E74A"), Address(RVA = "0xACD030", Offset = "0xACBE30", VA = "0x10ACD030")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170020B3")]
    public bool EndTimeActive
    {
      [Token(Token = "0x600E74B"), Address(RVA = "0xACD010", Offset = "0xACBE10", VA = "0x10ACD010")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020B4")]
    public Sprite BannerSprite
    {
      [Token(Token = "0x600E74C"), Address(RVA = "0x749500", Offset = "0x748300", VA = "0x10749500")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x170020B5")]
    public string BannerId
    {
      [Token(Token = "0x600E74D"), Address(RVA = "0xACCFD0", Offset = "0xACBDD0", VA = "0x10ACCFD0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170020B6")]
    public string ParentBannerId
    {
      [Token(Token = "0x600E74E"), Address(RVA = "0xACD0C0", Offset = "0xACBEC0", VA = "0x10ACD0C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170020B7")]
    public string ShopCostIname
    {
      [Token(Token = "0x600E74F"), Address(RVA = "0xACD0E0", Offset = "0xACBEE0", VA = "0x10ACD0E0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170020B8")]
    public bool ButtonUpdate
    {
      [Token(Token = "0x600E750"), Address(RVA = "0xACCFF0", Offset = "0xACBDF0", VA = "0x10ACCFF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020B9")]
    public JSON_ShopListArray.Shops Shops
    {
      [Token(Token = "0x600E751"), Address(RVA = "0x8054A0", Offset = "0x8042A0", VA = "0x108054A0")] get
      {
        return (JSON_ShopListArray.Shops) null;
      }
    }

    [Token(Token = "0x170020BA")]
    public EventShopInfo EventShopInfo
    {
      [Token(Token = "0x600E752"), Address(RVA = "0xAC6CA0", Offset = "0xAC5AA0", VA = "0x10AC6CA0")] get
      {
        return (EventShopInfo) null;
      }
    }

    [Token(Token = "0x170020BB")]
    public bool UnlockFlg
    {
      [Token(Token = "0x600E753"), Address(RVA = "0xACD100", Offset = "0xACBF00", VA = "0x10ACD100")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020BC")]
    public string UnlockMessage
    {
      [Token(Token = "0x600E754"), Address(RVA = "0xACD120", Offset = "0xACBF20", VA = "0x10ACD120")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170020BD")]
    public Sprite EventCoinIconSprite
    {
      [Token(Token = "0x600E755"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x170020BE")]
    public int EventCoin
    {
      [Token(Token = "0x600E756"), Address(RVA = "0xACD040", Offset = "0xACBE40", VA = "0x10ACD040")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020BF")]
    public Sprite MultiCoinIconSprite
    {
      [Token(Token = "0x600E757"), Address(RVA = "0xACD050", Offset = "0xACBE50", VA = "0x10ACD050")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x170020C0")]
    public int MultiCoin
    {
      [Token(Token = "0x600E758"), Address(RVA = "0xACD070", Offset = "0xACBE70", VA = "0x10ACD070")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E759")]
    [Address(RVA = "0xACCE50", Offset = "0xACBC50", VA = "0x10ACCE50")]
    public void Initialize(ShopListItemModel.Param param, bool unlockFlg = false, string unlockMsg = "")
    {
    }

    [Token(Token = "0x600E75A")]
    [Address(RVA = "0xACCA80", Offset = "0xACB880", VA = "0x10ACCA80")]
    private void InitializeEventShop()
    {
    }

    [Token(Token = "0x600E75B")]
    [Address(RVA = "0xACC6E0", Offset = "0xACB4E0", VA = "0x10ACC6E0")]
    private int GetEventCoin() => new int();

    [Token(Token = "0x600E75C")]
    [Address(RVA = "0xACC890", Offset = "0xACB690", VA = "0x10ACC890")]
    private long GetNearestEndTime() => new long();

    [Token(Token = "0x600E75D")]
    [Address(RVA = "0xACCF20", Offset = "0xACBD20", VA = "0x10ACCF20")]
    public bool IsActiveOnlyEventOrMulti() => new bool();

    [Token(Token = "0x600E75E")]
    [Address(RVA = "0xACCEC0", Offset = "0xACBCC0", VA = "0x10ACCEC0")]
    public bool IsActiveBody() => new bool();

    [Token(Token = "0x600E75F")]
    [Address(RVA = "0xACCEC0", Offset = "0xACBCC0", VA = "0x10ACCEC0")]
    public bool IsNeedCheckTimer() => new bool();

    [Token(Token = "0x600E760")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ShopListItemModel()
    {
    }

    [Token(Token = "0x20033BE")]
    public class Param
    {
      [Token(Token = "0x400F4F7")]
      [FieldOffset(Offset = "0x8")]
      public JSON_ShopListArray.Shops Shops;
      [Token(Token = "0x400F4F8")]
      [FieldOffset(Offset = "0xC")]
      public int Priority;
      [Token(Token = "0x400F4F9")]
      [FieldOffset(Offset = "0x10")]
      public EShopType ShopType;
      [Token(Token = "0x400F4FA")]
      [FieldOffset(Offset = "0x14")]
      public Sprite BannerSprite;
      [Token(Token = "0x400F4FB")]
      [FieldOffset(Offset = "0x18")]
      public EShopBannerType BannerType;
      [Token(Token = "0x400F4FC")]
      [FieldOffset(Offset = "0x20")]
      public long EndTime;
      [Token(Token = "0x400F4FD")]
      [FieldOffset(Offset = "0x28")]
      public bool EndTimeActive;
      [Token(Token = "0x400F4FE")]
      [FieldOffset(Offset = "0x2C")]
      public string BannerId;
      [Token(Token = "0x400F4FF")]
      [FieldOffset(Offset = "0x30")]
      public List<long> childrenEndTimes;
      [Token(Token = "0x400F500")]
      [FieldOffset(Offset = "0x34")]
      public string ParentBannerId;
      [Token(Token = "0x400F501")]
      [FieldOffset(Offset = "0x38")]
      public EventShopInfo EventShopInfo;
      [Token(Token = "0x400F502")]
      [FieldOffset(Offset = "0x3C")]
      public bool UnlockFlg;
      [Token(Token = "0x400F503")]
      [FieldOffset(Offset = "0x40")]
      public string UnlockMessage;
      [Token(Token = "0x400F504")]
      [FieldOffset(Offset = "0x44")]
      public string EventCoinIname;
      [Token(Token = "0x400F505")]
      [FieldOffset(Offset = "0x48")]
      public string ShopCostIname;
      [Token(Token = "0x400F506")]
      [FieldOffset(Offset = "0x4C")]
      public bool ButtonUpdate;
      [Token(Token = "0x400F507")]
      [FieldOffset(Offset = "0x50")]
      public Sprite MultiCoinIconSprite;

      [Token(Token = "0x600E763")]
      [Address(RVA = "0xAC5740", Offset = "0xAC4540", VA = "0x10AC5740")]
      public Param()
      {
      }
    }
  }
}
