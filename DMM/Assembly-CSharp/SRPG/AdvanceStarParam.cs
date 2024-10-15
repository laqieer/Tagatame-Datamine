// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceStarParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001966")]
  public class AdvanceStarParam
  {
    [Token(Token = "0x4005C73")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4005C74")]
    [FieldOffset(Offset = "0xC")]
    private AdvanceStarRewardParam[] mStars;

    [Token(Token = "0x17000A91")]
    public string Iname
    {
      [Token(Token = "0x600678E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A92")]
    public List<AdvanceStarRewardParam> StarList
    {
      [Token(Token = "0x600678F"), Address(RVA = "0x31B5E0", Offset = "0x31A3E0", VA = "0x1031B5E0")] get
      {
        return (List<AdvanceStarRewardParam>) null;
      }
    }

    [Token(Token = "0x6006790")]
    [Address(RVA = "0x31B320", Offset = "0x31A120", VA = "0x1031B320")]
    public void Deserialize(JSON_AdvanceStarParam json)
    {
    }

    [Token(Token = "0x6006791")]
    [Address(RVA = "0x31B4A0", Offset = "0x31A2A0", VA = "0x1031B4A0")]
    public static void Deserialize(ref List<AdvanceStarParam> list, JSON_AdvanceStarParam[] json)
    {
    }

    [Token(Token = "0x6006792")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdvanceStarParam()
    {
    }
  }
}
