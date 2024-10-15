// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchBuffModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003357")]
  public class LeagueMatchBuffModel
  {
    [Token(Token = "0x400F254")]
    [FieldOffset(Offset = "0x8")]
    private int _seasonID;
    [Token(Token = "0x400F255")]
    [FieldOffset(Offset = "0xC")]
    private JSON_LeagueMatchBuffs _buffparam;
    [Token(Token = "0x400F256")]
    [FieldOffset(Offset = "0x10")]
    private string _buffIname;
    [Token(Token = "0x400F257")]
    [FieldOffset(Offset = "0x14")]
    private string _buffImageKey;
    [Token(Token = "0x400F258")]
    [FieldOffset(Offset = "0x18")]
    private string _buffName;
    [Token(Token = "0x400F259")]
    [FieldOffset(Offset = "0x1C")]
    private int _buffUseNum;
    [Token(Token = "0x400F25A")]
    [FieldOffset(Offset = "0x20")]
    private int _buffUseNumMax;
    [Token(Token = "0x400F25B")]
    [FieldOffset(Offset = "0x24")]
    private bool _isDefaultBuff;
    [Token(Token = "0x400F25C")]
    [FieldOffset(Offset = "0x28")]
    private string _buffDescription;
    [Token(Token = "0x400F25D")]
    [FieldOffset(Offset = "0x2C")]
    private bool _isSelected;
    [Token(Token = "0x400F25E")]
    [FieldOffset(Offset = "0x2D")]
    private bool _isBuffDisable;
    [Token(Token = "0x400F25F")]
    [FieldOffset(Offset = "0x2E")]
    private bool _isSelectMax;
    [Token(Token = "0x400F260")]
    [FieldOffset(Offset = "0x2F")]
    private bool _isShamBattle;
    [Token(Token = "0x400F261")]
    [FieldOffset(Offset = "0x30")]
    private bool _isEnemyBuff;
    [Token(Token = "0x400F262")]
    [FieldOffset(Offset = "0x31")]
    private bool _isHide;

    [Token(Token = "0x17001EA0")]
    public string BuffIname
    {
      [Token(Token = "0x600E355"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EA1")]
    public string BuffImageKey
    {
      [Token(Token = "0x600E356"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EA2")]
    public string BuffName
    {
      [Token(Token = "0x600E357"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EA3")]
    public int BuffUseNum
    {
      [Token(Token = "0x600E358"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EA4")]
    public int BuffUseNumMax
    {
      [Token(Token = "0x600E359"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EA5")]
    public bool IsDefaultBuff
    {
      [Token(Token = "0x600E35A"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EA6")]
    public string BuffDescription
    {
      [Token(Token = "0x600E35B"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EA7")]
    public bool IsSelected
    {
      [Token(Token = "0x600E35C"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EA8")]
    public bool IsBuffDisable
    {
      [Token(Token = "0x600E35D"), Address(RVA = "0x34B870", Offset = "0x34A670", VA = "0x1034B870")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EA9")]
    public bool IsSelectMax
    {
      [Token(Token = "0x600E35E"), Address(RVA = "0x39CB50", Offset = "0x39B950", VA = "0x1039CB50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EAA")]
    public bool IsShamBattle
    {
      [Token(Token = "0x600E35F"), Address(RVA = "0xAB4EA0", Offset = "0xAB3CA0", VA = "0x10AB4EA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EAB")]
    public bool IsEnemyBuff
    {
      [Token(Token = "0x600E360"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EAC")]
    public bool IsHide
    {
      [Token(Token = "0x600E361"), Address(RVA = "0x7F55A0", Offset = "0x7F43A0", VA = "0x107F55A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E362")]
    [Address(RVA = "0xAB4DC0", Offset = "0xAB3BC0", VA = "0x10AB4DC0")]
    public void Initialize(
      int seasonID,
      JSON_LeagueMatchBuffs buffparam,
      bool is_select_max = false,
      bool is_sham_battle = false)
    {
    }

    [Token(Token = "0x600E363")]
    [Address(RVA = "0xAB4E00", Offset = "0xAB3C00", VA = "0x10AB4E00")]
    public void Initialize(int seasonID, string buff_iname)
    {
    }

    [Token(Token = "0x600E364")]
    [Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")]
    public void Initialize(int seasonID)
    {
    }

    [Token(Token = "0x600E365")]
    [Address(RVA = "0xAB4D30", Offset = "0xAB3B30", VA = "0x10AB4D30")]
    public void InitializeHide()
    {
    }

    [Token(Token = "0x600E366")]
    [Address(RVA = "0xAB4E80", Offset = "0xAB3C80", VA = "0x10AB4E80")]
    public void SetSelectedState(bool is_select, bool is_select_max = false)
    {
    }

    [Token(Token = "0x600E367")]
    [Address(RVA = "0x3A1250", Offset = "0x3A0050", VA = "0x103A1250")]
    public void SetIsEnemyBuffDetail(bool is_enemy_buff)
    {
    }

    [Token(Token = "0x600E368")]
    [Address(RVA = "0xAB4AA0", Offset = "0xAB38A0", VA = "0x10AB4AA0")]
    private void InitializeData()
    {
    }

    [Token(Token = "0x600E369")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchBuffModel()
    {
    }
  }
}
