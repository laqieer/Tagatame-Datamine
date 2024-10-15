// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchMapModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200335F")]
  public class LeagueMatchMapModel
  {
    [Token(Token = "0x400F2A3")]
    [FieldOffset(Offset = "0x8")]
    private QuestParam _questParam;
    [Token(Token = "0x400F2A4")]
    [FieldOffset(Offset = "0xC")]
    private int _seasonID;
    [Token(Token = "0x400F2A5")]
    [FieldOffset(Offset = "0x10")]
    private string _mapIname;
    [Token(Token = "0x400F2A6")]
    [FieldOffset(Offset = "0x14")]
    private string _mapImageKey;
    [Token(Token = "0x400F2A7")]
    [FieldOffset(Offset = "0x18")]
    private string _mapName;
    [Token(Token = "0x400F2A8")]
    [FieldOffset(Offset = "0x1C")]
    private string _mapDescription;
    [Token(Token = "0x400F2A9")]
    [FieldOffset(Offset = "0x20")]
    private bool _isSelect;
    [Token(Token = "0x400F2AA")]
    [FieldOffset(Offset = "0x21")]
    private bool _isHide;
    [Token(Token = "0x400F2AB")]
    [FieldOffset(Offset = "0x22")]
    private bool _isInvalid;
    [Token(Token = "0x400F2AC")]
    [FieldOffset(Offset = "0x24")]
    private int _defenceBadgeIndex;

    [Token(Token = "0x17001EC6")]
    public string MapImageKey
    {
      [Token(Token = "0x600E3A0"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EC7")]
    public string MapName
    {
      [Token(Token = "0x600E3A1"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EC8")]
    public string MapDescription
    {
      [Token(Token = "0x600E3A2"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EC9")]
    public bool IsSelect
    {
      [Token(Token = "0x600E3A3"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001ECA")]
    public bool IsHide
    {
      [Token(Token = "0x600E3A4"), Address(RVA = "0x305F20", Offset = "0x304D20", VA = "0x10305F20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001ECB")]
    public int DefenceBadgeIndex
    {
      [Token(Token = "0x600E3A5"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001ECC")]
    public bool IsInvalid
    {
      [Token(Token = "0x600E3A6"), Address(RVA = "0xAB8420", Offset = "0xAB7220", VA = "0x10AB8420")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E3A7")]
    [Address(RVA = "0xAB8390", Offset = "0xAB7190", VA = "0x10AB8390")]
    public void Initialize(int seasonID, string mapIname, string nowMapIname = null, bool isDefenceBadge = false)
    {
    }

    [Token(Token = "0x600E3A8")]
    [Address(RVA = "0xAB8300", Offset = "0xAB7100", VA = "0x10AB8300")]
    public void InitializeHide()
    {
    }

    [Token(Token = "0x600E3A9")]
    [Address(RVA = "0xAB7EC0", Offset = "0xAB6CC0", VA = "0x10AB7EC0")]
    private void InitializeData(bool isDefenceBadge = false)
    {
    }

    [Token(Token = "0x600E3AA")]
    [Address(RVA = "0xAB8400", Offset = "0xAB7200", VA = "0x10AB8400")]
    public LeagueMatchMapModel()
    {
    }
  }
}
