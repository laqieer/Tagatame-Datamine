// Decompiled with JetBrains decompiler
// Type: SRPG.Models.PortRankingModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003384")]
  public class PortRankingModel
  {
    [Token(Token = "0x400F3BE")]
    [FieldOffset(Offset = "0x8")]
    private bool mRankTextDraw;
    [Token(Token = "0x400F3BF")]
    [FieldOffset(Offset = "0xC")]
    private string mRankText;
    [Token(Token = "0x400F3C0")]
    [FieldOffset(Offset = "0x10")]
    private PortRankingModel.PortRankingData mRankingData;

    [Token(Token = "0x17001FBA")]
    public bool RankTextDraw
    {
      [Token(Token = "0x600E538"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001FBB")]
    public string RankText
    {
      [Token(Token = "0x600E539"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FBC")]
    public PortRankingModel.PortRankingData RankingData
    {
      [Token(Token = "0x600E53A"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (PortRankingModel.PortRankingData) null;
      }
    }

    [Token(Token = "0x600E53B")]
    [Address(RVA = "0xABE660", Offset = "0xABD460", VA = "0x10ABE660")]
    public void SetData(PortRankingModel.PortRankingData _data)
    {
    }

    [Token(Token = "0x600E53C")]
    [Address(RVA = "0xABE6E0", Offset = "0xABD4E0", VA = "0x10ABE6E0")]
    private void SetRankText(int _rank)
    {
    }

    [Token(Token = "0x600E53D")]
    [Address(RVA = "0xABE740", Offset = "0xABD540", VA = "0x10ABE740")]
    public PortRankingModel()
    {
    }

    [Token(Token = "0x2003385")]
    public class PortRankingData
    {
      [Token(Token = "0x400F3C1")]
      [FieldOffset(Offset = "0x8")]
      private int mRank;
      [Token(Token = "0x400F3C2")]
      [FieldOffset(Offset = "0xC")]
      private int mId;
      [Token(Token = "0x400F3C3")]
      [FieldOffset(Offset = "0x10")]
      private string mEmblemName;
      [Token(Token = "0x400F3C4")]
      [FieldOffset(Offset = "0x14")]
      private string mName;
      [Token(Token = "0x400F3C5")]
      [FieldOffset(Offset = "0x18")]
      private int mLevel;
      [Token(Token = "0x400F3C6")]
      [FieldOffset(Offset = "0x1C")]
      private string mMasterName;
      [Token(Token = "0x400F3C7")]
      [FieldOffset(Offset = "0x20")]
      private long mCombatPower;

      [Token(Token = "0x17001FBD")]
      public int Rank
      {
        [Token(Token = "0x600E53E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001FBE")]
      public int Id
      {
        [Token(Token = "0x600E53F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001FBF")]
      public string EmblemName
      {
        [Token(Token = "0x600E540"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001FC0")]
      public string Name
      {
        [Token(Token = "0x600E541"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001FC1")]
      public int Level
      {
        [Token(Token = "0x600E542"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001FC2")]
      public string MasterName
      {
        [Token(Token = "0x600E543"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001FC3")]
      public long CombatPower
      {
        [Token(Token = "0x600E544"), Address(RVA = "0x34F490", Offset = "0x34E290", VA = "0x1034F490")] get
        {
          return new long();
        }
      }

      [Token(Token = "0x600E545")]
      [Address(RVA = "0xABE5F0", Offset = "0xABD3F0", VA = "0x10ABE5F0")]
      public bool Deserialize(JSON_CombatPowerPortRanking _json) => new bool();

      [Token(Token = "0x600E546")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public PortRankingData()
      {
      }
    }
  }
}
