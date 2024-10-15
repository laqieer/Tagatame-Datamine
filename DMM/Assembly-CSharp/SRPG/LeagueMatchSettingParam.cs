// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchSettingParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BCE")]
  [MessagePackObject(true)]
  public class LeagueMatchSettingParam
  {
    [Token(Token = "0x4006A87")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006A88")]
    [FieldOffset(Offset = "0xC")]
    public LeagueMatchHideTypes mUnit1_edit;
    [Token(Token = "0x4006A89")]
    [FieldOffset(Offset = "0x10")]
    public LeagueMatchHideTypes mUnit2_edit;
    [Token(Token = "0x4006A8A")]
    [FieldOffset(Offset = "0x14")]
    public LeagueMatchHideTypes mUnit3_edit;
    [Token(Token = "0x4006A8B")]
    [FieldOffset(Offset = "0x18")]
    public LeagueMatchHideTypes mUnit_job;
    [Token(Token = "0x4006A8C")]
    [FieldOffset(Offset = "0x1C")]
    public LeagueMatchHideTypes mLeader_skill;
    [Token(Token = "0x4006A8D")]
    [FieldOffset(Offset = "0x20")]
    public LeagueMatchHideTypes mConceptcard;
    [Token(Token = "0x4006A8E")]
    [FieldOffset(Offset = "0x24")]
    public LeagueMatchHideTypes mArtifact;
    [Token(Token = "0x4006A8F")]
    [FieldOffset(Offset = "0x28")]
    public LeagueMatchHideTypes mCrystal;
    [Token(Token = "0x4006A90")]
    [FieldOffset(Offset = "0x2C")]
    public LeagueMatchHideTypes mUnit_level;
    [Token(Token = "0x4006A91")]
    [FieldOffset(Offset = "0x30")]
    public LeagueMatchHideTypes mUnit_ability;
    [Token(Token = "0x4006A92")]
    [FieldOffset(Offset = "0x34")]
    public LeagueMatchHideTypes mUnit_status;
    [Token(Token = "0x4006A93")]
    [FieldOffset(Offset = "0x38")]
    public LeagueMatchHideTypes mUnit_rarity;
    [Token(Token = "0x4006A94")]
    [FieldOffset(Offset = "0x3C")]
    public LeagueMatchHideTypes mBuf;
    [Token(Token = "0x4006A95")]
    [FieldOffset(Offset = "0x40")]
    public LeagueMatchHideTypes mMap;
    [Token(Token = "0x4006A96")]
    [FieldOffset(Offset = "0x44")]
    public LeagueMatchHideTypes mMap_unit;

    [Token(Token = "0x17000E2B")]
    public string Iname
    {
      [Token(Token = "0x60072D0"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E2C")]
    public bool Unit1_edit
    {
      [Token(Token = "0x60072D1"), Address(RVA = "0x2B0B60", Offset = "0x2AF960", VA = "0x102B0B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E2D")]
    public bool Unit2_edit
    {
      [Token(Token = "0x60072D2"), Address(RVA = "0x37AD10", Offset = "0x379B10", VA = "0x1037AD10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E2E")]
    public bool Unit3_edit
    {
      [Token(Token = "0x60072D3"), Address(RVA = "0x368420", Offset = "0x367220", VA = "0x10368420")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E2F")]
    public bool Unit_job
    {
      [Token(Token = "0x60072D4"), Address(RVA = "0x37AD30", Offset = "0x379B30", VA = "0x1037AD30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E30")]
    public bool Leader_skill
    {
      [Token(Token = "0x60072D5"), Address(RVA = "0x37ACE0", Offset = "0x379AE0", VA = "0x1037ACE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E31")]
    public bool Conceptcard
    {
      [Token(Token = "0x60072D6"), Address(RVA = "0x37ACD0", Offset = "0x379AD0", VA = "0x1037ACD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E32")]
    public bool Artifact
    {
      [Token(Token = "0x60072D7"), Address(RVA = "0x37ACB0", Offset = "0x379AB0", VA = "0x1037ACB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E33")]
    public bool Crystal
    {
      [Token(Token = "0x60072D8"), Address(RVA = "0x377030", Offset = "0x375E30", VA = "0x10377030")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E34")]
    public bool Unit_level
    {
      [Token(Token = "0x60072D9"), Address(RVA = "0x37AD40", Offset = "0x379B40", VA = "0x1037AD40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E35")]
    public bool Unit_ability
    {
      [Token(Token = "0x60072DA"), Address(RVA = "0x37AD20", Offset = "0x379B20", VA = "0x1037AD20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E36")]
    public bool Unit_status
    {
      [Token(Token = "0x60072DB"), Address(RVA = "0x37AD60", Offset = "0x379B60", VA = "0x1037AD60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E37")]
    public bool Unit_rarity
    {
      [Token(Token = "0x60072DC"), Address(RVA = "0x37AD50", Offset = "0x379B50", VA = "0x1037AD50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E38")]
    public bool Buf
    {
      [Token(Token = "0x60072DD"), Address(RVA = "0x37ACC0", Offset = "0x379AC0", VA = "0x1037ACC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E39")]
    public bool Map
    {
      [Token(Token = "0x60072DE"), Address(RVA = "0x37ACF0", Offset = "0x379AF0", VA = "0x1037ACF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E3A")]
    public bool Map_unit
    {
      [Token(Token = "0x60072DF"), Address(RVA = "0x37AD00", Offset = "0x379B00", VA = "0x1037AD00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60072E0")]
    [Address(RVA = "0x37AC20", Offset = "0x379A20", VA = "0x1037AC20")]
    public bool Deserialize(JSON_LeagueMatchSettingParam json) => new bool();

    [Token(Token = "0x60072E1")]
    [Address(RVA = "0x37AA60", Offset = "0x379860", VA = "0x1037AA60")]
    public static bool Deserialize(
      ref List<LeagueMatchSettingParam> paramList,
      JSON_LeagueMatchSettingParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x60072E2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchSettingParam()
    {
    }
  }
}
