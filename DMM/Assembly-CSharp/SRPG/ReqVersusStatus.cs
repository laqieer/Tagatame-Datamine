// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003122")]
  public class ReqVersusStatus : WebAPI
  {
    [Token(Token = "0x600DDB7")]
    [Address(RVA = "0xA8F5F0", Offset = "0xA8E3F0", VA = "0x10A8F5F0")]
    public ReqVersusStatus(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003123")]
    public class StreakStatus
    {
      [Token(Token = "0x400EC94")]
      [FieldOffset(Offset = "0x8")]
      public int schedule_id;
      [Token(Token = "0x400EC95")]
      [FieldOffset(Offset = "0xC")]
      public int num;
      [Token(Token = "0x400EC96")]
      [FieldOffset(Offset = "0x10")]
      public int best;

      [Token(Token = "0x600DDB8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public StreakStatus()
      {
      }
    }

    [Token(Token = "0x2003124")]
    public class EnableTimeSchedule
    {
      [Token(Token = "0x400EC97")]
      [FieldOffset(Offset = "0x8")]
      public long expired;
      [Token(Token = "0x400EC98")]
      [FieldOffset(Offset = "0x10")]
      public long next;
      [Token(Token = "0x400EC99")]
      [FieldOffset(Offset = "0x18")]
      public int draft_type;
      [Token(Token = "0x400EC9A")]
      [FieldOffset(Offset = "0x20")]
      public long schedule_id;
      [Token(Token = "0x400EC9B")]
      [FieldOffset(Offset = "0x28")]
      public long draft_id;
      [Token(Token = "0x400EC9C")]
      [FieldOffset(Offset = "0x30")]
      public string iname;

      [Token(Token = "0x600DDB9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public EnableTimeSchedule()
      {
      }
    }

    [Token(Token = "0x2003125")]
    public class TagatameCupFormData
    {
      [Token(Token = "0x400EC9D")]
      [FieldOffset(Offset = "0x8")]
      public int enable;
      [Token(Token = "0x400EC9E")]
      [FieldOffset(Offset = "0xC")]
      public int is_defeat;
      [Token(Token = "0x400EC9F")]
      [FieldOffset(Offset = "0x10")]
      public string url;
      [Token(Token = "0x400ECA0")]
      [FieldOffset(Offset = "0x14")]
      public string begin_at;
      [Token(Token = "0x400ECA1")]
      [FieldOffset(Offset = "0x18")]
      public string end_at;
      [Token(Token = "0x400ECA2")]
      [FieldOffset(Offset = "0x1C")]
      public int remain;
      [Token(Token = "0x400ECA3")]
      [FieldOffset(Offset = "0x20")]
      public int win;

      [Token(Token = "0x600DDBA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public TagatameCupFormData()
      {
      }
    }

    [Token(Token = "0x2003126")]
    public class Response
    {
      [Token(Token = "0x400ECA4")]
      [FieldOffset(Offset = "0x8")]
      public int floor;
      [Token(Token = "0x400ECA5")]
      [FieldOffset(Offset = "0xC")]
      public int key;
      [Token(Token = "0x400ECA6")]
      [FieldOffset(Offset = "0x10")]
      public int wincnt;
      [Token(Token = "0x400ECA7")]
      [FieldOffset(Offset = "0x14")]
      public int is_season_gift;
      [Token(Token = "0x400ECA8")]
      [FieldOffset(Offset = "0x18")]
      public int is_give_season_gift;
      [Token(Token = "0x400ECA9")]
      [FieldOffset(Offset = "0x20")]
      public long end_at;
      [Token(Token = "0x400ECAA")]
      [FieldOffset(Offset = "0x28")]
      public string vstower_id;
      [Token(Token = "0x400ECAB")]
      [FieldOffset(Offset = "0x2C")]
      public string tower_iname;
      [Token(Token = "0x400ECAC")]
      [FieldOffset(Offset = "0x30")]
      public string last_enemyuid;
      [Token(Token = "0x400ECAD")]
      [FieldOffset(Offset = "0x34")]
      public int daycnt;
      [Token(Token = "0x400ECAE")]
      [FieldOffset(Offset = "0x38")]
      public ReqVersusStatus.StreakStatus[] streakwins;
      [Token(Token = "0x400ECAF")]
      [FieldOffset(Offset = "0x3C")]
      public int is_firstwin;
      [Token(Token = "0x400ECB0")]
      [FieldOffset(Offset = "0x40")]
      public ReqVersusStatus.EnableTimeSchedule enabletime;
      [Token(Token = "0x400ECB1")]
      [FieldOffset(Offset = "0x44")]
      public ReqVersusStatus.TagatameCupFormData event_form;

      [Token(Token = "0x600DDBB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
