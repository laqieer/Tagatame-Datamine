// Decompiled with JetBrains decompiler
// Type: SRPG.Models.MasteryRewardListModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200336F")]
  public class MasteryRewardListModel
  {
    [Token(Token = "0x400F30E")]
    [FieldOffset(Offset = "0x8")]
    private string mCurrentEmblemPath;
    [Token(Token = "0x400F30F")]
    [FieldOffset(Offset = "0xC")]
    private string mNewEmblemPath;
    [Token(Token = "0x400F310")]
    [FieldOffset(Offset = "0x10")]
    private string mListWindowTitle;

    [Token(Token = "0x17001F33")]
    public string CurrentEmblemPath
    {
      [Token(Token = "0x600E44B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F34")]
    public string NewEmblemPath
    {
      [Token(Token = "0x600E44C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F35")]
    public string AchieveTitleString
    {
      [Token(Token = "0x600E44D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E44E")]
    [Address(RVA = "0xABAEF0", Offset = "0xAB9CF0", VA = "0x10ABAEF0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E44F")]
    [Address(RVA = "0xABB030", Offset = "0xAB9E30", VA = "0x10ABB030")]
    public MasteryRewardListModel()
    {
    }
  }
}
