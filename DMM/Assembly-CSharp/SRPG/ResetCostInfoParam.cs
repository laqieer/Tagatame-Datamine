// Decompiled with JetBrains decompiler
// Type: SRPG.ResetCostInfoParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CB2")]
  public class ResetCostInfoParam
  {
    [Token(Token = "0x40070A6")]
    [FieldOffset(Offset = "0x8")]
    private eResetCostType type;
    [Token(Token = "0x40070A7")]
    [FieldOffset(Offset = "0xC")]
    private string item;
    [Token(Token = "0x40070A8")]
    [FieldOffset(Offset = "0x10")]
    private List<int> num;

    [Token(Token = "0x17000F50")]
    public eResetCostType Type
    {
      [Token(Token = "0x6007625"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new eResetCostType();
      }
    }

    [Token(Token = "0x17000F51")]
    public string Item
    {
      [Token(Token = "0x6007626"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F52")]
    public List<int> Num
    {
      [Token(Token = "0x6007627"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x6007628")]
    [Address(RVA = "0x396930", Offset = "0x395730", VA = "0x10396930")]
    public void Deserialize(JSON_ResetCostInfoParam json)
    {
    }

    [Token(Token = "0x6007629")]
    [Address(RVA = "0x396A40", Offset = "0x395840", VA = "0x10396A40")]
    public int GetNeedNum(int current_reset_count) => new int();

    [Token(Token = "0x600762A")]
    [Address(RVA = "0x396AC0", Offset = "0x3958C0", VA = "0x10396AC0")]
    public ResetCostInfoParam()
    {
    }
  }
}
