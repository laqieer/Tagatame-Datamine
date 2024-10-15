// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePrideResetWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033BA")]
  public class RunePrideResetWindowModel : RunePrideBaseNeedItemWindowModel
  {
    [Token(Token = "0x400F4EA")]
    [FieldOffset(Offset = "0x48")]
    private string mReturnCoinText;
    [Token(Token = "0x400F4EB")]
    [FieldOffset(Offset = "0x4C")]
    private string mReturnGoldText;
    [Token(Token = "0x400F4EC")]
    [FieldOffset(Offset = "0x50")]
    private bool mIsDispReturnItem;
    [Token(Token = "0x400F4ED")]
    [FieldOffset(Offset = "0x51")]
    private bool mIsDispResetCount;
    [Token(Token = "0x400F4EE")]
    [FieldOffset(Offset = "0x54")]
    private int mNowResetCount;
    [Token(Token = "0x400F4EF")]
    [FieldOffset(Offset = "0x58")]
    private int mMaxResetCount;
    [Token(Token = "0x400F4F0")]
    [FieldOffset(Offset = "0x5C")]
    private string mResetText;

    [Token(Token = "0x170020A4")]
    public string ReturnCoinText
    {
      [Token(Token = "0x600E735"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170020A5")]
    public string ReturnGoldText
    {
      [Token(Token = "0x600E736"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170020A6")]
    public bool IsDispReturnItem
    {
      [Token(Token = "0x600E737"), Address(RVA = "0x2AABD0", Offset = "0x2A99D0", VA = "0x102AABD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020A7")]
    public bool IsDispResetCount
    {
      [Token(Token = "0x600E738"), Address(RVA = "0x2AAB90", Offset = "0x2A9990", VA = "0x102AAB90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020A8")]
    public int NowResetCount
    {
      [Token(Token = "0x600E739"), Address(RVA = "0x349170", Offset = "0x347F70", VA = "0x10349170")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020A9")]
    public int MaxResetCount
    {
      [Token(Token = "0x600E73A"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020AA")]
    public string ResetText
    {
      [Token(Token = "0x600E73B"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E73C")]
    [Address(RVA = "0xAC7790", Offset = "0xAC6590", VA = "0x10AC7790")]
    public void SetUp(
      RunePrideResetParam _reset_param,
      JSON_RunePrideUsedItems _items,
      List<RunePrideItemData> _data_list,
      int _reset_count)
    {
    }

    [Token(Token = "0x600E73D")]
    [Address(RVA = "0xAC5CF0", Offset = "0xAC4AF0", VA = "0x10AC5CF0")]
    public RunePrideResetWindowModel()
    {
    }
  }
}
