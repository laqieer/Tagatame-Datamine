﻿// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestEventRewardsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C06")]
  public class PointQuestEventRewardsData
  {
    [Token(Token = "0x4006C99")]
    [FieldOffset(Offset = "0x8")]
    private RaidRewardType mItemType;
    [Token(Token = "0x4006C9A")]
    [FieldOffset(Offset = "0xC")]
    private string mItemIname;
    [Token(Token = "0x4006C9B")]
    [FieldOffset(Offset = "0x10")]
    private int mItemNum;

    [Token(Token = "0x17000E65")]
    public RaidRewardType ItemType
    {
      [Token(Token = "0x6007374"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RaidRewardType();
      }
    }

    [Token(Token = "0x17000E66")]
    public string ItemIname
    {
      [Token(Token = "0x6007375"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E67")]
    public int ItemNum
    {
      [Token(Token = "0x6007376"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007377")]
    [Address(RVA = "0x31AF60", Offset = "0x319D60", VA = "0x1031AF60")]
    public void Deserialize(JSON_PointQuestEventRewardData json)
    {
    }

    [Token(Token = "0x6007378")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestEventRewardsData()
    {
    }
  }
}