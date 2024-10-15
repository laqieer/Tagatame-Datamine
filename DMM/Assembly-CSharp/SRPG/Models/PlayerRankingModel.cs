// Decompiled with JetBrains decompiler
// Type: SRPG.Models.PlayerRankingModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003382")]
  public class PlayerRankingModel
  {
    [Token(Token = "0x400F3AE")]
    [FieldOffset(Offset = "0x8")]
    private bool mRankTextDraw;
    [Token(Token = "0x400F3AF")]
    [FieldOffset(Offset = "0xC")]
    private string mRankText;
    [Token(Token = "0x400F3B0")]
    [FieldOffset(Offset = "0x10")]
    private PlayerRankingModel.PlayerRankingData mRankingData;
    [Token(Token = "0x400F3B1")]
    [FieldOffset(Offset = "0x14")]
    private bool mPortDraw;
    [Token(Token = "0x400F3B2")]
    [FieldOffset(Offset = "0x15")]
    private bool mIsOnly;
    [Token(Token = "0x400F3B3")]
    [FieldOffset(Offset = "0x18")]
    private string mCombatPowerText;
    [Token(Token = "0x400F3B4")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsMyData;

    [Token(Token = "0x17001FAA")]
    public bool RankTextDraw
    {
      [Token(Token = "0x600E523"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001FAB")]
    public string RankText
    {
      [Token(Token = "0x600E524"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FAC")]
    public PlayerRankingModel.PlayerRankingData RankingData
    {
      [Token(Token = "0x600E525"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (PlayerRankingModel.PlayerRankingData) null;
      }
    }

    [Token(Token = "0x17001FAD")]
    public bool PortDraw
    {
      [Token(Token = "0x600E526"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001FAE")]
    public bool IsOnly
    {
      [Token(Token = "0x600E527"), Address(RVA = "0x39C2B0", Offset = "0x39B0B0", VA = "0x1039C2B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001FAF")]
    public string CombatPowerText
    {
      [Token(Token = "0x600E528"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FB0")]
    public bool IsMyData
    {
      [Token(Token = "0x600E529"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E52A")]
    [Address(RVA = "0xABB860", Offset = "0xABA660", VA = "0x10ABB860")]
    public void SetData(PlayerRankingModel.PlayerRankingData _data, bool _isOnly, bool _MyData)
    {
    }

    [Token(Token = "0x600E52B")]
    [Address(RVA = "0xABB990", Offset = "0xABA790", VA = "0x10ABB990")]
    private void SetRankText(int _rank)
    {
    }

    [Token(Token = "0x600E52C")]
    [Address(RVA = "0xABB9F0", Offset = "0xABA7F0", VA = "0x10ABB9F0")]
    public PlayerRankingModel()
    {
    }

    [Token(Token = "0x2003383")]
    public class PlayerRankingData
    {
      [Token(Token = "0x400F3B5")]
      [FieldOffset(Offset = "0x8")]
      private int mRank;
      [Token(Token = "0x400F3B6")]
      [FieldOffset(Offset = "0xC")]
      private string mUnitIconPath;
      [Token(Token = "0x400F3B7")]
      [FieldOffset(Offset = "0x10")]
      private string mName;
      [Token(Token = "0x400F3B8")]
      [FieldOffset(Offset = "0x14")]
      private int mLevel;
      [Token(Token = "0x400F3B9")]
      [FieldOffset(Offset = "0x18")]
      private string mAward;
      [Token(Token = "0x400F3BA")]
      [FieldOffset(Offset = "0x20")]
      private long mCombatPower;
      [Token(Token = "0x400F3BB")]
      [FieldOffset(Offset = "0x28")]
      private string mUid;
      [Token(Token = "0x400F3BC")]
      [FieldOffset(Offset = "0x2C")]
      private string mPortName;
      [Token(Token = "0x400F3BD")]
      [FieldOffset(Offset = "0x30")]
      private int mPortId;

      [Token(Token = "0x17001FB1")]
      public int Rank
      {
        [Token(Token = "0x600E52D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001FB2")]
      public string UnitIconPath
      {
        [Token(Token = "0x600E52E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001FB3")]
      public string Name
      {
        [Token(Token = "0x600E52F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001FB4")]
      public int Level
      {
        [Token(Token = "0x600E530"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001FB5")]
      public string Award
      {
        [Token(Token = "0x600E531"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001FB6")]
      public long CombatPower
      {
        [Token(Token = "0x600E532"), Address(RVA = "0x34F490", Offset = "0x34E290", VA = "0x1034F490")] get
        {
          return new long();
        }
      }

      [Token(Token = "0x17001FB7")]
      public string Uid
      {
        [Token(Token = "0x600E533"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001FB8")]
      public string PortName
      {
        [Token(Token = "0x600E534"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001FB9")]
      public int PortId
      {
        [Token(Token = "0x600E535"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x600E536")]
      [Address(RVA = "0xABB640", Offset = "0xABA440", VA = "0x10ABB640")]
      public bool Deserialize(
        JSON_CombatPowerPlayerRankingData _jsonPlayer,
        JSON_CombatPowerPortRankingData _jsonPort,
        int _rank)
      {
        return new bool();
      }

      [Token(Token = "0x600E537")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public PlayerRankingData()
      {
      }
    }
  }
}
