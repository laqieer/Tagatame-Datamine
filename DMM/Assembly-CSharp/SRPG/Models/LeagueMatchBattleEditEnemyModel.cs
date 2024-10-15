// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchBattleEditEnemyModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003352")]
  public class LeagueMatchBattleEditEnemyModel
  {
    [Token(Token = "0x400F232")]
    [FieldOffset(Offset = "0x8")]
    private LeagueMatchSeasonParam _seasonParam;
    [Token(Token = "0x400F233")]
    [FieldOffset(Offset = "0xC")]
    private LeagueMatchSettingParam _settingParam;
    [Token(Token = "0x400F234")]
    [FieldOffset(Offset = "0x10")]
    private JSON_LeagueMatchEnemies _response;
    [Token(Token = "0x400F235")]
    [FieldOffset(Offset = "0x14")]
    private int _seasonID;
    [Token(Token = "0x400F236")]
    [FieldOffset(Offset = "0x18")]
    private string _fuid;
    [Token(Token = "0x400F237")]
    [FieldOffset(Offset = "0x1C")]
    private string _userName;
    [Token(Token = "0x400F238")]
    [FieldOffset(Offset = "0x20")]
    private int _userLevel;
    [Token(Token = "0x400F239")]
    [FieldOffset(Offset = "0x24")]
    private int _totalPower;
    [Token(Token = "0x400F23A")]
    [FieldOffset(Offset = "0x28")]
    private string _rankIconKey;
    [Token(Token = "0x400F23B")]
    [FieldOffset(Offset = "0x2C")]
    private string _rankNameKey;
    [Token(Token = "0x400F23C")]
    [FieldOffset(Offset = "0x30")]
    private int _point;
    [Token(Token = "0x400F23D")]
    [FieldOffset(Offset = "0x34")]
    private bool _isBattle;
    [Token(Token = "0x400F23E")]
    [FieldOffset(Offset = "0x38")]
    private int _WinLose;
    [Token(Token = "0x400F23F")]
    [FieldOffset(Offset = "0x3C")]
    private bool _IsRankingOut;
    [Token(Token = "0x400F240")]
    [FieldOffset(Offset = "0x3D")]
    private bool _IsNpc;
    [Token(Token = "0x400F241")]
    [FieldOffset(Offset = "0x40")]
    private List<UnitModel> _unitModelList;

    [Token(Token = "0x17001E7E")]
    public string Fuid
    {
      [Token(Token = "0x600E31D"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E7F")]
    public string UserName
    {
      [Token(Token = "0x600E31E"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E80")]
    public int UserLevel
    {
      [Token(Token = "0x600E31F"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E81")]
    public int TotalPower
    {
      [Token(Token = "0x600E320"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E82")]
    public bool Unit1EditShow
    {
      [Token(Token = "0x600E321"), Address(RVA = "0xAB3430", Offset = "0xAB2230", VA = "0x10AB3430")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E83")]
    public bool Unit2EditShow
    {
      [Token(Token = "0x600E322"), Address(RVA = "0xAB3460", Offset = "0xAB2260", VA = "0x10AB3460")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E84")]
    public bool Unit3EditShow
    {
      [Token(Token = "0x600E323"), Address(RVA = "0xAB3490", Offset = "0xAB2290", VA = "0x10AB3490")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E85")]
    public string RankIconKey
    {
      [Token(Token = "0x600E324"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E86")]
    public string RankNameKey
    {
      [Token(Token = "0x600E325"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E87")]
    public int Point
    {
      [Token(Token = "0x600E326"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E88")]
    public bool IsBattle
    {
      [Token(Token = "0x600E327"), Address(RVA = "0x54FFB0", Offset = "0x54EDB0", VA = "0x1054FFB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E89")]
    public int WinLoss
    {
      [Token(Token = "0x600E328"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E8A")]
    public bool IsRankingOut
    {
      [Token(Token = "0x600E329"), Address(RVA = "0x428380", Offset = "0x427180", VA = "0x10428380")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E8B")]
    public bool IsNpc
    {
      [Token(Token = "0x600E32A"), Address(RVA = "0x56B2D0", Offset = "0x56A0D0", VA = "0x1056B2D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E8C")]
    public List<UnitModel> UnitModelList
    {
      [Token(Token = "0x600E32B"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (List<UnitModel>) null;
      }
    }

    [Token(Token = "0x17001E8D")]
    public int SeasonID
    {
      [Token(Token = "0x600E32C"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E8E")]
    public LeagueMatchSettingParam SettingParam
    {
      [Token(Token = "0x600E32D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (LeagueMatchSettingParam) null;
      }
    }

    [Token(Token = "0x17001E8F")]
    public JSON_LeagueMatchEnemies Response
    {
      [Token(Token = "0x600E32E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (JSON_LeagueMatchEnemies) null;
      }
    }

    [Token(Token = "0x17001E90")]
    public bool IsSelectActive
    {
      [Token(Token = "0x600E32F"), Address(RVA = "0xAAFAD0", Offset = "0xAAE8D0", VA = "0x10AAFAD0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E330"), Address(RVA = "0xAAFB30", Offset = "0xAAE930", VA = "0x10AAFB30")] set
      {
      }
    }

    [Token(Token = "0x600E331")]
    [Address(RVA = "0xAB3070", Offset = "0xAB1E70", VA = "0x10AB3070")]
    public bool IsGetShow(int index) => new bool();

    [Token(Token = "0x600E332")]
    [Address(RVA = "0xAB3040", Offset = "0xAB1E40", VA = "0x10AB3040")]
    public void Initialize(int seasonID, JSON_LeagueMatchEnemies response)
    {
    }

    [Token(Token = "0x600E333")]
    [Address(RVA = "0xAB2BB0", Offset = "0xAB19B0", VA = "0x10AB2BB0")]
    private void InitializeData()
    {
    }

    [Token(Token = "0x600E334")]
    [Address(RVA = "0xAB30D0", Offset = "0xAB1ED0", VA = "0x10AB30D0")]
    private void NPCConvert(JSON_LeagueMatchEnemies json)
    {
    }

    [Token(Token = "0x600E335")]
    [Address(RVA = "0xAB2940", Offset = "0xAB1740", VA = "0x10AB2940")]
    private void Deserialize(JSON_LeagueMatchEnemies json)
    {
    }

    [Token(Token = "0x600E336")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchBattleEditEnemyModel()
    {
    }
  }
}
